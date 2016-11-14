﻿using System;
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

        public int workhourspermonth;
        public int salary;
       
        public override int GetBonusPerMonth()
        {
            throw new NotImplementedException();
        }

        public override int GetSalaryPerMonth()
        {
           
            return this.workhourspermonth * this.salary;

        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
