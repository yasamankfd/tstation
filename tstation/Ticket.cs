using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Ticket : Form
    {
        
        public Ticket(String sid , String trainid , String tripid)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Trip where trip_code = " + tripid, con);
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Price where trip_id = " + tripid, con);
            SqlDataAdapter sda3 = new SqlDataAdapter("select cabin_id from Cabin_Seat where seat_id in (select seat_id from Trip_Seat where trip_code = " + tripid+" )", con);
            DataTable dt3 = new DataTable(); 
            DataTable dt2 = new DataTable();
            sda3.Fill(dt3);
            cabin.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select wagon_id from Wagon_Cabin where cabin_id = " + cabin.Text, con);
            DataTable dt = new DataTable();
            DataTable dt4 = new DataTable();
            sda.Fill(dt);
            sda2.Fill(dt2);
            sda4.Fill(dt4);
            trip_code.Text = tripid;
            train.Text = trainid;
            seat.Text = sid;
            dest.Text = dt.Rows[0][2].ToString();
            start.Text = dt.Rows[0][1].ToString();
            time.Text = dt.Rows[0][3].ToString();
            date.Text = dt.Rows[0][4].ToString();
            price.Text = dt2.Rows[0][1].ToString();
            wagon.Text = dt4.Rows[0][0].ToString();
        }
        private void reserve_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ticket_code  = rnd.Next(111120, 999999);
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Ticket where ticket_code = "+ticket_code , con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            while (dt1.Rows.Count > 0)
            {
                ticket_code  = rnd.Next(111120, 999999);
                sda1 = new SqlDataAdapter("select * from Ticket where ticket_code = "+ticket_code , con);
                sda1.Fill(dt1);
                dt1 = new DataTable();
            }
            

            DataTable dt2, dt3, dt4;
            dt4 = new DataTable();
            dt3 = new DataTable();
            dt2 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter("insert into Ticket(ticket_code,ticket_seat_id,ticket_price) values ("+ticket_code+","+seat.Text+","+price.Text+")" , con);
                SqlDataAdapter sda3 = new SqlDataAdapter("insert into Reservation(reservation_ticket_code,reservation_trip_code,reservation_passenger_nid) values ("+ticket_code+","+trip_code.Text+","+nid.Text+")" , con);
                SqlDataAdapter sda4 = new SqlDataAdapter("update Trip_Seat set trip_seat_status = 1 where trip_code = "+trip_code.Text+"  and seat_id = "+seat.Text , con);
                sda2.Fill(dt2);
                sda3.Fill(dt3);
                sda4.Fill(dt4);
                MessageBox.Show("بلیط ثبت شد");

            
        }
    }
}