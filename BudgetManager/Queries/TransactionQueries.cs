using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    class TransactionQueries : DatabaseEntity
    {
        public void InsertTransaction(int accountID, double amount, int category, DateTime date, string memo)
        {
            if (finance.Transactions.Count() == 0)
            {
                Transaction transaction = new Transaction
                {
                    AccountID = accountID,
                    Amount = amount,
                    Category = category,
                    Date = date,
                    Memo = memo,
                    TransactionID = 1
                };
                finance.Transactions.Add(transaction);
            }
            else
            {
                var newTransactionID = (from Transactions in finance.Transactions
                                 orderby Transactions.TransactionID descending
                                 select (Transactions)).First().TransactionID + 1;

                Transaction transaction = new Transaction
                {
                    AccountID = accountID,
                    Amount = amount,
                    Category = category,
                    Date = date,
                    Memo = memo,
                    TransactionID = 1
                };
                finance.Transactions.Add(transaction);
            }
        }

        public IEnumerable<Transaction> GetTransactionsByAccount(int accountID)
        {
            var transactionsByAccount = from Transactions in finance.Transactions
                                        where Transactions.AccountID == accountID
                                        select Transactions;
            return transactionsByAccount;
        }

        public IEnumerable<Transaction> GetTransactionsByCategory(int category)
        {
            var transactionsByCategory = from Transactions in finance.Transactions
                                        where Transactions.Category == category
                                        select Transactions;
            return transactionsByCategory;
        }

        public double AmountsByAccount(int accountID)
        {
            double total = 0;

            var transactionsByAccount = GetTransactionsByAccount(accountID);
            foreach(Transaction transactions in transactionsByAccount)
            {
                if (transactions.Category == Convert.ToInt32(TransactionCategory.Income)
                    || transactions.Category == Convert.ToInt32(TransactionCategory.CreditCardPayment))
                {
                    total += transactions.Amount;
                }
                else
                {
                    total -= transactions.Amount;
                }
            }
            return total;
        }

        public double AmountsByCategory(int category)
        {
            double total = 0;

            var transactionsByCategory = GetTransactionsByCategory(category);
            foreach (Transaction transactions in transactionsByCategory)
            {
                total += transactions.Amount;
            }
            return total;
        }

        public void DeleteTransaction(int transactionID)
        {
            var transactionToRemove = (from Transactions in finance.Transactions
                                       where Transactions.TransactionID == transactionID
                                       select Transactions).Single();
            finance.Transactions.Remove(transactionToRemove);
        }
    }
}
