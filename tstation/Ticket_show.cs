using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Ticket_show : Form
    {
        private String ticketcod;
        public Ticket_show(String tcode)
        {
            InitializeComponent();
            ticketcod = tcode;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda1 = new SqlDataAdapter("select t.ticket_code,p.*,tri.*,pp.price,s.seat_number,cs.cabin_id,wc.wagon_id,tw.train_id,tr.train_model from Ticket t join Reservation r on t.ticket_code = r.reservation_ticket_code join Passenger p on p.passenger_nid = r.reservation_passenger_nid join Trip tri on tri.trip_code = r.reservation_trip_code join Price pp on pp.trip_id = tri.trip_code join Cabin_Seat cs on cs.seat_id = t.ticket_seat_id join Wagon_Cabin wc on wc.cabin_id = cs.cabin_id join Train_Wagon tw on tw.wagon_id = wc.wagon_id join Train tr on tr.train_id = tw.train_id join Seat s on s.seat_id = t.ticket_seat_id and t.ticket_code ="+ticketcod , con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ticketcode.Text = dt1.Rows[0][0].ToString();
            nid.Text = dt1.Rows[0][1].ToString();
            name.Text = dt1.Rows[0][2].ToString();
            lname.Text = dt1.Rows[0][3].ToString();
            bdate.Text = dt1.Rows[0][4].ToString();
            String gender;
            if (dt1.Rows[0][5].ToString().Contains("1"))
            {
                gender = "زن";
            }else gender = "مرد";

            gen.Text = gender;
            phone.Text = dt1.Rows[0][6].ToString();
            trip_code.Text = dt1.Rows[0][7].ToString();
            start.Text = dt1.Rows[0][8].ToString();
            dest.Text = dt1.Rows[0][9].ToString();
            time.Text = dt1.Rows[0][10].ToString();
            date.Text = dt1.Rows[0][11].ToString();
            price.Text = dt1.Rows[0][12].ToString();
            seat.Text = dt1.Rows[0][13].ToString();
            cabin.Text = dt1.Rows[0][14].ToString();
            wagon.Text = dt1.Rows[0][15].ToString();
            train.Text = dt1.Rows[0][16].ToString();
            train_model.Text = dt1.Rows[0][17].ToString();

        }

        private void nid_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}