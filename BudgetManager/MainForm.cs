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

        private void debugDbEditorButton_Click(object sender, EventArgs e)
        {
            var debugDbEditor = new DebugDbEditor();
            debugDbEditor.ShowDialog();
        }
    }
}
