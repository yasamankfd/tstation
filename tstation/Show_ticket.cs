using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Show_ticket : Form
    {
        private String seatid, trainid;
        private String tid;
        DataTable dt;
        public Show_ticket(String tripid)
        {
            InitializeComponent();
            tid = tripid;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda2 = new SqlDataAdapter("select train_id , train_model from Train where train_id in (select occurrance_train_id from Occurrance where occurrance_trip_code = "+tripid+")",con);
            DataTable dt2 = new DataTable();
            DataTable dt = new DataTable();
            sda2.Fill(dt2);
            int num = dt2.Rows.Count;
            for (int i = 0; i < num; i++)
            {
                list_of_trains.Items.Add(dt2.Rows[i][0] +" "+ dt2.Rows[i][1] +" ");
            }
            
        }

        private void item_train_Click(object sender, EventArgs e)
        {
            if (list_of_trains.SelectedItem != null)
            {
                list_of_seats.Items.Clear();
                String train,train_raw = list_of_trains.SelectedItem.ToString();
                String[] ss = train_raw.Split(' ');
                train = ss[0];
                trainid = ss[0];
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
                SqlDataAdapter sda3 = new SqlDataAdapter("select * from Trip_Seat ts where ts.seat_id in(select cs.seat_id from Cabin_Seat cs where cs.cabin_id in(select wc.cabin_id from Wagon_Cabin wc where wc.wagon_id in(select tw.wagon_id from Train_Wagon tw where tw.train_id = "+train+")))and ts.trip_code= "+tid,con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                int num = dt3.Rows.Count;
                dt = dt3;
                for (int i = 0; i < num; i++)
                {
                    String status = "taken";
                    if (dt3.Rows[i][0].ToString().Contains("0"))
                    {
                        status = "free";
                    }
                    list_of_seats.Items.Add("    وضعیت  "+ dt3.Rows[i][2] +" "+ "  کد صندلی  "+ dt3.Rows[i][1] +" کدسفر  "+status);
                }
            }
            
        }
        

        private void reserve_Clicking(object sender, EventArgs e)
        {
            if (list_of_seats.SelectedItem != null)
            {
                int index = list_of_seats.SelectedIndex;
                seatid = dt.Rows[index][2].ToString();
                Ticket ticket = new Ticket(seatid, trainid, tid);
                ticket.Show();
            }
            
        }
    }
}