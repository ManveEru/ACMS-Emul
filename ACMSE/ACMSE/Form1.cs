using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMSE
{
    public partial class Form1 : Form
    {
        private EmployeesModelView Employees { get; set; }
        private List<Location> Locations { get; set; }
        private DoorsViewModel Doors { get; set; }
        private DBHelper dbHelper;

        public Form1()
        {
            InitializeComponent();

            dbHelper = new DBHelper();
            Employees = new EmployeesModelView();
            Locations = new List<Location>();
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
                lblCurLocation.Text = dbHelper.GetCurrentLocation((int)lbEmployees.SelectedValue);
                btnGoOut.Enabled = lblCurLocation.Text != "";
            }
        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocations.SelectedValue is int) Doors.Filter((int)cmbLocations.SelectedValue);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Формирование списка сотрудников
            // модель отображения для модели Employees
            Employees.EmpFullList = dbHelper.GetEmployeesList(1, 10);
            for (int i = 10; i < 101; i += 10)
            {
                pbLoad.Value += 10;
                Employees.EmpFullList.AddRange(dbHelper.GetEmployeesList(i - 1, i + 10));
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
    }
}
