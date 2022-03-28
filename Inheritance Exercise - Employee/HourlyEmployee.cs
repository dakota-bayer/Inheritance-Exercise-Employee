using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise___Employee
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

        public override double PaidOutMonthly()
        {
            return (double) HoursWorked() * (double) PayRate;
        }
    }
}
