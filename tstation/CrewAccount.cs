using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class CrewAccount : Form
    {
        private String ID;

        public CrewAccount(String id)
        {
            InitializeComponent();
            ID = id;
        }
        

        private void Profile_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Crew where crew_id = "+ID,con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            this.Hide();
            Cprofile da = new Cprofile(dt,this);
            da.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}