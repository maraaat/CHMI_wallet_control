using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CHMI2.BudgetPlanning
{
    public class Goal
    {
        public string name;
        public int total;
        public int start;
        public int bal=0;

        public Goal()
        {
        }

        public Goal(string name, int total, int start)
        {
            this.name = name;
            this.total = total;
            this.start = start;
            bal += start;
        }

        public void PlanDep(int dep)
        {
            bal += dep;
        }
        public void PlanWithd(int sum)
        {
            bal -= sum;
        }
    }
}
