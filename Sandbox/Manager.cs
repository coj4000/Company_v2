using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        public int monthlysalary;
        public int bonuspermonth;

        public Manager(string name) : base(name)
        {
        }
        
        public override int GetBonusPerMonth()
        {

            return bonuspermonth;
        }

        public override int GetSalaryPerMonth()
        {
            return this.monthlysalary;
        }

        public override bool IsBonusPaidOut()
        {
            return true;
        }
    }
}
