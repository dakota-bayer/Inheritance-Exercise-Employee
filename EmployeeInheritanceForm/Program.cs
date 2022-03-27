using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInheritanceForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Random r = new Random();
            List<Employee> employees = new List<Employee>();
            string[] employeeNames = { "Superman", "Green Lantern", "Batman", "Spider Man", "Thor", "Hal Jordan", "Wonder Woman", "Captain America" };

            foreach (string name in employeeNames)
            {
                Employee emp = null;

                if (name.Length > 7) //create hourly employee
                {
                    decimal payRate = (decimal)r.NextDouble() * 20 + 10; //Random number between 10 and 30
                    HourlyEmployee hrlyEmp = new HourlyEmployee(name, payRate);
                    hrlyEmp.AddTime(r.Next(30, 480)); //Add random time worked to employee
                    emp = hrlyEmp; //Assign to the Employee variable that is added to the List
                }
                else //create salaried employees
                {
                    decimal salary = r.Next(40000, 80000);
                    emp = new SalariedEmployee(name, salary);
                }
                employees.Add(emp);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeInheritanceForm(employees)); //This is modified to call the EmployeeInheritanceForm constructor with the employees list as an argument
        }
    }
}
