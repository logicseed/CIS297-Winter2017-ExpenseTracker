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
            InitializeDataGridViewComboBoxes();
        }

        private void InitializeDataGridViewComboBoxes()
        {
            InitializeDataGridViewComboBox(categoryDataGridViewComboBoxColumn);
            InitializeDataGridViewComboBox(goalCategoryDataGridViewComboBoxColumn);
        }

        private void InitializeDataGridViewComboBox(DataGridViewComboBoxColumn comboBox)
        {
            comboBox.ValueType = typeof(TransactionCategory);
            comboBox.ValueMember = "Value";
            comboBox.DisplayMember = "Display";
            comboBox.DataSource =
                new List<TransactionCategory>((TransactionCategory[])Enum.GetValues(typeof(TransactionCategory)))
                .Select(value => new { Display = value.ToString(), Value = (int)value })
                .ToList();
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
            // TODO: This line of code loads data into the 'databaseDataSet.Goal' table. You can move, or remove it, as needed.
            this.goalTableAdapter.Fill(this.databaseDataSet.Goal);
            // TODO: This line of code loads data into the 'databaseDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.databaseDataSet.Transaction);

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
    }
}
