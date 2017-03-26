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

        private void accountEditorButton_Click(object sender, EventArgs e)
        {
            var accountEditor = new AccountEditor();
            accountEditor.ShowDialog();
        }

        private void budgetEditorButton_Click(object sender, EventArgs e)
        {
            var budgetEditor = new BudgetEditor();
            budgetEditor.ShowDialog();
        }

        private void goalEditorButton_Click(object sender, EventArgs e)
        {
            var goalEditor = new GoalEditor();
            goalEditor.ShowDialog();
        }

        private void transactionEditorButton_Click(object sender, EventArgs e)
        {
            var transactionEditor = new TransactionEditor();
            transactionEditor.ShowDialog();
        }
    }
}
