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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
           
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.Show();
            
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            
            LocalEventsForm eventsForm = new LocalEventsForm();
            eventsForm.Show();
           
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {

            ServiceRequestStatusForm statusForm = new ServiceRequestStatusForm();
            statusForm.Show();
        }
    }
}
