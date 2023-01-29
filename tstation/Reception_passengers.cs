using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Reception_passengers : Form
    {
        private DataTable dtt = new DataTable();
        private DataTable dtt2 = new DataTable();
        private ReceptionAccount ra;
        public Reception_passengers(ReceptionAccount r)
        {
            InitializeComponent();
            ra = r;
        }
        
        private void search_Click(object sender, EventArgs e)
        {
            lname2.Text = "";
            name.Text = "";
            nid2.Text = "";
            phone2.Text = "";
            gen.Text = "";
            bdate.Text = "";
            plist.Items.Clear();
            listoftickets.Items.Clear();
            String query = "select * from Passenger where ";
            String c1="", c2="", c3="";
            int i = 0;
            if (nidcheck.Checked)
            {
                i++;
                c1 = " passenger_nid = " + nid.Text;

            }

            if (phonecheck.Checked)
            {
                if (i > 0)
                {

                    c2 = " and passenger_phone = " + phone.Text ;
                    
                }else c2 = " passenger_phone = " + phone.Text ;

                i++;
            }
            
            if (lnamecheck.Checked)
            {
                if (i > 0)
                {

                    c3 = " and passenger_last_name = '" + lname.Text + "'";
                    
                }else c3 = " passenger_last_name = '" + lname.Text + "'";

                i++;
            }

            query = query + c1 + c2 + c3;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtt = dt;
            int num = dt.Rows.Count;
            for (int ii = 0; ii < num; ii++)
            {
                plist.Items.Add(dt.Rows[ii][0] +" "+
                                dt.Rows[ii][1] +" "+
                                dt.Rows[ii][2]);
            }

        }

        private void ticket_Click(object sender, EventArgs e)
        {
            int ind = listoftickets.SelectedIndex;
            String tcode = dtt2.Rows[ind][0].ToString();
            Ticket_show ticketShow = new Ticket_show(tcode);
            ticketShow.Show();
        }

        private void pass(object sender, EventArgs e)
        {
            int index = plist.SelectedIndex;
            String passnid = dtt.Rows[index][0].ToString();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Ticket where ticket_code in ( select reservation_ticket_code  from Reservation where reservation_passenger_nid= "+passnid+" ) ",con);
            DataTable dt = new DataTable(); 
            //MessageBox.Show("select * from Ticket where ticket_code in ( select reservation_ticket_code  from Reservation where reservation_passenger_nid= "+passnid+" ) ");
            dtt2 = dt;
            sda.Fill(dt);
            int num = dt.Rows.Count;
            for (int ii = 0; ii < num; ii++)
            {
                listoftickets.Items.Add(dt.Rows[ii][0] +" "+
                                dt.Rows[ii][1] +" "+
                                dt.Rows[ii][2] );
            }

            lname2.Text = dtt.Rows[index][2].ToString();
            name.Text = dtt.Rows[index][1].ToString();
            nid2.Text = dtt.Rows[index][0].ToString();
            phone2.Text = dtt.Rows[index][5].ToString();
            gen.Text = dtt.Rows[index][4].ToString();
            bdate.Text = dtt.Rows[index][3].ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ra.Show();
            this.Close();
        }
    }
}