using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void debugDbEditorButton_Click(object sender, EventArgs e)
        {
            var debugDbEditor = new DebugDbEditor();
            debugDbEditor.ShowDialog();
        }

        private void mockUpBtn_Click(object sender, EventArgs e)
        {
            var mockUp = new Mockup();
            mockUp.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.databaseDataSet.Budget);
            // TODO: This line of code loads data into the 'databaseDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);
            // TODO: This line of code loads data into the 'databaseDataSet.Goal' table. You can move, or remove it, as needed.
            this.goalTableAdapter.Fill(this.databaseDataSet.Goal);
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);
            RefreshAccountInfo();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            transactionTableAdapter.Fill(databaseDataSet.Transaction);
            transactionGridView.Update();
            transactionGridView.Refresh();
            goalTableAdapter.Fill(databaseDataSet.Goal);
            goalGridView.Update();
            goalGridView.Refresh();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            var newAccount = databaseDataSet.Account.NewAccountRow();
            newAccount.Name = "New Account";
            newAccount.Type = AccountType.Cash;
            databaseDataSet.Account.Rows.Add(newAccount);
            accountTableAdapter.Update(databaseDataSet.Account);
            var position = accountBindingSource.Find("AccountID", newAccount.AccountID);
            accountBindingSource.Position = position;

            var accountForm = new AccountForm(newAccount.AccountID);
            accountForm.ShowDialog();

            accountTableAdapter.Fill(databaseDataSet.Account);
            accountBindingSource.Position = position;
            accountBindingSource.ResetCurrentItem();
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            var account = (int)((DataRowView)accountBindingSource.Current).Row["AccountID"];
            var accountForm = new AccountForm(account);
            accountForm.ShowDialog();

            accountTableAdapter.Fill(databaseDataSet.Account);
            var position = accountBindingSource.Find("AccountID", account);
            accountBindingSource.Position = position;
            accountBindingSource.ResetCurrentItem();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            var newTransaction = databaseDataSet.Transaction.NewTransactionRow();
            newTransaction.AccountID = (int)((DataRowView)accountBindingSource.Current).Row["AccountID"];
            newTransaction.Amount = 0.0f;
            newTransaction.Memo = "No memo";
            newTransaction.Category = TransactionCategory.Uncategorized;
            newTransaction.Date = DateTime.Now;
            databaseDataSet.Transaction.Rows.Add(newTransaction);
            transactionTableAdapter.Update(databaseDataSet.Transaction);
            var transactionID = newTransaction.TransactionID;
            var position = transactionBindingSource.Find("TransactionID", transactionID);
            transactionBindingSource.Position = position;

            var transactionForm = new TransactionForm(newTransaction.TransactionID);
            transactionForm.ShowDialog();

            transactionTableAdapter.Fill(databaseDataSet.Transaction);
            position = transactionBindingSource.Find("TransactionID", transactionID);
            accountBindingSource.Position = position;
            accountBindingSource.ResetCurrentItem();
        }

        private void editTransactionButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = transactionGridView.SelectedRows[0].Index;
            var transactionID = (int)transactionGridView.CurrentRow.Cells[0].Value;
            var transactionForm = new TransactionForm(transactionID);
            transactionForm.ShowDialog();

            transactionTableAdapter.Fill(databaseDataSet.Transaction);
            var position = transactionBindingSource.Find("TransactionID", transactionID);
            accountBindingSource.Position = position;
            accountBindingSource.ResetCurrentItem();
            transactionGridView.ClearSelection();
            transactionGridView.Rows[selectedIndex].Selected = true;
        }

        private void accountNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAccountInfo();
        }

        private void RefreshAccountInfo()
        {
            if (accountBindingSource.Count > 0)
            {
                var accountID = (int)((DataRowView)accountBindingSource.Current).Row["AccountID"];
                transactionBindingSource.RemoveFilter();
                transactionBindingSource.Filter = "AccountID = " + accountID;
            }
        }
    }
}
