using System;
using System.Windows.Forms;

namespace tstation
{
    public partial class Admin_account : Form
    {
        public Admin_account()
        {
            InitializeComponent();
        }

        private void crew_add(object sender, EventArgs e)
        {
            Add_crew addCrew = new Add_crew();
            addCrew.Show();
        }

        private void driver_add(object sender, EventArgs e)
        {
            Add_driver addDriver = new Add_driver();
            addDriver.Show();
        }

        private void reception_add(object sender, EventArgs e)
        {
            Add_reception addReception = new Add_reception();
            addReception.Show();
        }

        private void occurence_add(object sender, EventArgs e)
        {
            Add_trip addOccurrence = new Add_trip();
            addOccurrence.Show();
        }
    }
}