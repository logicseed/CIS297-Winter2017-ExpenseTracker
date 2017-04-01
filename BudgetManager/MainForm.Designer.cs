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
            this.debugDbEditorButton = new System.Windows.Forms.Button();
            this.mockUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugDbEditorButton
            // 
            this.debugDbEditorButton.AutoSize = true;
            this.debugDbEditorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugDbEditorButton.Image = global::BudgetManager.Properties.Resources.debug_editor;
            this.debugDbEditorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debugDbEditorButton.Location = new System.Drawing.Point(244, 356);
            this.debugDbEditorButton.Margin = new System.Windows.Forms.Padding(6);
            this.debugDbEditorButton.Name = "debugDbEditorButton";
            this.debugDbEditorButton.Padding = new System.Windows.Forms.Padding(10);
            this.debugDbEditorButton.Size = new System.Drawing.Size(224, 55);
            this.debugDbEditorButton.TabIndex = 4;
            this.debugDbEditorButton.Text = "Debug DB Editor";
            this.debugDbEditorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debugDbEditorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.debugDbEditorButton.UseVisualStyleBackColor = true;
            this.debugDbEditorButton.Click += new System.EventHandler(this.debugDbEditorButton_Click);
            // 
            // mockUpBtn
            // 
            this.mockUpBtn.Location = new System.Drawing.Point(244, 292);
            this.mockUpBtn.Name = "mockUpBtn";
            this.mockUpBtn.Size = new System.Drawing.Size(224, 55);
            this.mockUpBtn.TabIndex = 5;
            this.mockUpBtn.Text = "MockUp";
            this.mockUpBtn.UseVisualStyleBackColor = true;
            this.mockUpBtn.Click += new System.EventHandler(this.mockUpBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.mockUpBtn);
            this.Controls.Add(this.debugDbEditorButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button debugDbEditorButton;
        private System.Windows.Forms.Button mockUpBtn;
    }
}

