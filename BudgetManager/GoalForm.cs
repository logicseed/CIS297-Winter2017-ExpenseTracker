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
    public partial class GoalForm : Form
    {
        private int currentGoalID;
        public GoalForm(int goalID)
        {
            InitializeComponent();
            currentGoalID = goalID;
            categoryComboBox.DataSource = Enum.GetValues(typeof(TransactionCategory));
        }

        private void GoalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Goal' table. You can move, or remove it, as needed.
            this.goalTableAdapter.Fill(this.databaseDataSet.Goal);
            var position = goalBindingSource.Find("GoalID", currentGoalID);
            goalBindingSource.Position = position;
            goalBindingSource.ResetCurrentItem();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            goalBindingSource.EndEdit();
            goalTableAdapter.Update(databaseDataSet.Goal);
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            goalBindingSource.CancelEdit();
            this.Close();
        }

        private void GoalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            goalBindingSource.CancelEdit();
        }
    }
}
