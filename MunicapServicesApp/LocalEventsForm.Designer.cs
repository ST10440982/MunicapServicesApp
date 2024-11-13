namespace MunicapServicesApp
{
    partial class LocalEventsForm
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
            this.dataGridEvents = new System.Windows.Forms.DataGridView();
            this.btnSearchEvent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEvents
            // 
            this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvents.Location = new System.Drawing.Point(404, 82);
            this.dataGridEvents.Name = "dataGridEvents";
            this.dataGridEvents.Size = new System.Drawing.Size(240, 150);
            this.dataGridEvents.TabIndex = 0;
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.Location = new System.Drawing.Point(167, 209);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(100, 23);
            this.btnSearchEvent.TabIndex = 1;
            this.btnSearchEvent.Text = "Search Event";
            this.btnSearchEvent.UseVisualStyleBackColor = true;
            this.btnSearchEvent.Click += new System.EventHandler(this.btnSearchEvent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(167, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(304, 328);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(117, 23);
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchEvent);
            this.Controls.Add(this.dataGridEvents);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEvents;
        private System.Windows.Forms.Button btnSearchEvent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}