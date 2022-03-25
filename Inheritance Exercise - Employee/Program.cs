using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise___Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Spongebob");

            SalariedEmployee salEmp2 = new SalariedEmployee("Clark Kent", 45000);

            HourlyEmployee hourlyEmp3 = new HourlyEmployee("Batman", 40.0m);
            hourlyEmp3.AddTime(30);
            decimal hours = hourlyEmp3.HoursWorked();

            //Left off at top of page 41
        }
    }
}
