using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceForm
{
    class HourlyEmployee : Employee
    {
        public decimal PayRate { get; set; }
        private int minutesWorked;

        public HourlyEmployee(string name, decimal payRate) : base(name)
        {
            this.PayRate = payRate;
            this.minutesWorked = 0;
        }

        public void AddTime(int minutes)
        {
            this.minutesWorked += minutes;
        }

        public decimal HoursWorked()
        {
            return minutesWorked / 60.0m;
        }

        //Without the GrossPay method in each subclass of employee, we'll get an error since the subclass doesn't contain a method that was declared abstract in the superclass
        public override decimal GrossPay()
        {
            return HoursWorked() * PayRate;
        }

    }
}
