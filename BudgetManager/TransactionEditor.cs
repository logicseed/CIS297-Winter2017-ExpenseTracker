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
    public partial class TransactionEditor : Form
    {
        public TransactionEditor()
        {
            InitializeComponent();
        }

        private void transactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void TransactionEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);

        }
    }
}
