using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ACMSE
{
    public partial class Form1 : Form
    {
        private EmployeesModelView Employees { get; set; }
        private List<Location> Locations { get; set; }
        private DoorsViewModel Doors { get; set; }
        private DBHelper dbHelper;
        private CurrentLocation CurLocation { get; set; }

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
            try
            {
                _ = dbHelper.db.Connection;
            }
            catch
            {
                MessageBox.Show(
                "Ошибка соединения с БД",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                this.Close();
            }
            Employees = new EmployeesModelView();
            Locations = new List<Location>();
            CurLocation = new CurrentLocation();
        }

        //фильтрация списка сотрудников при вводе символов в поле ввода над списком
        private void TbEmployees_TextChanged(object sender, EventArgs e)
        {
            Employees.Filter(tbEmployees.Text);
        }

        //получение текущего местоположения сотрудника, ФИО которого выделено в списке
        //если местоположение есть, до доступна кнопка "Выход"
        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedValue is int)
            {
                CurLocation = dbHelper.GetCurrentLocation((int)lbEmployees.SelectedValue);
                ExitView(CurLocation.Name);
            }
        }

        private void ExitView(string locationName)
        {
            lblCurLocation.Text = locationName;
            btnGoOut.Enabled = locationName != "";
        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocations.SelectedValue is int) Doors.Filter((int)cmbLocations.SelectedValue);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Формирование списка сотрудников
            // модель отображения для модели Employees
            int i = 0;
            Employees.EmpFullList = dbHelper.GetEmployeesList(i, i + 100);
            while (Employees.EmpFullList.Count % 100 == 0)
            {
                pbLoad.Value = (i % 1000) / 10;
                i += 100;
                Employees.EmpFullList.AddRange(dbHelper.GetEmployeesList(i, i + 100));
            }
            Employees.EmpFilteredList = Employees.EmpFullList;
            Employees.SelectedId = 2;
            //привязка модели отображения к элементу отображения
            lbEmployees.DataBindings.Add(new Binding("DataSource", Employees, "EmpFilteredList", false, DataSourceUpdateMode.OnPropertyChanged));
            lbEmployees.DisplayMember = "NSP";
            lbEmployees.ValueMember = "Id";
            // привязка свойства SelectedValue в ListBox к свойству SelectedId в EmployeesModelView
            lbEmployees.DataBindings.Add(new Binding("SelectedValue", Employees, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));

            //Формирование списка местоположений
            // модель отображения для модели Employees
            Locations = dbHelper.GetLocationsList();
            cmbLocations.DataSource = Locations;
            cmbLocations.DisplayMember = "Name";
            cmbLocations.ValueMember = "Id";

            Doors = new DoorsViewModel(dbHelper.GetDoors());
            //привязка модели отображения к элементу отображения
            cmbDoors.DataBindings.Add(new Binding("DataSource", Doors, "DoorsFilteredList", false, DataSourceUpdateMode.OnPropertyChanged));
            cmbDoors.DisplayMember = "Name";
            cmbDoors.ValueMember = "Id";
            // привязка свойства SelectedValue в ComboBox к свойству SelectedId в DoorsViewModel
            cmbDoors.DataBindings.Add(new Binding("SelectedValue", Doors, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));

            pbLoad.Visible = false;
            ContentLayoutLeft.Visible = true;
            ContentLayoutMiddle.Visible = true;
            ContentLayoutRight.Visible = true;
        }

        private void btnGoOut_Click(object sender, EventArgs e)
        {
            dbHelper.Exit((int)lbEmployees.SelectedValue, CurLocation.Door, 2);
            CurLocation.Name = "";
            CurLocation.Door = 0;
            ExitView(CurLocation.Name);
        }

        private void btnGoIn_Click(object sender, EventArgs e)
        {
            dbHelper.Exit((int)lbEmployees.SelectedValue, (int)cmbDoors.SelectedValue, 1);
            CurLocation.Name = cmbLocations.Text;
            CurLocation.Door = (int)cmbDoors.SelectedValue;
            ExitView(CurLocation.Name);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.db.Close();
        }
    }
}
