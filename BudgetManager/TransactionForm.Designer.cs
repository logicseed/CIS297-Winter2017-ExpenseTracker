namespace BudgetManager
{
    partial class TransactionForm
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label dateLabel;
            this.discardButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.databaseDataSet = new BudgetManager.DatabaseDataSet();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableAdapter = new BudgetManager.DatabaseDataSetTableAdapters.TransactionTableAdapter();
            this.tableAdapterManager = new BudgetManager.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            categoryLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // discardButton
            // 
            this.discardButton.Location = new System.Drawing.Point(181, 139);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(75, 23);
            this.discardButton.TabIndex = 13;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(100, 139);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(14, 16);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Category", true));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(100, 13);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(139, 21);
            this.categoryComboBox.TabIndex = 20;
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(14, 43);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 21;
            memoLabel.Text = "Memo:";
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Memo", true));
            this.memoTextBox.Location = new System.Drawing.Point(100, 40);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(139, 20);
            this.memoTextBox.TabIndex = 22;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(14, 66);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 23;
            amountLabel.Text = "Amount:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "Amount", true));
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(100, 66);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.amountNumericUpDown.TabIndex = 24;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(14, 96);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 25;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(100, 92);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.dateDateTimePicker.TabIndex = 26;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 174);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.discardButton);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionForm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.Button saveButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DatabaseDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
    }
}