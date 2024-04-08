using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHMI2.BudgetPlanning
{
    public class Plans
    {
        public List<Goal> goals = new List<Goal>();


        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

    }
}
