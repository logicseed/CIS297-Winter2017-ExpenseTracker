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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mockUpBtn = new System.Windows.Forms.Button();
            this.budgetTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.transSave = new System.Windows.Forms.Button();
            this.transDelete = new System.Windows.Forms.Button();
            this.transAdd = new System.Windows.Forms.Button();
            this.transType = new System.Windows.Forms.ComboBox();
            this.transCombo = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.budgetSave = new System.Windows.Forms.Button();
            this.budgetDelete = new System.Windows.Forms.Button();
            this.budgetAdd = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.budgetCombo = new System.Windows.Forms.ComboBox();
            this.debugDbEditorButton = new System.Windows.Forms.Button();
            this.transactionTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goalTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.GoalTableAdapter();
            this.goalGridView = new System.Windows.Forms.DataGridView();
            this.goalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalCategoryDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataGridViewSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.budgetTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalGridView)).BeginInit();
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
            this.tabPage2.Controls.Add(this.transactionGridView);
            this.tabPage2.Controls.Add(this.transSave);
            this.tabPage2.Controls.Add(this.transDelete);
            this.tabPage2.Controls.Add(this.transAdd);
            this.tabPage2.Controls.Add(this.transType);
            this.tabPage2.Controls.Add(this.transCombo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // transactionGridView
            // 
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
            this.transactionGridView.Location = new System.Drawing.Point(7, 245);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.RowHeadersVisible = false;
            this.transactionGridView.Size = new System.Drawing.Size(683, 257);
            this.transactionGridView.TabIndex = 10;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transSave
            // 
            this.transSave.Location = new System.Drawing.Point(527, 87);
            this.transSave.Name = "transSave";
            this.transSave.Size = new System.Drawing.Size(118, 28);
            this.transSave.TabIndex = 9;
            this.transSave.Text = "Save";
            this.transSave.UseVisualStyleBackColor = true;
            // 
            // transDelete
            // 
            this.transDelete.Location = new System.Drawing.Point(527, 53);
            this.transDelete.Name = "transDelete";
            this.transDelete.Size = new System.Drawing.Size(118, 28);
            this.transDelete.TabIndex = 8;
            this.transDelete.Text = "Delete";
            this.transDelete.UseVisualStyleBackColor = true;
            // 
            // transAdd
            // 
            this.transAdd.Location = new System.Drawing.Point(527, 19);
            this.transAdd.Name = "transAdd";
            this.transAdd.Size = new System.Drawing.Size(118, 28);
            this.transAdd.TabIndex = 7;
            this.transAdd.Text = "Add";
            this.transAdd.UseVisualStyleBackColor = true;
            // 
            // transType
            // 
            this.transType.FormattingEnabled = true;
            this.transType.Location = new System.Drawing.Point(312, 19);
            this.transType.Name = "transType";
            this.transType.Size = new System.Drawing.Size(147, 24);
            this.transType.TabIndex = 1;
            this.transType.Text = "Type";
            // 
            // transCombo
            // 
            this.transCombo.FormattingEnabled = true;
            this.transCombo.Location = new System.Drawing.Point(6, 19);
            this.transCombo.Name = "transCombo";
            this.transCombo.Size = new System.Drawing.Size(245, 24);
            this.transCombo.TabIndex = 0;
            this.transCombo.Text = "Account Name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.goalGridView);
            this.tabPage4.Controls.Add(this.budgetSave);
            this.tabPage4.Controls.Add(this.budgetDelete);
            this.tabPage4.Controls.Add(this.budgetAdd);
            this.tabPage4.Controls.Add(this.endDate);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.startDate);
            this.tabPage4.Controls.Add(this.budgetCombo);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(696, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Budgets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // budgetSave
            // 
            this.budgetSave.Location = new System.Drawing.Point(541, 92);
            this.budgetSave.Name = "budgetSave";
            this.budgetSave.Size = new System.Drawing.Size(118, 28);
            this.budgetSave.TabIndex = 8;
            this.budgetSave.Text = "Save";
            this.budgetSave.UseVisualStyleBackColor = true;
            // 
            // budgetDelete
            // 
            this.budgetDelete.Location = new System.Drawing.Point(541, 58);
            this.budgetDelete.Name = "budgetDelete";
            this.budgetDelete.Size = new System.Drawing.Size(118, 28);
            this.budgetDelete.TabIndex = 7;
            this.budgetDelete.Text = "Delete";
            this.budgetDelete.UseVisualStyleBackColor = true;
            // 
            // budgetAdd
            // 
            this.budgetAdd.Location = new System.Drawing.Point(541, 24);
            this.budgetAdd.Name = "budgetAdd";
            this.budgetAdd.Size = new System.Drawing.Size(118, 28);
            this.budgetAdd.TabIndex = 6;
            this.budgetAdd.Text = "Add";
            this.budgetAdd.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(273, 95);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(221, 22);
            this.endDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "End:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(273, 45);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(221, 22);
            this.startDate.TabIndex = 1;
            // 
            // budgetCombo
            // 
            this.budgetCombo.FormattingEnabled = true;
            this.budgetCombo.Location = new System.Drawing.Point(17, 43);
            this.budgetCombo.Name = "budgetCombo";
            this.budgetCombo.Size = new System.Drawing.Size(169, 24);
            this.budgetCombo.TabIndex = 0;
            this.budgetCombo.Text = "Budget Name";
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
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.databaseDataSet;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
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
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewComboBoxColumn
            // 
            this.categoryDataGridViewComboBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewComboBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewComboBoxColumn.Name = "categoryDataGridViewComboBoxColumn";
            this.categoryDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryDataGridViewComboBoxColumn.Width = 200;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // transactionDataGridViewSpacer
            // 
            this.transactionDataGridViewSpacer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionDataGridViewSpacer.HeaderText = "";
            this.transactionDataGridViewSpacer.Name = "transactionDataGridViewSpacer";
            this.transactionDataGridViewSpacer.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button debugDbEditorButton;
        private System.Windows.Forms.Button mockUpBtn;
        private System.Windows.Forms.TabControl budgetTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button transSave;
        private System.Windows.Forms.Button transDelete;
        private System.Windows.Forms.Button transAdd;
        private System.Windows.Forms.ComboBox transType;
        private System.Windows.Forms.ComboBox transCombo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button budgetSave;
        private System.Windows.Forms.Button budgetDelete;
        private System.Windows.Forms.Button budgetAdd;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ComboBox budgetCombo;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private DatabaseDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDataGridViewSpacer;
        private System.Windows.Forms.DataGridView goalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn goalCategoryDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewSpacer;
        private System.Windows.Forms.Button refreshButton;
    }
}

