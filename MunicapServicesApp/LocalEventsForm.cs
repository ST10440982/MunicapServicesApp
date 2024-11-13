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
    public partial class LocalEventsForm : Form
    {
        private List<Event> eventsList = new List<Event>();
        public LocalEventsForm()
        {
            InitializeComponent();
            LoadEventsData();
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();
            var filteredEvents = eventsList.FindAll(evt => evt.Name.ToLower().Contains(searchQuery));

            dataGridEvents.DataSource = filteredEvents;
        }

        private void LoadEventsData()
        {
            eventsList.Add(new Event { Name = "Town Festival", Date = DateTime.Now, Category = "Festival"});
            eventsList.Add(new Event { Name = "Road Maintenance Announcement", Date = DateTime.Now.AddDays(3), Category = "Announcement" });

            dataGridEvents.DataSource = eventsList;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
