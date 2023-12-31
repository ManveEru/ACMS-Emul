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

        public Form1()
        {
            InitializeComponent();
            Employees = new EmployeesModelView();
            lbEmployees.DataBindings.Add(new Binding("DataSource", Employees, "EmpFilteredList", false, DataSourceUpdateMode.OnPropertyChanged));
            lbEmployees.DisplayMember = "NSP";
            lbEmployees.ValueMember = "Id";
            // привязка свойства SelectedValue в ListBox к свойству SelectedId в MainViewModel
            lbEmployees.DataBindings.Add(new Binding("SelectedValue", Employees, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void TbEmployees_TextChanged(object sender, EventArgs e)
        {
            Employees.Filter(tbEmployees.Text);
        }
    }
}
