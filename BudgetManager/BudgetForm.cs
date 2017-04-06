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
    public partial class BudgetForm : Form
    {
        private int currentBudgetID;

        public BudgetForm(int budgetID)
        {
            InitializeComponent();

            currentBudgetID = budgetID;
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.databaseDataSet.Budget);
            var position = budgetBindingSource.Find("BudgetID", currentBudgetID);
            budgetBindingSource.Position = position;
            budgetBindingSource.ResetCurrentItem();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var startDate = (DateTime)((DataRowView)budgetBindingSource.Current).Row["StartDate"];
            var endDate = (DateTime)((DataRowView)budgetBindingSource.Current).Row["EndDate"];
            if (endDate < startDate)
            {
                ((DataRowView)budgetBindingSource.Current).Row["EndDate"] = startDate.AddMonths(1);
            }
            budgetBindingSource.EndEdit();
            budgetTableAdapter.Update(databaseDataSet.Budget);
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            budgetBindingSource.CancelEdit();
            this.Close();
        }

        private void BudgetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            budgetBindingSource.CancelEdit();
        }
    }
}
