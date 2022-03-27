using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInheritanceForm
{
    public partial class EmployeeInheritanceForm : Form
    {
        List<Employee> employees;
        public EmployeeInheritanceForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();

            lblDetails.Text = employeeDetails();
            lblNumEmployees.Text = employees.Count.ToString();
            lblTotalGrossPay.Text = string.Format("{0:c}", totalGrossPay());
            lblAverageGrossPay.Text = string.Format("{0:c}", averageGrossPay());

        }
        private decimal totalGrossPay()
        {
            decimal result = 0;
            foreach(Employee e in employees)
            {
                result += e.GrossPay();
            }
            return result;
        }
        private decimal averageGrossPay()
        {
            return totalGrossPay() / employees.Count;
        }
        private string employeeDetails()
        {
            string result = "";
            foreach(Employee e in employees)
            {
                result += string.Format("Name: {0}, Gross Pay: {1:c}\n", e.Name, e.GrossPay());
            }
            return result;
        }

    }
}
