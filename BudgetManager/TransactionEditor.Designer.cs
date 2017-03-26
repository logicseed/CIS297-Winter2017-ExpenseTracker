namespace BudgetManager
{
    partial class TransactionEditor
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
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label accountIDLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionEditor));
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.tableAdapterManager = new BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.transactionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.transactionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transactionIDTextBox = new System.Windows.Forms.TextBox();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            transactionIDLabel = new System.Windows.Forms.Label();
            accountIDLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingNavigator)).BeginInit();
            this.transactionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(12, 37);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(80, 13);
            transactionIDLabel.TabIndex = 1;
            transactionIDLabel.Text = "Transaction ID:";
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new System.Drawing.Point(12, 63);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new System.Drawing.Size(64, 13);
            accountIDLabel.TabIndex = 3;
            accountIDLabel.Text = "Account ID:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(12, 90);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(59, 13);
            dateTimeLabel.TabIndex = 5;
            dateTimeLabel.Text = "Date Time:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(12, 115);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(12, 141);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 9;
            memoLabel.Text = "Memo:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(12, 167);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 11;
            amountLabel.Text = "Amount:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.databaseDataSet;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.GoalTableAdapter = null;
            this.tableAdapterManager.TransactionTableAdapter = this.transactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transactionBindingNavigator
            // 
            this.transactionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transactionBindingNavigator.BindingSource = this.transactionBindingSource;
            this.transactionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transactionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transactionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transactionBindingNavigatorSaveItem});
            this.transactionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transactionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transactionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transactionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transactionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transactionBindingNavigator.Name = "transactionBindingNavigator";
            this.transactionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transactionBindingNavigator.Size = new System.Drawing.Size(318, 25);
            this.transactionBindingNavigator.TabIndex = 0;
            this.transactionBindingNavigator.Text = "bindingNavigator1";
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
            // transactionBindingNavigatorSaveItem
            // 
            this.transactionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transactionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transactionBindingNavigatorSaveItem.Image")));
            this.transactionBindingNavigatorSaveItem.Name = "transactionBindingNavigatorSaveItem";
            this.transactionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transactionBindingNavigatorSaveItem.Text = "Save Data";
            this.transactionBindingNavigatorSaveItem.Click += new System.EventHandler(this.transactionBindingNavigatorSaveItem_Click);
            // 
            // transactionIDTextBox
            // 
            this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TransactionID", true));
            this.transactionIDTextBox.Enabled = false;
            this.transactionIDTextBox.Location = new System.Drawing.Point(98, 34);
            this.transactionIDTextBox.Name = "transactionIDTextBox";
            this.transactionIDTextBox.ReadOnly = true;
            this.transactionIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.transactionIDTextBox.TabIndex = 2;
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "AccountID", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(98, 60);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.accountIDTextBox.TabIndex = 4;
            // 
            // dateTimeDateTimePicker
            // 
            this.dateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "DateTime", true));
            this.dateTimeDateTimePicker.Location = new System.Drawing.Point(98, 86);
            this.dateTimeDateTimePicker.Name = "dateTimeDateTimePicker";
            this.dateTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDateTimePicker.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(98, 112);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoryTextBox.TabIndex = 8;
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Memo", true));
            this.memoTextBox.Location = new System.Drawing.Point(98, 138);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 20);
            this.memoTextBox.TabIndex = 10;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(98, 164);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountTextBox.TabIndex = 12;
            // 
            // TransactionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 201);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(this.transactionIDTextBox);
            this.Controls.Add(accountIDLabel);
            this.Controls.Add(this.accountIDTextBox);
            this.Controls.Add(dateTimeLabel);
            this.Controls.Add(this.dateTimeDateTimePicker);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.transactionBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Editor";
            this.Load += new System.EventHandler(this.TransactionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingNavigator)).EndInit();
            this.transactionBindingNavigator.ResumeLayout(false);
            this.transactionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transactionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transactionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox transactionIDTextBox;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeDateTimePicker;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}