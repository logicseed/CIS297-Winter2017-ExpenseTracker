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
    public partial class AccountEditor : Form
    {
        public AccountEditor()
        {
            InitializeComponent();
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AccountEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);

        }
    }
}
