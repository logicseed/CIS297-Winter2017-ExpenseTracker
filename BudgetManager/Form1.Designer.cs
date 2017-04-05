namespace BudgetManager
{
    partial class Form1
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.budgetCombo = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.budgetAdd = new System.Windows.Forms.Button();
            this.budgetDelete = new System.Windows.Forms.Button();
            this.budgetSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.budgetTab = new System.Windows.Forms.TabControl();
            this.transCombo = new System.Windows.Forms.ComboBox();
            this.transType = new System.Windows.Forms.ComboBox();
            this.transAdd = new System.Windows.Forms.Button();
            this.transDelete = new System.Windows.Forms.Button();
            this.transSave = new System.Windows.Forms.Button();
            this.budgetsTable = new System.Windows.Forms.TableLayoutPanel();
            this.transTable = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.budgetTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.budgetsTable);
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
            // budgetCombo
            // 
            this.budgetCombo.FormattingEnabled = true;
            this.budgetCombo.Location = new System.Drawing.Point(17, 43);
            this.budgetCombo.Name = "budgetCombo";
            this.budgetCombo.Size = new System.Drawing.Size(169, 24);
            this.budgetCombo.TabIndex = 0;
            this.budgetCombo.Text = "Budget Name";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(273, 45);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(221, 22);
            this.startDate.TabIndex = 1;
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
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(273, 95);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(221, 22);
            this.endDate.TabIndex = 4;
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
            // budgetDelete
            // 
            this.budgetDelete.Location = new System.Drawing.Point(541, 58);
            this.budgetDelete.Name = "budgetDelete";
            this.budgetDelete.Size = new System.Drawing.Size(118, 28);
            this.budgetDelete.TabIndex = 7;
            this.budgetDelete.Text = "Delete";
            this.budgetDelete.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.transTable);
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
            // budgetTab
            // 
            this.budgetTab.Controls.Add(this.tabPage2);
            this.budgetTab.Controls.Add(this.tabPage4);
            this.budgetTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTab.Location = new System.Drawing.Point(12, 12);
            this.budgetTab.Name = "budgetTab";
            this.budgetTab.SelectedIndex = 0;
            this.budgetTab.Size = new System.Drawing.Size(704, 537);
            this.budgetTab.TabIndex = 0;
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
            // transType
            // 
            this.transType.FormattingEnabled = true;
            this.transType.Location = new System.Drawing.Point(312, 19);
            this.transType.Name = "transType";
            this.transType.Size = new System.Drawing.Size(147, 24);
            this.transType.TabIndex = 1;
            this.transType.Text = "Type";
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
            // transDelete
            // 
            this.transDelete.Location = new System.Drawing.Point(527, 53);
            this.transDelete.Name = "transDelete";
            this.transDelete.Size = new System.Drawing.Size(118, 28);
            this.transDelete.TabIndex = 8;
            this.transDelete.Text = "Delete";
            this.transDelete.UseVisualStyleBackColor = true;
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
            // budgetsTable
            // 
            this.budgetsTable.BackColor = System.Drawing.Color.Silver;
            this.budgetsTable.ColumnCount = 2;
            this.budgetsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.budgetsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.budgetsTable.Location = new System.Drawing.Point(17, 151);
            this.budgetsTable.Name = "budgetsTable";
            this.budgetsTable.RowCount = 2;
            this.budgetsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.budgetsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.budgetsTable.Size = new System.Drawing.Size(642, 351);
            this.budgetsTable.TabIndex = 9;
            // 
            // transTable
            // 
            this.transTable.BackColor = System.Drawing.Color.Silver;
            this.transTable.ColumnCount = 2;
            this.transTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.transTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.transTable.Location = new System.Drawing.Point(17, 137);
            this.transTable.Name = "transTable";
            this.transTable.RowCount = 2;
            this.transTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.transTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.transTable.Size = new System.Drawing.Size(642, 351);
            this.transTable.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 561);
            this.Controls.Add(this.budgetTab);
            this.Name = "Form1";
            this.Text = "CIS 297 Group 10 Database Project";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.budgetTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button budgetSave;
        private System.Windows.Forms.Button budgetDelete;
        private System.Windows.Forms.Button budgetAdd;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ComboBox budgetCombo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button transSave;
        private System.Windows.Forms.Button transDelete;
        private System.Windows.Forms.Button transAdd;
        private System.Windows.Forms.ComboBox transType;
        private System.Windows.Forms.ComboBox transCombo;
        private System.Windows.Forms.TabControl budgetTab;
        private System.Windows.Forms.TableLayoutPanel budgetsTable;
        private System.Windows.Forms.TableLayoutPanel transTable;
    }
}

