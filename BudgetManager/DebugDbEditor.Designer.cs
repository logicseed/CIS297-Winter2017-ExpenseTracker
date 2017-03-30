namespace BudgetManager
{
    partial class DebugDbEditor
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
            System.Windows.Forms.Label accountIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label goalIDLabel;
            System.Windows.Forms.Label budgetIDLabel1;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label accountIDLabel1;
            System.Windows.Forms.Label categoryLabel1;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label amountLabel1;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugDbEditor));
            System.Windows.Forms.Label budgetIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.budgetTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.BudgetTableAdapter();
            this.goalTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.GoalTableAdapter();
            this.transactionTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.accountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accountIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.budgetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.budgetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.goalIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetIDNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.goalCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.goalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.goalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.transactionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transactionIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accountIDNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.transactionCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.budgetIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            accountIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            goalIDLabel = new System.Windows.Forms.Label();
            budgetIDLabel1 = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            transactionIDLabel = new System.Windows.Forms.Label();
            accountIDLabel1 = new System.Windows.Forms.Label();
            categoryLabel1 = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            amountLabel1 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            budgetIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).BeginInit();
            this.accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountIDNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingNavigator)).BeginInit();
            this.budgetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingNavigator)).BeginInit();
            this.goalBindingNavigator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingNavigator)).BeginInit();
            this.transactionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIDNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new System.Drawing.Point(39, 51);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new System.Drawing.Size(64, 13);
            accountIDLabel.TabIndex = 1;
            accountIDLabel.Text = "Account ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(39, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(39, 106);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Type:";
            // 
            // goalIDLabel
            // 
            goalIDLabel.AutoSize = true;
            goalIDLabel.Location = new System.Drawing.Point(46, 61);
            goalIDLabel.Name = "goalIDLabel";
            goalIDLabel.Size = new System.Drawing.Size(46, 13);
            goalIDLabel.TabIndex = 6;
            goalIDLabel.Text = "Goal ID:";
            // 
            // budgetIDLabel1
            // 
            budgetIDLabel1.AutoSize = true;
            budgetIDLabel1.Location = new System.Drawing.Point(46, 87);
            budgetIDLabel1.Name = "budgetIDLabel1";
            budgetIDLabel1.Size = new System.Drawing.Size(58, 13);
            budgetIDLabel1.TabIndex = 8;
            budgetIDLabel1.Text = "Budget ID:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(46, 116);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "Category:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(46, 140);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 12;
            amountLabel.Text = "Amount:";
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(27, 52);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(80, 13);
            transactionIDLabel.TabIndex = 0;
            transactionIDLabel.Text = "Transaction ID:";
            // 
            // accountIDLabel1
            // 
            accountIDLabel1.AutoSize = true;
            accountIDLabel1.Location = new System.Drawing.Point(27, 78);
            accountIDLabel1.Name = "accountIDLabel1";
            accountIDLabel1.Size = new System.Drawing.Size(64, 13);
            accountIDLabel1.TabIndex = 2;
            accountIDLabel1.Text = "Account ID:";
            // 
            // categoryLabel1
            // 
            categoryLabel1.AutoSize = true;
            categoryLabel1.Location = new System.Drawing.Point(27, 107);
            categoryLabel1.Name = "categoryLabel1";
            categoryLabel1.Size = new System.Drawing.Size(52, 13);
            categoryLabel1.TabIndex = 4;
            categoryLabel1.Text = "Category:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(27, 134);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 6;
            memoLabel.Text = "Memo:";
            // 
            // amountLabel1
            // 
            amountLabel1.AutoSize = true;
            amountLabel1.Location = new System.Drawing.Point(27, 157);
            amountLabel1.Name = "amountLabel1";
            amountLabel1.Size = new System.Drawing.Size(46, 13);
            amountLabel1.TabIndex = 8;
            amountLabel1.Text = "Amount:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(27, 187);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "Date:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.databaseDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = this.budgetTableAdapter;
            this.tableAdapterManager.GoalTableAdapter = this.goalTableAdapter;
            this.tableAdapterManager.TransactionTableAdapter = this.transactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // accountBindingNavigator
            // 
            this.accountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountBindingNavigator.BindingSource = this.accountBindingSource;
            this.accountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accountBindingNavigatorSaveItem});
            this.accountBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.accountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountBindingNavigator.Name = "accountBindingNavigator";
            this.accountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountBindingNavigator.Size = new System.Drawing.Size(281, 25);
            this.accountBindingNavigator.TabIndex = 0;
            this.accountBindingNavigator.Text = "bindingNavigator1";
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
            // accountBindingNavigatorSaveItem
            // 
            this.accountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountBindingNavigatorSaveItem.Image")));
            this.accountBindingNavigatorSaveItem.Name = "accountBindingNavigatorSaveItem";
            this.accountBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountBindingNavigatorSaveItem.Text = "Save Data";
            this.accountBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountBindingNavigatorSaveItem_Click);
            // 
            // accountIDNumericUpDown
            // 
            this.accountIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "AccountID", true));
            this.accountIDNumericUpDown.Enabled = false;
            this.accountIDNumericUpDown.Location = new System.Drawing.Point(109, 51);
            this.accountIDNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.accountIDNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accountIDNumericUpDown.Name = "accountIDNumericUpDown";
            this.accountIDNumericUpDown.ReadOnly = true;
            this.accountIDNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.accountIDNumericUpDown.TabIndex = 2;
            this.accountIDNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(109, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Type", true));
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountBindingSource, "Type", true));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(109, 103);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountBindingNavigator);
            this.groupBox1.Controls.Add(accountIDLabel);
            this.groupBox1.Controls.Add(this.accountIDNumericUpDown);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(typeLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(budgetIDLabel);
            this.groupBox2.Controls.Add(this.budgetIDNumericUpDown);
            this.groupBox2.Controls.Add(startDateLabel);
            this.groupBox2.Controls.Add(this.startDateDateTimePicker);
            this.groupBox2.Controls.Add(endDateLabel);
            this.groupBox2.Controls.Add(this.endDateDateTimePicker);
            this.groupBox2.Controls.Add(this.budgetBindingNavigator);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 144);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Budgets";
            // 
            // budgetBindingNavigator
            // 
            this.budgetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.budgetBindingNavigator.BindingSource = this.budgetBindingSource;
            this.budgetBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.budgetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.budgetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.budgetBindingNavigatorSaveItem});
            this.budgetBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.budgetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.budgetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.budgetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.budgetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.budgetBindingNavigator.Name = "budgetBindingNavigator";
            this.budgetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.budgetBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.budgetBindingNavigator.TabIndex = 4;
            this.budgetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.databaseDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // budgetBindingNavigatorSaveItem
            // 
            this.budgetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.budgetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("budgetBindingNavigatorSaveItem.Image")));
            this.budgetBindingNavigatorSaveItem.Name = "budgetBindingNavigatorSaveItem";
            this.budgetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.budgetBindingNavigatorSaveItem.Text = "Save Data";
            this.budgetBindingNavigatorSaveItem.Click += new System.EventHandler(this.budgetBindingNavigatorSaveItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(goalIDLabel);
            this.groupBox3.Controls.Add(this.goalIDNumericUpDown);
            this.groupBox3.Controls.Add(budgetIDLabel1);
            this.groupBox3.Controls.Add(this.budgetIDNumericUpDown1);
            this.groupBox3.Controls.Add(categoryLabel);
            this.groupBox3.Controls.Add(this.goalCategoryComboBox);
            this.groupBox3.Controls.Add(amountLabel);
            this.groupBox3.Controls.Add(this.amountNumericUpDown);
            this.groupBox3.Controls.Add(this.goalBindingNavigator);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 221);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Goals";
            // 
            // goalIDNumericUpDown
            // 
            this.goalIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goalBindingSource, "GoalID", true));
            this.goalIDNumericUpDown.Enabled = false;
            this.goalIDNumericUpDown.Location = new System.Drawing.Point(110, 61);
            this.goalIDNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.goalIDNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.goalIDNumericUpDown.Name = "goalIDNumericUpDown";
            this.goalIDNumericUpDown.ReadOnly = true;
            this.goalIDNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.goalIDNumericUpDown.TabIndex = 7;
            this.goalIDNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.databaseDataSet;
            // 
            // budgetIDNumericUpDown1
            // 
            this.budgetIDNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goalBindingSource, "BudgetID", true));
            this.budgetIDNumericUpDown1.Location = new System.Drawing.Point(110, 87);
            this.budgetIDNumericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.budgetIDNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.budgetIDNumericUpDown1.Name = "budgetIDNumericUpDown1";
            this.budgetIDNumericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.budgetIDNumericUpDown1.TabIndex = 9;
            this.budgetIDNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // goalCategoryComboBox
            // 
            this.goalCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goalBindingSource, "Category", true));
            this.goalCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goalBindingSource, "Category", true));
            this.goalCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goalCategoryComboBox.FormattingEnabled = true;
            this.goalCategoryComboBox.Location = new System.Drawing.Point(110, 113);
            this.goalCategoryComboBox.Name = "goalCategoryComboBox";
            this.goalCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.goalCategoryComboBox.TabIndex = 11;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goalBindingSource, "Amount", true));
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(110, 140);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.amountNumericUpDown.TabIndex = 13;
            // 
            // goalBindingNavigator
            // 
            this.goalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.goalBindingNavigator.BindingSource = this.goalBindingSource;
            this.goalBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.goalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.goalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2,
            this.goalBindingNavigatorSaveItem});
            this.goalBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.goalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.goalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.goalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.goalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.goalBindingNavigator.Name = "goalBindingNavigator";
            this.goalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.goalBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.goalBindingNavigator.TabIndex = 6;
            this.goalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.transactionBindingNavigator);
            this.groupBox4.Controls.Add(transactionIDLabel);
            this.groupBox4.Controls.Add(this.transactionIDNumericUpDown);
            this.groupBox4.Controls.Add(accountIDLabel1);
            this.groupBox4.Controls.Add(this.accountIDNumericUpDown1);
            this.groupBox4.Controls.Add(categoryLabel1);
            this.groupBox4.Controls.Add(this.transactionCategoryComboBox);
            this.groupBox4.Controls.Add(memoLabel);
            this.groupBox4.Controls.Add(this.memoTextBox);
            this.groupBox4.Controls.Add(amountLabel1);
            this.groupBox4.Controls.Add(this.amountNumericUpDown1);
            this.groupBox4.Controls.Add(dateLabel);
            this.groupBox4.Controls.Add(this.dateDateTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(305, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 221);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transactions";
            // 
            // transactionBindingNavigator
            // 
            this.transactionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.transactionBindingNavigator.BindingSource = this.transactionBindingSource;
            this.transactionBindingNavigator.CountItem = this.bindingNavigatorCountItem3;
            this.transactionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.transactionBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.transactionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3,
            this.transactionBindingNavigatorSaveItem});
            this.transactionBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.transactionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.transactionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.transactionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.transactionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.transactionBindingNavigator.Name = "transactionBindingNavigator";
            this.transactionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem3;
            this.transactionBindingNavigator.Size = new System.Drawing.Size(281, 25);
            this.transactionBindingNavigator.TabIndex = 12;
            this.transactionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.databaseDataSet;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "of {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Move previous";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Position";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Move last";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
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
            // transactionIDNumericUpDown
            // 
            this.transactionIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "TransactionID", true));
            this.transactionIDNumericUpDown.Enabled = false;
            this.transactionIDNumericUpDown.Location = new System.Drawing.Point(113, 52);
            this.transactionIDNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.transactionIDNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionIDNumericUpDown.Name = "transactionIDNumericUpDown";
            this.transactionIDNumericUpDown.ReadOnly = true;
            this.transactionIDNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.transactionIDNumericUpDown.TabIndex = 1;
            this.transactionIDNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // accountIDNumericUpDown1
            // 
            this.accountIDNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "AccountID", true));
            this.accountIDNumericUpDown1.Location = new System.Drawing.Point(113, 78);
            this.accountIDNumericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.accountIDNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accountIDNumericUpDown1.Name = "accountIDNumericUpDown1";
            this.accountIDNumericUpDown1.Size = new System.Drawing.Size(143, 20);
            this.accountIDNumericUpDown1.TabIndex = 3;
            this.accountIDNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transactionCategoryComboBox
            // 
            this.transactionCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Category", true));
            this.transactionCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transactionBindingSource, "Category", true));
            this.transactionCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionCategoryComboBox.FormattingEnabled = true;
            this.transactionCategoryComboBox.Location = new System.Drawing.Point(113, 104);
            this.transactionCategoryComboBox.Name = "transactionCategoryComboBox";
            this.transactionCategoryComboBox.Size = new System.Drawing.Size(143, 21);
            this.transactionCategoryComboBox.TabIndex = 5;
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Memo", true));
            this.memoTextBox.Location = new System.Drawing.Point(113, 131);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(143, 20);
            this.memoTextBox.TabIndex = 7;
            // 
            // amountNumericUpDown1
            // 
            this.amountNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "Amount", true));
            this.amountNumericUpDown1.DecimalPlaces = 2;
            this.amountNumericUpDown1.Location = new System.Drawing.Point(113, 157);
            this.amountNumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountNumericUpDown1.Name = "amountNumericUpDown1";
            this.amountNumericUpDown1.Size = new System.Drawing.Size(143, 20);
            this.amountNumericUpDown1.TabIndex = 9;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(113, 183);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dateDateTimePicker.TabIndex = 11;
            // 
            // budgetIDLabel
            // 
            budgetIDLabel.AutoSize = true;
            budgetIDLabel.Location = new System.Drawing.Point(40, 51);
            budgetIDLabel.Name = "budgetIDLabel";
            budgetIDLabel.Size = new System.Drawing.Size(58, 13);
            budgetIDLabel.TabIndex = 4;
            budgetIDLabel.Text = "Budget ID:";
            // 
            // budgetIDNumericUpDown
            // 
            this.budgetIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "BudgetID", true));
            this.budgetIDNumericUpDown.Location = new System.Drawing.Point(104, 51);
            this.budgetIDNumericUpDown.Name = "budgetIDNumericUpDown";
            this.budgetIDNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.budgetIDNumericUpDown.TabIndex = 5;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(40, 81);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(104, 77);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.startDateDateTimePicker.TabIndex = 7;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(40, 107);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 8;
            endDateLabel.Text = "End Date:";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(104, 103);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.endDateDateTimePicker.TabIndex = 9;
            // 
            // DebugDbEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 394);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugDbEditor";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DebugDbEditor";
            this.Load += new System.EventHandler(this.DebugDbEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).EndInit();
            this.accountBindingNavigator.ResumeLayout(false);
            this.accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountIDNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingNavigator)).EndInit();
            this.budgetBindingNavigator.ResumeLayout(false);
            this.budgetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingNavigator)).EndInit();
            this.goalBindingNavigator.ResumeLayout(false);
            this.goalBindingNavigator.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingNavigator)).EndInit();
            this.transactionBindingNavigator.ResumeLayout(false);
            this.transactionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIDNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DatabaseDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton accountBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown accountIDNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private DatabaseDataSetTableAdapters.BudgetTableAdapter budgetTableAdapter;
        private System.Windows.Forms.BindingNavigator budgetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton budgetBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private DatabaseDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private System.Windows.Forms.BindingNavigator goalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton goalBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown goalIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown budgetIDNumericUpDown1;
        private System.Windows.Forms.ComboBox goalCategoryComboBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.BindingNavigator transactionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.ToolStripButton transactionBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown transactionIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown accountIDNumericUpDown1;
        private System.Windows.Forms.ComboBox transactionCategoryComboBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.NumericUpDown budgetIDNumericUpDown;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
    }
}