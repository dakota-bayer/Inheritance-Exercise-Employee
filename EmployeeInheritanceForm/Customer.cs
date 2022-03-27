using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceForm
{
    class Customer : Person
    {
        public int CreditLimit { get; set; }

        public Customer(int creditLimit, string name) : base(name)
        {
            this.CreditLimit = creditLimit;
        }
    }
}
