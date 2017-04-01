using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    class DatabaseEntity
    {
        protected FinanceEntities finance;

        public DatabaseEntity()
        {
            finance = new FinanceEntities();
        }

        public void SaveChanges()
        {
            finance.SaveChanges();
        }
    }
}
