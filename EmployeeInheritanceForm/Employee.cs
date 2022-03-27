using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceForm
{
    public abstract class Employee : Person
    {
        public Employee(string name) : base(name)
        {
        }
        public abstract decimal GrossPay();
        /*
         * This being abstract means there is no implementation of GrossPay in the Employee class
         * This method will call the GrossPay method from a subclass of Employee
         * BUT, because the Employee class is abstract, there could not be any plain Employee objects that aren't either salaried or hourly
         */
    }
}
