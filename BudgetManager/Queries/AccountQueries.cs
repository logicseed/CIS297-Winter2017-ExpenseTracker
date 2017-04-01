using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    class AccountQueries : DatabaseEntity
    {
        public void InsertAccount(string name, int type)
        {
            if (finance.Accounts.Count() == 0)
            {
                Account account = new Account
                {
                    AccountID = 1,
                    Name = name,
                    Type = type
                };
                finance.Accounts.Add(account);
            }
            else
            {
                var newAccountID = (from Accounts in finance.Accounts
                                    orderby Accounts.AccountID descending
                                    select (Accounts)).First().AccountID + 1;

                Account account = new Account
                {
                    AccountID = newAccountID,
                    Name = name,
                    Type = type
                };
                finance.Accounts.Add(account);
            }
        }

        public IEnumerable<Account> GetAccounts()
        {
            var accountsList = from Accounts in finance.Accounts
                               orderby Accounts.Name
                               select Accounts;
            return accountsList;
        }

        public void DeleteAccount(int accountID)
        {
            var accountToRemove = (from Accounts in finance.Accounts
                                  where Accounts.AccountID == accountID
                                  select Accounts).Single();

            //Need to reassign transactions
            finance.Accounts.Remove(accountToRemove);
        }
    }
}
