namespace BudgetManager
{
    partial class GoalEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label goalIDLabel;
            System.Windows.Forms.Label budgetIDLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalEditor));
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goalTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.GoalTableAdapter();
            this.tableAdapterManager = new BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.goalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.goalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.goalIDTextBox = new System.Windows.Forms.TextBox();
            this.budgetIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            goalIDLabel = new System.Windows.Forms.Label();
            budgetIDLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingNavigator)).BeginInit();
            this.goalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // goalIDLabel
            // 
            goalIDLabel.AutoSize = true;
            goalIDLabel.Location = new System.Drawing.Point(54, 45);
            goalIDLabel.Name = "goalIDLabel";
            goalIDLabel.Size = new System.Drawing.Size(46, 13);
            goalIDLabel.TabIndex = 1;
            goalIDLabel.Text = "Goal ID:";
            // 
            // budgetIDLabel
            // 
            budgetIDLabel.AutoSize = true;
            budgetIDLabel.Location = new System.Drawing.Point(54, 71);
            budgetIDLabel.Name = "budgetIDLabel";
            budgetIDLabel.Size = new System.Drawing.Size(58, 13);
            budgetIDLabel.TabIndex = 3;
            budgetIDLabel.Text = "Budget ID:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(54, 97);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(54, 123);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.databaseDataSet;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.GoalTableAdapter = this.goalTableAdapter;
            this.tableAdapterManager.TransactionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // goalBindingNavigator
            // 
            this.goalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.goalBindingNavigator.BindingSource = this.goalBindingSource;
            this.goalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.goalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.goalBindingNavigatorSaveItem});
            this.goalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goalBindingNavigator.Name = "goalBindingNavigator";
            this.goalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goalBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.goalBindingNavigator.TabIndex = 0;
            this.goalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // goalBindingNavigatorSaveItem
            // 
            this.goalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("goalBindingNavigatorSaveItem.Image")));
            this.goalBindingNavigatorSaveItem.Name = "goalBindingNavigatorSaveItem";
            this.goalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.goalBindingNavigatorSaveItem.Text = "Save Data";
            this.goalBindingNavigatorSaveItem.Click += new System.EventHandler(this.goalBindingNavigatorSaveItem_Click);
            // 
            // goalIDTextBox
            // 
            this.goalIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goalBindingSource, "GoalID", true));
            this.goalIDTextBox.Enabled = false;
            this.goalIDTextBox.Location = new System.Drawing.Point(118, 42);
            this.goalIDTextBox.Name = "goalIDTextBox";
            this.goalIDTextBox.ReadOnly = true;
            this.goalIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.goalIDTextBox.TabIndex = 2;
            // 
            // budgetIDTextBox
            // 
            this.budgetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goalBindingSource, "BudgetID", true));
            this.budgetIDTextBox.Location = new System.Drawing.Point(118, 68);
            this.budgetIDTextBox.Name = "budgetIDTextBox";
            this.budgetIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetIDTextBox.TabIndex = 4;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goalBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(118, 94);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goalBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(118, 120);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 8;
            // 
            // GoalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(goalIDLabel);
            this.Controls.Add(this.goalIDTextBox);
            this.Controls.Add(budgetIDLabel);
            this.Controls.Add(this.budgetIDTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.goalBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoalEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Goal Editor";
            this.Load += new System.EventHandler(this.GoalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingNavigator)).EndInit();
            this.goalBindingNavigator.ResumeLayout(false);
            this.goalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private DatabaseDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator goalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton goalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox goalIDTextBox;
        private System.Windows.Forms.TextBox budgetIDTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}