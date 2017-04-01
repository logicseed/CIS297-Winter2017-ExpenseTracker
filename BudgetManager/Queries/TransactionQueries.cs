using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    class TransactionQueries : DatabaseEntity
    {
        public IEnumerable<Transaction> GetTransactionsByAccount(int accountID)
        {
            var transactionsByAccount = from Transactions in finance.Transactions
                                        where Transactions.AccountID == accountID
                                        select Transactions;
            return transactionsByAccount;
        }
    }
}
