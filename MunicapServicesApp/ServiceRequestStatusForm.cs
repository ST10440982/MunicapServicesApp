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
    public partial class ServiceRequestStatusForm : Form
    {
        public ServiceRequestStatusForm()
        {
            InitializeComponent();
        }

        private void dataGridServiceRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell Clicked at row" + e.RowIndex + ", column " + e.ColumnIndex);
        }

        private void btnTrackStatus_Click(object sender, EventArgs e)
        {
            string requestId = txtServiceRequestID.Text;

            if (!string.IsNullOrEmpty(requestId))
            {
                DisplayServiceRequestStatus(requestId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Request ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void DisplayServiceRequestStatus(string requestId)
        {
            var serviceRequest = GetServiceRequestById(requestId);

            if(serviceRequest != null)
            {
                dataGridServiceRequests.Rows.Clear();

                dataGridServiceRequests.Rows.Add(
                    serviceRequest.Id,
                    serviceRequest.Description,
                    serviceRequest.Status,
                    serviceRequest.DateSubmitted.ToShortDateString()
                    );

            }
            else
            {
                MessageBox.Show("Service request not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ServiceRequest GetServiceRequestById(string requestId)
        {
            return new ServiceRequest
            {
                Id = requestId,
                Description = "Sample Description",
                Status = "iN progress",
                DateSubmitted = DateTime.Now
            };
        }

        private ServiceRequestBTS serviceRequestBTS = new ServiceRequestBTS();

        private void LoadServiceRequestsIntoGrid()
        {

            List<ServiceRequest> allRequests = serviceRequestBTS.GetAllRequests();

            dataGridServiceRequests.DataSource = allRequests;
        }
        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {
            serviceRequestBTS.Insert(new ServiceRequest { Id = "1", Description = "Water Supply Issue", Status = "In Progress", DateSubmitted = DateTime.Now });
            serviceRequestBTS.Insert(new ServiceRequest { Id = "2", Description = "Road Repair Needed", Status = "Completed", DateSubmitted = DateTime.Now });
            serviceRequestBTS.Insert(new ServiceRequest { Id = "3", Description = "Electricity Outage", Status = "Pending", DateSubmitted = DateTime.Now });
            LoadServiceRequestsIntoGrid();
           
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
