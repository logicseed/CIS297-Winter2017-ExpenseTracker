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
    public partial class DebugDbEditor : Form
    {
        public DebugDbEditor()
        {
            InitializeComponent();

            typeComboBox.DataSource = Enum.GetValues(typeof(AccountType));
            goalCategoryComboBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
            transactionCategoryComboBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void DebugDbEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);
            // TODO: This line of code loads data into the 'databaseDataSet.Goal' table. You can move, or remove it, as needed.
            this.goalTableAdapter.Fill(this.databaseDataSet.Goal);
            // TODO: This line of code loads data into the 'databaseDataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.databaseDataSet.Budget);
            // TODO: This line of code loads data into the 'databaseDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);

        }

        private void budgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void goalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void transactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
