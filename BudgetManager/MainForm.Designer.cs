namespace BudgetManager
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label budgetIDLabel;
            System.Windows.Forms.Label startDateLabel1;
            System.Windows.Forms.Label endDateLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mockUpBtn = new System.Windows.Forms.Button();
            this.budgetTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editTransactionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addTransactionsButton = new System.Windows.Forms.Button();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editAccountButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accountNameComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.goalGridView = new System.Windows.Forms.DataGridView();
            this.goalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalCategoryDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetDelete = new System.Windows.Forms.Button();
            this.budgetAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetCombo = new System.Windows.Forms.ComboBox();
            this.debugDbEditorButton = new System.Windows.Forms.Button();
            this.transactionTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.goalTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.GoalTableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            this.accountTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.BudgetTableAdapter();
            this.budgetIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataGridViewSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            budgetIDLabel = new System.Windows.Forms.Label();
            startDateLabel1 = new System.Windows.Forms.Label();
            endDateLabel1 = new System.Windows.Forms.Label();
            this.budgetTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mockUpBtn
            // 
            this.mockUpBtn.Location = new System.Drawing.Point(466, 560);
            this.mockUpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mockUpBtn.Name = "mockUpBtn";
            this.mockUpBtn.Size = new System.Drawing.Size(112, 29);
            this.mockUpBtn.TabIndex = 5;
            this.mockUpBtn.Text = "MockUp";
            this.mockUpBtn.UseVisualStyleBackColor = true;
            this.mockUpBtn.Click += new System.EventHandler(this.mockUpBtn_Click);
            // 
            // budgetTab
            // 
            this.budgetTab.Controls.Add(this.tabPage2);
            this.budgetTab.Controls.Add(this.tabPage4);
            this.budgetTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTab.Location = new System.Drawing.Point(12, 12);
            this.budgetTab.Name = "budgetTab";
            this.budgetTab.SelectedIndex = 0;
            this.budgetTab.Size = new System.Drawing.Size(704, 537);
            this.budgetTab.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.editTransactionButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.accountBalanceLabel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.addTransactionsButton);
            this.tabPage2.Controls.Add(this.transactionGridView);
            this.tabPage2.Controls.Add(this.editAccountButton);
            this.tabPage2.Controls.Add(this.addAccountButton);
            this.tabPage2.Controls.Add(this.accountNameComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editTransactionButton
            // 
            this.editTransactionButton.Location = new System.Drawing.Point(549, 415);
            this.editTransactionButton.Name = "editTransactionButton";
            this.editTransactionButton.Size = new System.Drawing.Size(141, 28);
            this.editTransactionButton.TabIndex = 16;
            this.editTransactionButton.Text = "Edit Transaction";
            this.editTransactionButton.UseVisualStyleBackColor = true;
            this.editTransactionButton.Click += new System.EventHandler(this.editTransactionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Account Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Type", true));
            this.label4.Location = new System.Drawing.Point(138, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.databaseDataSet;
            this.accountBindingSource.CurrentChanged += new System.EventHandler(this.accountBindingSource_CurrentChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(138, 58);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(45, 16);
            this.accountBalanceLabel.TabIndex = 13;
            this.accountBalanceLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Account Balance:";
            // 
            // addTransactionsButton
            // 
            this.addTransactionsButton.Location = new System.Drawing.Point(402, 415);
            this.addTransactionsButton.Name = "addTransactionsButton";
            this.addTransactionsButton.Size = new System.Drawing.Size(141, 28);
            this.addTransactionsButton.TabIndex = 11;
            this.addTransactionsButton.Text = "Add Transaction";
            this.addTransactionsButton.UseVisualStyleBackColor = true;
            this.addTransactionsButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AutoGenerateColumns = false;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewComboBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.transactionDataGridViewSpacer});
            this.transactionGridView.DataSource = this.transactionBindingSource;
            this.transactionGridView.Location = new System.Drawing.Point(7, 152);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.ReadOnly = true;
            this.transactionGridView.RowHeadersVisible = false;
            this.transactionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionGridView.Size = new System.Drawing.Size(683, 257);
            this.transactionGridView.TabIndex = 10;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.databaseDataSet;
            // 
            // editAccountButton
            // 
            this.editAccountButton.Location = new System.Drawing.Point(586, 19);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(104, 28);
            this.editAccountButton.TabIndex = 9;
            this.editAccountButton.Text = "Edit Account";
            this.editAccountButton.UseVisualStyleBackColor = true;
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(476, 19);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(104, 28);
            this.addAccountButton.TabIndex = 7;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // accountNameComboBox
            // 
            this.accountNameComboBox.DataSource = this.accountBindingSource;
            this.accountNameComboBox.DisplayMember = "Name";
            this.accountNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNameComboBox.FormattingEnabled = true;
            this.accountNameComboBox.Location = new System.Drawing.Point(6, 19);
            this.accountNameComboBox.Name = "accountNameComboBox";
            this.accountNameComboBox.Size = new System.Drawing.Size(245, 24);
            this.accountNameComboBox.TabIndex = 0;
            this.accountNameComboBox.ValueMember = "AccountID";
            this.accountNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.accountNameComboBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(budgetIDLabel);
            this.tabPage4.Controls.Add(this.budgetIDNumericUpDown);
            this.tabPage4.Controls.Add(startDateLabel1);
            this.tabPage4.Controls.Add(this.startDateDateTimePicker);
            this.tabPage4.Controls.Add(endDateLabel1);
            this.tabPage4.Controls.Add(this.endDateDateTimePicker);
            this.tabPage4.Controls.Add(this.endDateLabel);
            this.tabPage4.Controls.Add(this.startDateLabel);
            this.tabPage4.Controls.Add(this.goalGridView);
            this.tabPage4.Controls.Add(this.budgetDelete);
            this.tabPage4.Controls.Add(this.budgetAdd);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.budgetCombo);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(696, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Budgets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // goalGridView
            // 
            this.goalGridView.AutoGenerateColumns = false;
            this.goalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goalIDDataGridViewTextBoxColumn,
            this.budgetIDDataGridViewTextBoxColumn,
            this.goalCategoryDataGridViewComboBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.goalDataGridViewSpacer});
            this.goalGridView.DataSource = this.goalBindingSource;
            this.goalGridView.Location = new System.Drawing.Point(7, 241);
            this.goalGridView.Name = "goalGridView";
            this.goalGridView.RowHeadersVisible = false;
            this.goalGridView.Size = new System.Drawing.Size(683, 261);
            this.goalGridView.TabIndex = 9;
            // 
            // goalIDDataGridViewTextBoxColumn
            // 
            this.goalIDDataGridViewTextBoxColumn.DataPropertyName = "GoalID";
            this.goalIDDataGridViewTextBoxColumn.HeaderText = "GoalID";
            this.goalIDDataGridViewTextBoxColumn.Name = "goalIDDataGridViewTextBoxColumn";
            this.goalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goalIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // budgetIDDataGridViewTextBoxColumn
            // 
            this.budgetIDDataGridViewTextBoxColumn.DataPropertyName = "BudgetID";
            this.budgetIDDataGridViewTextBoxColumn.HeaderText = "BudgetID";
            this.budgetIDDataGridViewTextBoxColumn.Name = "budgetIDDataGridViewTextBoxColumn";
            this.budgetIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // goalCategoryDataGridViewComboBoxColumn
            // 
            this.goalCategoryDataGridViewComboBoxColumn.DataPropertyName = "Category";
            this.goalCategoryDataGridViewComboBoxColumn.HeaderText = "Category";
            this.goalCategoryDataGridViewComboBoxColumn.Name = "goalCategoryDataGridViewComboBoxColumn";
            this.goalCategoryDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goalCategoryDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.goalCategoryDataGridViewComboBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.amountDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // goalDataGridViewSpacer
            // 
            this.goalDataGridViewSpacer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goalDataGridViewSpacer.HeaderText = "";
            this.goalDataGridViewSpacer.Name = "goalDataGridViewSpacer";
            this.goalDataGridViewSpacer.ReadOnly = true;
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.databaseDataSet;
            // 
            // budgetDelete
            // 
            this.budgetDelete.Location = new System.Drawing.Point(567, 30);
            this.budgetDelete.Name = "budgetDelete";
            this.budgetDelete.Size = new System.Drawing.Size(118, 28);
            this.budgetDelete.TabIndex = 7;
            this.budgetDelete.Text = "Edit Budget";
            this.budgetDelete.UseVisualStyleBackColor = true;
            // 
            // budgetAdd
            // 
            this.budgetAdd.Location = new System.Drawing.Point(443, 30);
            this.budgetAdd.Name = "budgetAdd";
            this.budgetAdd.Size = new System.Drawing.Size(118, 28);
            this.budgetAdd.TabIndex = 6;
            this.budgetAdd.Text = "Add Budget";
            this.budgetAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "End:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start:";
            // 
            // budgetCombo
            // 
            this.budgetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.budgetCombo.FormattingEnabled = true;
            this.budgetCombo.Location = new System.Drawing.Point(36, 34);
            this.budgetCombo.Name = "budgetCombo";
            this.budgetCombo.Size = new System.Drawing.Size(169, 24);
            this.budgetCombo.TabIndex = 0;
            // 
            // debugDbEditorButton
            // 
            this.debugDbEditorButton.AutoSize = true;
            this.debugDbEditorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugDbEditorButton.Image = global::BudgetManager.Properties.Resources.debug_editor;
            this.debugDbEditorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debugDbEditorButton.Location = new System.Drawing.Point(583, 555);
            this.debugDbEditorButton.Name = "debugDbEditorButton";
            this.debugDbEditorButton.Padding = new System.Windows.Forms.Padding(5);
            this.debugDbEditorButton.Size = new System.Drawing.Size(129, 38);
            this.debugDbEditorButton.TabIndex = 4;
            this.debugDbEditorButton.Text = "Debug DB Editor";
            this.debugDbEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debugDbEditorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.debugDbEditorButton.UseVisualStyleBackColor = true;
            this.debugDbEditorButton.Click += new System.EventHandler(this.debugDbEditorButton_Click);
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(52, 566);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "debug refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GoalTableAdapter = null;
            this.tableAdapterManager.TransactionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(327, 30);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(45, 16);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "label6";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(327, 51);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(45, 16);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "label7";
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.databaseDataSet;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // budgetIDLabel
            // 
            budgetIDLabel.AutoSize = true;
            budgetIDLabel.Location = new System.Drawing.Point(155, 130);
            budgetIDLabel.Name = "budgetIDLabel";
            budgetIDLabel.Size = new System.Drawing.Size(70, 16);
            budgetIDLabel.TabIndex = 11;
            budgetIDLabel.Text = "Budget ID:";
            // 
            // budgetIDNumericUpDown
            // 
            this.budgetIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "BudgetID", true));
            this.budgetIDNumericUpDown.Location = new System.Drawing.Point(231, 130);
            this.budgetIDNumericUpDown.Name = "budgetIDNumericUpDown";
            this.budgetIDNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.budgetIDNumericUpDown.TabIndex = 12;
            // 
            // startDateLabel1
            // 
            startDateLabel1.AutoSize = true;
            startDateLabel1.Location = new System.Drawing.Point(155, 162);
            startDateLabel1.Name = "startDateLabel1";
            startDateLabel1.Size = new System.Drawing.Size(70, 16);
            startDateLabel1.TabIndex = 13;
            startDateLabel1.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(231, 158);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateDateTimePicker.TabIndex = 14;
            // 
            // endDateLabel1
            // 
            endDateLabel1.AutoSize = true;
            endDateLabel1.Location = new System.Drawing.Point(155, 190);
            endDateLabel1.Name = "endDateLabel1";
            endDateLabel1.Size = new System.Drawing.Size(67, 16);
            endDateLabel1.TabIndex = 15;
            endDateLabel1.Text = "End Date:";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(231, 186);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateDateTimePicker.TabIndex = 16;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewComboBoxColumn
            // 
            this.categoryDataGridViewComboBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewComboBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewComboBoxColumn.Name = "categoryDataGridViewComboBoxColumn";
            this.categoryDataGridViewComboBoxColumn.ReadOnly = true;
            this.categoryDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewComboBoxColumn.Width = 200;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "2017-01-01";
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDataGridViewSpacer
            // 
            this.transactionDataGridViewSpacer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionDataGridViewSpacer.HeaderText = "";
            this.transactionDataGridViewSpacer.Name = "transactionDataGridViewSpacer";
            this.transactionDataGridViewSpacer.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 604);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.budgetTab);
            this.Controls.Add(this.mockUpBtn);
            this.Controls.Add(this.debugDbEditorButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.budgetTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button debugDbEditorButton;
        private System.Windows.Forms.Button mockUpBtn;
        private System.Windows.Forms.TabControl budgetTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.ComboBox accountNameComboBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button budgetDelete;
        private System.Windows.Forms.Button budgetAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox budgetCombo;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private DatabaseDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private System.Windows.Forms.DataGridView goalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn goalCategoryDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewSpacer;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DatabaseDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addTransactionsButton;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editTransactionButton;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private DatabaseDataSetTableAdapters.BudgetTableAdapter budgetTableAdapter;
        private System.Windows.Forms.NumericUpDown budgetIDNumericUpDown;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDataGridViewSpacer;
    }
}

