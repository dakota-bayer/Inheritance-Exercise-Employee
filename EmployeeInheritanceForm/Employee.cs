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
    }
}
