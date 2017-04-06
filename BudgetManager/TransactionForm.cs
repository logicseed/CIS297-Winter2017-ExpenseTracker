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
    public partial class TransactionForm : Form
    {
        int currentTransactionID;
        public TransactionForm(int transactionID)
        {
            InitializeComponent();
            currentTransactionID = transactionID;
            categoryComboBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            var position = transactionBindingSource.Find("TransactionID", currentTransactionID);
            transactionBindingSource.Position = position;
            transactionBindingSource.ResetCurrentItem();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            transactionBindingSource.EndEdit();
            transactionTableAdapter.Update(databaseDataSet.Transaction);
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            transactionBindingSource.CancelEdit();
            this.Close();
        }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            transactionBindingSource.CancelEdit();
        }
    }
}
