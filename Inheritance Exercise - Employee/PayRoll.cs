using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise___Employee
{
    class PayRoll
    {
        private List<Employee> employees;

        public PayRoll()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public double TotalMonthlyPayroll()
        {
            double result = 0;

            foreach(Employee e in employees)
            {
                result += e.PaidOutMonthly();
            }

            return result;
        }
    }
}
