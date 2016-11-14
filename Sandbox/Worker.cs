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

        public override int GetBonusPerMonth()
        {
            throw new NotImplementedException();
        }

        public override int GetSalaryPerMonth()
        {
            throw new NotImplementedException();
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
