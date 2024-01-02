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
        private EmployeesModelView Employees { get; }
        private List<Location> Locations { get; }
        private DoorsViewModel Doors { get; }

        public Form1()
        {
            InitializeComponent();
            
            //Формирование списка сотрудников
            // модель отображения для модели Employees
            Employees = new EmployeesModelView();
            //привязка модели отображения к элементу отображения
            lbEmployees.DataBindings.Add(new Binding("DataSource", Employees, "EmpFilteredList", false, DataSourceUpdateMode.OnPropertyChanged));
            lbEmployees.DisplayMember = "NSP";
            lbEmployees.ValueMember = "Id";
            // привязка свойства SelectedValue в ListBox к свойству SelectedId в EmployeesModelView
            lbEmployees.DataBindings.Add(new Binding("SelectedValue", Employees, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));

            //Формирование списка местоположений
            // модель отображения для модели Employees
            Doors = new DoorsViewModel();
            Locations = new List<Location>();
            Locations.Add(new Location(1, "СТО"));
            Locations.Add(new Location(2, "Склад"));
            Locations.Add(new Location(3, "Главный корпус"));
            cmbLocations.DataSource = Locations;
            cmbLocations.DisplayMember = "Name";
            cmbLocations.ValueMember = "Id";
            //привязка модели отображения к элементу отображения
            cmbDoors.DataBindings.Add(new Binding("DataSource", Doors, "DoorsFilteredList", false, DataSourceUpdateMode.OnPropertyChanged));
            cmbDoors.DisplayMember = "Name";
            cmbDoors.ValueMember = "Id";
            // привязка свойства SelectedValue в ComboBox к свойству SelectedId в DoorsViewModel
            cmbDoors.DataBindings.Add(new Binding("SelectedValue", Doors, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));
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
            string location = "";
            //DBHelper.GetCurrentLocation((Int32)lbEmployees.SelectedValue)
            if ((int)lbEmployees.SelectedValue > 1) //заменить на запрос из БД
                location = "Home";
            lblCurLocation.Text = location;
            btnGoOut.Enabled = location != "";
        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Doors.Filter((int)cmbLocations.SelectedValue);
            }
            catch
            {
            }
        }
    }
}
