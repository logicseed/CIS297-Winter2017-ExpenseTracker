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
    public partial class Mockup : Form
    {
        AccountQueries accountQ = new AccountQueries();
        TransactionQueries transactionQ = new TransactionQueries();

        public Mockup()
        {
            InitializeComponent();
        }

        private void Mockup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Goal' table. You can move, or remove it, as needed.
            this.goalTableAdapter.Fill(this.databaseDataSet.Goal);
            // TODO: This line of code loads data into the 'databaseDataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.databaseDataSet.Budget);
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);

            comboBox2.DataSource = accountQ.GetAccounts().ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "AccountID";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == AccountType.BankAccount.ToString())
                accountQ.InsertAccount(comboBox2.Text, Convert.ToInt16(AccountType.BankAccount));
            else if (comboBox3.Text == AccountType.Cash.ToString())
                accountQ.InsertAccount(comboBox2.Text, Convert.ToInt16(AccountType.Cash));
            else if (comboBox3.Text == AccountType.CreditCard.ToString())
                accountQ.InsertAccount(comboBox2.Text, Convert.ToInt16(AccountType.CreditCard));
            else if (comboBox3.Text == AccountType.InvestmentAccount.ToString())
                accountQ.InsertAccount(comboBox2.Text, Convert.ToInt16(AccountType.InvestmentAccount));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accountQ.SaveChanges();
            comboBox2.DataSource = accountQ.GetAccounts().ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "AccountID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = transactionQ.GetTransactionsByAccount(Convert.ToInt16(comboBox2.SelectedValue)).ToList();
        }
    }
}
