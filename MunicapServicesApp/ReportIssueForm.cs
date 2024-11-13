using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicapServicesApp
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void btnSubmitIssue_Click(object sender, EventArgs e)
        {
            string issueDescription = txtIssueDescription.Text;
            string category = cmbIssueCategory.SelectedItem.ToString();

            MessageBox.Show($"Issue reported: {category} - {issueDescription}");

            txtIssueDescription.Clear();
            cmbIssueCategory.SelectedIndex = -1;
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            cmbIssueCategory.Items.Add("Water Supply");
            cmbIssueCategory.Items.Add("Road Repair");
            cmbIssueCategory.Items.Add("Electricity Issue");

        }

        private void btnReturnToTheMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
