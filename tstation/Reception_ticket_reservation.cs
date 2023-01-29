using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Reception_ticket_reservation : Form
    {
        DataTable dt = new DataTable();
        public Reception_ticket_reservation()
        {
            InitializeComponent();
            y.Items.Add("1399");
            y.Items.Add("1400");
            y.Items.Add("1401");
            y.Items.Add("1402");
            y.Items.Add("1403");
            y.Items.Add("1404");
            m.Items.Add("1");
            m.Items.Add("2");
            m.Items.Add("3");
            m.Items.Add("4");
            m.Items.Add("5");
            m.Items.Add("6");
            m.Items.Add("7");
            m.Items.Add("8");
            m.Items.Add("9");
            m.Items.Add("10");
            m.Items.Add("11");
            m.Items.Add("12");
            d.Items.Add("1");
            d.Items.Add("2");
            d.Items.Add("3");
            d.Items.Add("4");
            d.Items.Add("5");
            d.Items.Add("6");
            d.Items.Add("7");
            d.Items.Add("8");
            d.Items.Add("9");
            d.Items.Add("10");
            d.Items.Add("11");
            d.Items.Add("12");
            d.Items.Add("13");
            d.Items.Add("14");
            d.Items.Add("15");
            d.Items.Add("16");
            d.Items.Add("17");
            d.Items.Add("18");
            d.Items.Add("19");
            d.Items.Add("20");
            d.Items.Add("21");
            d.Items.Add("22");
            d.Items.Add("23");
            d.Items.Add("24");
            d.Items.Add("25");
            d.Items.Add("26");
            d.Items.Add("27");
            d.Items.Add("28");
            d.Items.Add("29");
            d.Items.Add("30");
            d.Items.Add("31");
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (trips.SelectedItem != null)
            {
                int index = trips.SelectedIndex;
                if (trips.Items.Count > 0 && trips.SelectedItem != null)
                {
                    String trip_id = dt.Rows[index][0].ToString();
                    Show_ticket showTicket = new Show_ticket(trip_id);
                    showTicket.Show();
                }            
            }

        }

        private void search_Click(object sender, EventArgs e)
        {

            String d = y.SelectedItem+ "-" + m.SelectedItem+ "-" + this.d.SelectedItem;
            MessageBox.Show(d);
                trips.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select * from Trip where trip_start = '"+textBox1.Text+"' and trip_destination = '"+textBox2.Text+"' and trip_date = '"+d+"'",con);
                sda.Fill(dt);
                int num = dt.Rows.Count;
                for (int i = 0; i < num; i++)
                {
                    trips.Items.Add(dt.Rows[i][0] +" "+
                                    dt.Rows[i][1] +" "+
                                    dt.Rows[i][2] +" "+
                                    dt.Rows[i][3] +" "+
                                    dt.Rows[i][4] );
                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}