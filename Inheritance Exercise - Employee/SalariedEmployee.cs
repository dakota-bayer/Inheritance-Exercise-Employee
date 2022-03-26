using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise___Employee
{
    class SalariedEmployee : Employee
    {
        /*
         * Note how this class does not have property to store name
         * This is available though because we pass the name to the Employee class
         * So, NOTE how SalariedEmployee class does NOT have a property for name
         */
        public decimal AnnualSalary { get; set; }
        public SalariedEmployee(string name, decimal salary) : base(name)
        {
            this.AnnualSalary = salary;
        }

        public override decimal GrossPay()
        {
            return AnnualSalary / 52 * 2;
        }
    }
}
