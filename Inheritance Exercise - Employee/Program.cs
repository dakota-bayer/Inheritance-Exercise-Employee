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
            //Employee emp1 = new Employee("Spongebob");

            SalariedEmployee salEmp2 = new SalariedEmployee("Clark Kent", 45000);

            HourlyEmployee hourlyEmp3 = new HourlyEmployee("Batman", 40.0m);
            hourlyEmp3.AddTime(30);
            decimal hours = hourlyEmp3.HoursWorked();

            //emp1.AddTime(60);
            //decimal h2 = emp1.HoursWorked();
            //salEmp2 = AddTime(90);
            //decimal h3 = salEmp2.HoursWorked();
            //These doesn't work beacuse you cannot call methods declared in a object's subclasses or an object's sibling classes

            //But you can call methods in super classes (if they are declared public)
            //string n1 = emp1.Name;
            string n2 = salEmp2.Name;
            string n3 = hourlyEmp3.Name;

            Console.WriteLine(hours);
            Console.ReadLine();
        }
    }
}
