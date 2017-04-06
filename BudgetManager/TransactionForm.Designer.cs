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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label dateLabel;
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discardButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            categoryLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(14, 16);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(100, 13);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(141, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(14, 43);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 7;
            memoLabel.Text = "Memo:";
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(100, 40);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(141, 20);
            this.memoTextBox.TabIndex = 8;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(14, 66);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "Amount:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(100, 66);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(141, 20);
            this.amountNumericUpDown.TabIndex = 10;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(14, 96);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(100, 92);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.dateDateTimePicker.TabIndex = 12;
            // 
            // discardButton
            // 
            this.discardButton.Location = new System.Drawing.Point(175, 136);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(75, 23);
            this.discardButton.TabIndex = 13;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(94, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 171);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.Button saveButton;
    }
}