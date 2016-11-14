using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        public Worker(string name) : base(name)
        {
        }

        public int workhours;
        public int salary;
        public int HoursWorkedPerMonth(int hours)
        {
            this.workhours = hours;
            return workhours;
        }

        public int SalaryPerHour(int money)
        {
            this.salary = money;
            return salary;
        }
        public override int GetBonusPerMonth()
        {
            throw new NotImplementedException();
        }

        public override int GetSalaryPerMonth()
        {
            int pay = this.workhours * this.salary;
            return pay;

        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
