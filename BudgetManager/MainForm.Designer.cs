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
            this.accountEditorButton = new System.Windows.Forms.Button();
            this.budgetEditorButton = new System.Windows.Forms.Button();
            this.goalEditorButton = new System.Windows.Forms.Button();
            this.transactionEditorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountEditorButton
            // 
            this.accountEditorButton.Location = new System.Drawing.Point(27, 25);
            this.accountEditorButton.Name = "accountEditorButton";
            this.accountEditorButton.Size = new System.Drawing.Size(124, 23);
            this.accountEditorButton.TabIndex = 0;
            this.accountEditorButton.Text = "Account Editor";
            this.accountEditorButton.UseVisualStyleBackColor = true;
            this.accountEditorButton.Click += new System.EventHandler(this.accountEditorButton_Click);
            // 
            // budgetEditorButton
            // 
            this.budgetEditorButton.Location = new System.Drawing.Point(27, 54);
            this.budgetEditorButton.Name = "budgetEditorButton";
            this.budgetEditorButton.Size = new System.Drawing.Size(124, 23);
            this.budgetEditorButton.TabIndex = 1;
            this.budgetEditorButton.Text = "Budget Editor";
            this.budgetEditorButton.UseVisualStyleBackColor = true;
            this.budgetEditorButton.Click += new System.EventHandler(this.budgetEditorButton_Click);
            // 
            // goalEditorButton
            // 
            this.goalEditorButton.Location = new System.Drawing.Point(27, 83);
            this.goalEditorButton.Name = "goalEditorButton";
            this.goalEditorButton.Size = new System.Drawing.Size(124, 23);
            this.goalEditorButton.TabIndex = 2;
            this.goalEditorButton.Text = "Goal Editor";
            this.goalEditorButton.UseVisualStyleBackColor = true;
            this.goalEditorButton.Click += new System.EventHandler(this.goalEditorButton_Click);
            // 
            // transactionEditorButton
            // 
            this.transactionEditorButton.Location = new System.Drawing.Point(27, 112);
            this.transactionEditorButton.Name = "transactionEditorButton";
            this.transactionEditorButton.Size = new System.Drawing.Size(124, 23);
            this.transactionEditorButton.TabIndex = 3;
            this.transactionEditorButton.Text = "Transaction Editor";
            this.transactionEditorButton.UseVisualStyleBackColor = true;
            this.transactionEditorButton.Click += new System.EventHandler(this.transactionEditorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.transactionEditorButton);
            this.Controls.Add(this.goalEditorButton);
            this.Controls.Add(this.budgetEditorButton);
            this.Controls.Add(this.accountEditorButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accountEditorButton;
        private System.Windows.Forms.Button budgetEditorButton;
        private System.Windows.Forms.Button goalEditorButton;
        private System.Windows.Forms.Button transactionEditorButton;
    }
}

