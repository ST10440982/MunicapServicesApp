namespace MunicapServicesApp
{
    partial class ServiceRequestStatusForm
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
            this.dataGridServiceRequests = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSubmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtServiceRequestID = new System.Windows.Forms.TextBox();
            this.btnTrackStatus = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridServiceRequests
            // 
            this.dataGridServiceRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServiceRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Status,
            this.DateSubmitted});
            this.dataGridServiceRequests.Location = new System.Drawing.Point(299, 50);
            this.dataGridServiceRequests.Name = "dataGridServiceRequests";
            this.dataGridServiceRequests.Size = new System.Drawing.Size(421, 188);
            this.dataGridServiceRequests.TabIndex = 0;
            this.dataGridServiceRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServiceRequests_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Request ID";
            this.Id.Name = "Id";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DateSubmitted
            // 
            this.DateSubmitted.HeaderText = "Date Submitted";
            this.DateSubmitted.Name = "DateSubmitted";
            // 
            // txtServiceRequestID
            // 
            this.txtServiceRequestID.Location = new System.Drawing.Point(92, 50);
            this.txtServiceRequestID.Name = "txtServiceRequestID";
            this.txtServiceRequestID.Size = new System.Drawing.Size(100, 20);
            this.txtServiceRequestID.TabIndex = 1;
            // 
            // btnTrackStatus
            // 
            this.btnTrackStatus.Location = new System.Drawing.Point(92, 165);
            this.btnTrackStatus.Name = "btnTrackStatus";
            this.btnTrackStatus.Size = new System.Drawing.Size(131, 23);
            this.btnTrackStatus.TabIndex = 2;
            this.btnTrackStatus.Text = "Truck Status";
            this.btnTrackStatus.UseVisualStyleBackColor = true;
            this.btnTrackStatus.Click += new System.EventHandler(this.btnTrackStatus_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(299, 370);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(179, 23);
            this.btnReturnToMenu.TabIndex = 3;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnTrackStatus);
            this.Controls.Add(this.txtServiceRequestID);
            this.Controls.Add(this.dataGridServiceRequests);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.Load += new System.EventHandler(this.ServiceRequestStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiceRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridServiceRequests;
        private System.Windows.Forms.TextBox txtServiceRequestID;
        private System.Windows.Forms.Button btnTrackStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSubmitted;
        private System.Windows.Forms.Button btnReturnToMenu;
    }
}