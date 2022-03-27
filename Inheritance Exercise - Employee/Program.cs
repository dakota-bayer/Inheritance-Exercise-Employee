﻿using System;
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

            //SalariedEmployee salEmp2 = new SalariedEmployee("Clark Kent", 45000);

            //HourlyEmployee hourlyEmp3 = new HourlyEmployee("Batman", 40.0m);
            //hourlyEmp3.AddTime(30);
            //decimal hours = hourlyEmp3.HoursWorked();

            //emp1.AddTime(60);
            //decimal h2 = emp1.HoursWorked();
            //salEmp2 = AddTime(90);
            //decimal h3 = salEmp2.HoursWorked();
            //These doesn't work beacuse you cannot call methods declared in a object's subclasses or an object's sibling classes

            //But you can call methods in super classes (if they are declared public)
            //string n1 = emp1.Name;
            //string n2 = salEmp2.Name;
            //string n3 = hourlyEmp3.Name;

            Random r = new Random();
            List<Employee> employees = new List<Employee>();
            string[] employeeNames = { "Superman", "Green Lantern", "Batman", "Spider Man", "Thor", "Hal Jordan", "Wonder Woman", "Captain America" };

            foreach (string name in employeeNames)
            {
                Employee emp = null;

                if(name.Length > 7) //create hourly employee
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


            //Console.WriteLine(hours);
            Console.ReadLine();
        }
    }
}
