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
        private CurrentLocation CurLocation { get; set; } //текущее местоположение выбранного сотрудника
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Form1()
        {
            Logger.Info("Emulator started.");
            InitializeComponent();
            dbHelper = new DBHelper();
            try
            {
                Logger.Debug("Connecting to Data Base...");
                _ = dbHelper.db.Connection;
            }
            catch
            {
                Logger.Error("Data Base connection fail.");
                MessageBox.Show(
                "Ошибка соединения с БД",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                this.Close();
            }
            Logger.Info("Data Base connection done.");
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
                Logger.Debug("Employee's current location is " + CurLocation.Name);
                CurrentLocationView(CurLocation.Name);
            }
        }

        private void CurrentLocationView(string locationName)
        {
            lblCurLocation.Text = locationName;
            btnGoOut.Enabled = locationName != "";
        }

        //фильтрация списка дверей при смене выбора местополжения
        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocations.SelectedValue is int) Doors.Filter((int)cmbLocations.SelectedValue);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Формирование списка сотрудников
            int i = 0;
            Employees.EmpFullList = dbHelper.GetEmployeesList(i, i + 100);
            Logger.Debug(Employees.EmpFullList.Count + " employees received.");
            while (Employees.EmpFullList.Count % 100 == 0)
            {
                pbLoad.Value = (i % 1000) / 10;
                i += 100;
                Employees.EmpFullList.AddRange(dbHelper.GetEmployeesList(i, i + 100));
                Logger.Debug(Employees.EmpFullList.Count + " employees received.");
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
            Logger.Debug("Locations received.");
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
            dbHelper.Move((int)lbEmployees.SelectedValue, CurLocation.Door, 2);
            Logger.Debug(lbEmployees.Text + " left " + CurLocation.Name + ".");
            CurLocation.Name = "";
            CurLocation.Door = 0;
            CurrentLocationView(CurLocation.Name);
        }

        private void btnGoIn_Click(object sender, EventArgs e)
        {
            dbHelper.Move((int)lbEmployees.SelectedValue, (int)cmbDoors.SelectedValue, 1);
            CurLocation.Name = cmbLocations.Text;
            CurLocation.Door = (int)cmbDoors.SelectedValue;
            Logger.Info(lbEmployees.Text + " entered the " + CurLocation.Name + ".");
            CurrentLocationView(CurLocation.Name);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.db.Close();
        }
    }
}
