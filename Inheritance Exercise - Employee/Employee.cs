using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise___Employee
{
    class Employee : Person
    {
        public Employee(string name) :  base (name)
        {
            //Going to make a change
        }

        public virtual double PaidOutMonthly()
        {
            //declaring as "virtual" allows you to override the method
            double result = 0;

            return result;
        }
    }
}
