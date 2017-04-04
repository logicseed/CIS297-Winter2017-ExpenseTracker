using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Queries
{
    class GoalQueries : DatabaseEntity
    {
        public void InsertGoal(double amount, int budgetID, int category)
        {
            if (finance.Goals.Count() == 0)
            {
                Goal goal = new Goal
                {
                    Amount = amount,
                    BudgetID = budgetID,
                    Category = category,
                    GoalID = 1,
                };
                finance.Goals.Add(goal);
            }
            else
            {
                var newGoalID = (from Goals in finance.Goals
                                   orderby Goals.GoalID descending
                                   select (Goals)).First().GoalID + 1;

                Goal goal = new Goal
                {
                    Amount = amount,
                    BudgetID = budgetID,
                    Category = category,
                    GoalID = 1,
                };
                finance.Goals.Add(goal);
            }
        }
        public IEnumerable<Goal> GetGoalsByBudget(int budgetID)
        {
            var goalsByBudget = from Goals in finance.Goals
                                where Goals.BudgetID == budgetID
                                select Goals;
            return goalsByBudget;
        }

        public void DeleteGoal(int goalID)
        {
            var goalToRemove = (from Goals in finance.Goals
                                   where Goals.GoalID == goalID
                                   select Goals).Single();
            finance.Goals.Remove(goalToRemove);
        }
    }
}
