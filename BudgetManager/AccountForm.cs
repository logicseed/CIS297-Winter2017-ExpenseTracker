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
    public partial class AccountForm : Form
    {
        int currentAccountID = 1;

        public AccountForm(int accountID)
        {
            InitializeComponent();

            currentAccountID = accountID;
            typeComboBox.DataSource = Enum.GetValues(typeof(AccountType));
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);
            var position = accountBindingSource.Find("AccountID", currentAccountID);
            accountBindingSource.Position = position;
            accountBindingSource.ResetCurrentItem();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            accountBindingSource.EndEdit();
            accountTableAdapter.Update(databaseDataSet.Account);
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            accountBindingSource.CancelEdit();
            this.Close();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            accountBindingSource.CancelEdit();
        }
    }
}
