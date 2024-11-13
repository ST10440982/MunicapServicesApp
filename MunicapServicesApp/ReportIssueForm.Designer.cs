namespace MunicapServicesApp
{
    partial class ReportIssueForm
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
            this.cmbIssueCategory = new System.Windows.Forms.ComboBox();
            this.txtIssueDescription = new System.Windows.Forms.TextBox();
            this.btnSubmitIssue = new System.Windows.Forms.Button();
            this.btnReturnToTheMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIssueCategory
            // 
            this.cmbIssueCategory.FormattingEnabled = true;
            this.cmbIssueCategory.Location = new System.Drawing.Point(342, 96);
            this.cmbIssueCategory.Name = "cmbIssueCategory";
            this.cmbIssueCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbIssueCategory.TabIndex = 0;
            // 
            // txtIssueDescription
            // 
            this.txtIssueDescription.Location = new System.Drawing.Point(153, 96);
            this.txtIssueDescription.Name = "txtIssueDescription";
            this.txtIssueDescription.Size = new System.Drawing.Size(100, 20);
            this.txtIssueDescription.TabIndex = 1;
            // 
            // btnSubmitIssue
            // 
            this.btnSubmitIssue.Location = new System.Drawing.Point(153, 188);
            this.btnSubmitIssue.Name = "btnSubmitIssue";
            this.btnSubmitIssue.Size = new System.Drawing.Size(100, 23);
            this.btnSubmitIssue.TabIndex = 2;
            this.btnSubmitIssue.Text = "Submit Issue";
            this.btnSubmitIssue.UseVisualStyleBackColor = true;
            this.btnSubmitIssue.Click += new System.EventHandler(this.btnSubmitIssue_Click);
            // 
            // btnReturnToTheMenu
            // 
            this.btnReturnToTheMenu.Location = new System.Drawing.Point(314, 355);
            this.btnReturnToTheMenu.Name = "btnReturnToTheMenu";
            this.btnReturnToTheMenu.Size = new System.Drawing.Size(149, 23);
            this.btnReturnToTheMenu.TabIndex = 3;
            this.btnReturnToTheMenu.Text = "Return To The Menu";
            this.btnReturnToTheMenu.UseVisualStyleBackColor = true;
            this.btnReturnToTheMenu.Click += new System.EventHandler(this.btnReturnToTheMenu_Click);
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToTheMenu);
            this.Controls.Add(this.btnSubmitIssue);
            this.Controls.Add(this.txtIssueDescription);
            this.Controls.Add(this.cmbIssueCategory);
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIssueCategory;
        private System.Windows.Forms.TextBox txtIssueDescription;
        private System.Windows.Forms.Button btnSubmitIssue;
        private System.Windows.Forms.Button btnReturnToTheMenu;
    }
}