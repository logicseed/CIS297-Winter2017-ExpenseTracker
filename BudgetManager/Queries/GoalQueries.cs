using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Queries
{
    class GoalQueries : DatabaseEntity
    {
        public IEnumerable<Goal> GetTransactionsByAccount(int budgetID)
        {
            var goalsByBudget = from Goals in finance.Goals
                                where Goals.BudgetID == budgetID
                                select Goals;
            return goalsByBudget;
        }
    }
}
