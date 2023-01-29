using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class ReceptionAccount : Form
    {
        private String ID;
        public ReceptionAccount(String id)
        {
            ID = id;
            InitializeComponent();
        }
        
        private void Reserve_Click(object sender, EventArgs e)
        {
            Reception_ticket_reservation da = new Reception_ticket_reservation();
            da.Show();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Reception where reception_id = "+ID,con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            this.Hide();
            Rprofile da = new Rprofile(dt,this);
            da.Show();
        }

        private void Make_passenger_Click(object sender, EventArgs e)
        {
            Reception_add_passenger receptionAddPassenger = new Reception_add_passenger(this);
            receptionAddPassenger.Show();
        }

        private void See_trips_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Passengers_Click(object sender, EventArgs e)
        {
            Reception_passengers receptionPassengers = new Reception_passengers(this);
            receptionPassengers.Show();
        }
    }
}