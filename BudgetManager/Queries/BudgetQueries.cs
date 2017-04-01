using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Queries
{
    class BudgetQueries : DatabaseEntity
    {
        public void InsertBudget(string name, DateTime startDate, DateTime endDate)
        {
            if (finance.Budgets.Count() == 0)
            {
                Budget budget = new Budget
                {
                    //Does DB start at 1 or 0?
                    BudgetID = 1,
                    StartDate = startDate,
                    EndDate = endDate
                };
                finance.Budgets.Add(budget);
            }
            else
            {
                var newBudgetID = (from Budgets in finance.Budgets
                                    orderby Budgets.BudgetID descending
                                    select (Budgets)).First().BudgetID + 1;

                Budget budget = new Budget
                {
                    BudgetID = newBudgetID,
                    StartDate = startDate,
                    EndDate = endDate
                };
                finance.Budgets.Add(budget);
            }
        }

        public IEnumerable<Budget> GetBudgets()
        {
            var budgetsList = from Budgets in finance.Budgets
                              select Budgets;
            return budgetsList;
        }

        public void DeleteBudget(int budgetID)
        {
            //Find budget by ID
            //Remove all goals associated with this budget
            //Remove budget
        }
    }
}
