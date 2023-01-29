using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Add_trip : Form
    {
        private DataTable dt_driver = new DataTable();
        private DataTable dt_c1 = new DataTable();
        private DataTable dt_c2 = new DataTable();
        private DataTable dt_c3 = new DataTable();
        private DataTable dt_tr = new DataTable();
        private int i_d;
        private int i_c1;
        private int i_c2;
        private int i_c3;
        private int i_tr;
        public Add_trip()
        {
            InitializeComponent();
            y.Items.Add("1401");
            y.Items.Add("1400");
            y.Items.Add("1399");
            y.Items.Add("1398");
            y.Items.Add("1397");
            y.Items.Add("1396");
            y.Items.Add("1395");
            y.Items.Add("1394");
            y.Items.Add("1393");
            y.Items.Add("1392");
            y.Items.Add("1391");
            y.Items.Add("1390");
            y.Items.Add("1388");
            y.Items.Add("1387");
            y.Items.Add("1386");
            y.Items.Add("1385");
            y.Items.Add("1384");
            y.Items.Add("1383");
            y.Items.Add("1382");
            y.Items.Add("1381");
            y.Items.Add("1380");
            y.Items.Add("1379");
            y.Items.Add("1378");
            y.Items.Add("1377");
            y.Items.Add("1376");
            y.Items.Add("1375");
            y.Items.Add("1374");
            y.Items.Add("1373");
            y.Items.Add("1372");
            y.Items.Add("1371");
            y.Items.Add("1370");
            y.Items.Add("1369");
            y.Items.Add("1368");
            y.Items.Add("1367");
            y.Items.Add("1366");
            y.Items.Add("1365");
            y.Items.Add("1364");
            y.Items.Add("1363");
            y.Items.Add("1362");
            y.Items.Add("1361");
            y.Items.Add("1360");
            y.Items.Add("1359");
            y.Items.Add("1358");
            y.Items.Add("1357");
            y.Items.Add("1356");
            y.Items.Add("1355");
            y.Items.Add("1354");
            y.Items.Add("1353");
            y.Items.Add("1352");
            y.Items.Add("1351");
            y.Items.Add("1350");
            y.Items.Add("1349");
            y.Items.Add("1348");
            y.Items.Add("1347");
            y.Items.Add("1346");
            y.Items.Add("1345");
            y.Items.Add("1344");
            y.Items.Add("1343");
            y.Items.Add("1342");
            y.Items.Add("1341");
            y.Items.Add("1340");
            y.Items.Add("1339");
            y.Items.Add("1338");
            y.Items.Add("1337");
            y.Items.Add("1336");
            y.Items.Add("1335");
            y.Items.Add("1334");
            y.Items.Add("1333");
            y.Items.Add("1332");
            y.Items.Add("1331");
            y.Items.Add("1330");
            y.Items.Add("1329");
            y.Items.Add("1328");
            y.Items.Add("1327");
            y.Items.Add("1326");
            y.Items.Add("1325");
            y.Items.Add("1324");
            y.Items.Add("1323");
            y.Items.Add("1322");
            y.Items.Add("1321");
            y.Items.Add("1320");
            y.Items.Add("1319");
            y.Items.Add("1318");
            y.Items.Add("1317");
            y.Items.Add("1316");
            y.Items.Add("1315");
            y.Items.Add("1314");
            y.Items.Add("1313");
            y.Items.Add("1312");
            y.Items.Add("1311");
            y.Items.Add("1310");
            y.Items.Add("1309");
            y.Items.Add("1308");
            y.Items.Add("1307");
            y.Items.Add("1306");
            y.Items.Add("1305");
            y.Items.Add("1304");
            y.Items.Add("1303");
            y.Items.Add("1302");
            y.Items.Add("1301");
            mo.Items.Add("01");
            mo.Items.Add("02");
            mo.Items.Add("03");
            mo.Items.Add("04");
            mo.Items.Add("05");
            mo.Items.Add("06");
            mo.Items.Add("07");
            mo.Items.Add("08");
            mo.Items.Add("09");
            mo.Items.Add("10");
            mo.Items.Add("11");
            mo.Items.Add("12");
            day.Items.Add("01");
            day.Items.Add("02");
            day.Items.Add("03");
            day.Items.Add("04");
            day.Items.Add("05");
            day.Items.Add("06");
            day.Items.Add("07");
            day.Items.Add("08");
            day.Items.Add("09");
            day.Items.Add("10");
            day.Items.Add("11");
            day.Items.Add("12");
            day.Items.Add("13");
            day.Items.Add("14");
            day.Items.Add("15");
            day.Items.Add("16");
            day.Items.Add("17");
            day.Items.Add("18");
            day.Items.Add("19");
            day.Items.Add("20");
            day.Items.Add("21");
            day.Items.Add("22");
            day.Items.Add("23");
            day.Items.Add("24");
            day.Items.Add("25");
            day.Items.Add("26");
            day.Items.Add("27");
            day.Items.Add("28");
            day.Items.Add("29");
            day.Items.Add("30");
            day.Items.Add("31");
            h.Items.Add("00");
            h.Items.Add("01");
            h.Items.Add("02");
            h.Items.Add("03");
            h.Items.Add("04");
            h.Items.Add("05");
            h.Items.Add("06");
            h.Items.Add("07");
            h.Items.Add("08");
            h.Items.Add("09");
            h.Items.Add("10");
            h.Items.Add("11");
            h.Items.Add("12");
            h.Items.Add("13");
            h.Items.Add("14");
            h.Items.Add("15");
            h.Items.Add("16");
            h.Items.Add("17");
            h.Items.Add("18");
            h.Items.Add("19");
            h.Items.Add("20");
            h.Items.Add("21");
            h.Items.Add("22");
            h.Items.Add("23");
            m.Items.Add("00");
            m.Items.Add("01");
            m.Items.Add("02");
            m.Items.Add("03");
            m.Items.Add("04");
            m.Items.Add("05");
            m.Items.Add("06");
            m.Items.Add("07");
            m.Items.Add("08");
            m.Items.Add("09");
            m.Items.Add("10");
            m.Items.Add("11");
            m.Items.Add("12");
            m.Items.Add("13");
            m.Items.Add("14");
            m.Items.Add("15");
            m.Items.Add("16");
            m.Items.Add("17");
            m.Items.Add("18");
            m.Items.Add("19");
            m.Items.Add("20");
            m.Items.Add("21");
            m.Items.Add("22");
            m.Items.Add("23");
            m.Items.Add("24");
            m.Items.Add("25");
            m.Items.Add("26");
            m.Items.Add("27");
            m.Items.Add("28");
            m.Items.Add("29");
            m.Items.Add("30");
            m.Items.Add("31");
            m.Items.Add("32");
            m.Items.Add("33");
            m.Items.Add("34");
            m.Items.Add("35");
            m.Items.Add("36");
            m.Items.Add("37");
            m.Items.Add("38");
            m.Items.Add("39");
            m.Items.Add("40");
            m.Items.Add("41");
            m.Items.Add("42");
            m.Items.Add("43");
            m.Items.Add("44");
            m.Items.Add("45");
            m.Items.Add("46");
            m.Items.Add("47");
            m.Items.Add("48");
            m.Items.Add("49");
            m.Items.Add("50");
            m.Items.Add("51");
            m.Items.Add("52");
            m.Items.Add("53");
            m.Items.Add("54");
            m.Items.Add("55");
            m.Items.Add("56");
            m.Items.Add("57");
            m.Items.Add("58");
            m.Items.Add("59");
            start.Items.Add("tehran");
            start.Items.Add("shiraz");
            start.Items.Add("mashhad");
            start.Items.Add("hamedan");
            start.Items.Add("ahvaz");
            start.Items.Add("tabriz");
            start.Items.Add("kerman");
            start.Items.Add("qom");
            start.Items.Add("sari");
            start.Items.Add("yazd");
            start.Items.Add("arak");
            dest.Items.Add("tehran");
            dest.Items.Add("shiraz");
            dest.Items.Add("mashhad");
            dest.Items.Add("hamedan");
            dest.Items.Add("ahvaz");
            dest.Items.Add("tabriz");
            dest.Items.Add("kerman");
            dest.Items.Add("qom");
            dest.Items.Add("sari");
            dest.Items.Add("yazd");
            dest.Items.Add("arak");
        }



        private void d_click(object sender, EventArgs e)
        {
            d.Items.Clear();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Driver d where d.driver_id not in(select td.driver_id from Train_Driver td where td.train_driver_date = '"+date+"')",con);
            DataTable dt = new DataTable();
            //MessageBox.Show("select * from Driver d where d.driver_id not in(select td.driver_id from Train_Driver td where td.train_driver_date = '"+date+"')");
            sda3.Fill(dt);
            dt_driver = dt;
            int i = dt.Rows.Count;
            for(int ii=0;ii<i;ii++)
            {
                d.Items.Add(dt.Rows[ii][0] + "  " + dt.Rows[ii][1] + "  " +
                            dt.Rows[ii][2]);
            }

        }

        private void c1_click(object sender, EventArgs e)
        {
            c1.Items.Clear();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '"+date+"'))",con);
            DataTable dt = new DataTable();
            //MessageBox.Show("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '" +date + "'))");
            sda3.Fill(dt);
            dt_c1 = dt;
            int i = dt.Rows.Count;
            for(int ii=0;ii<i;ii++)
            {
                c1.Items.Add(dt.Rows[ii][0] + "  " + dt.Rows[ii][1] + "  " +
                            dt.Rows[ii][2]);
            }
            
        }

        private void c2_click(object sender, EventArgs e)
        {
            c2.Items.Clear();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '"+date+"'))",con);
            DataTable dt = new DataTable();
            //MessageBox.Show("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '" + date + "'))");
            sda3.Fill(dt);
            dt_c2 = dt;
            int i = dt.Rows.Count;
            for(int ii=0;ii<i;ii++)
            {
                c2.Items.Add(dt.Rows[ii][0] + "  " + dt.Rows[ii][1] + "  " +
                             dt.Rows[ii][2]);
            }
        }

        private void c3_click(object sender, EventArgs e)
        {
            c1.Items.Clear();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '"+date+"'))",con);
            DataTable dt = new DataTable();
            //MessageBox.Show("select * from Crew c where c.crew_id not in(select o.occurrance_crew_id from Occurrance o where o.occurrance_trip_code not in ( select t.trip_code from Trip t where t.trip_date != '" +date + "'))");
            sda3.Fill(dt);
            dt_c3 = dt;
            int i = dt.Rows.Count;
            for(int ii=0;ii<i;ii++)
            {
                c3.Items.Add(dt.Rows[ii][0] + "  " + dt.Rows[ii][1] + "  " +
                             dt.Rows[ii][2]);
            }
        }

        private void sub_click(object sender, EventArgs e)
        {
            i_c1 = c1.SelectedIndex;
            i_c2 = c2.SelectedIndex;
            i_c3 = c3.SelectedIndex;
            i_d = d.SelectedIndex;
            i_tr = train.SelectedIndex;
            String c1_id = dt_c1.Rows[i_c1][0].ToString();
            String c2_id = dt_c2.Rows[i_c2][0].ToString();
            String c3_id = dt_c3.Rows[i_c3][0].ToString();
            String d_id = dt_driver.Rows[i_d][0].ToString();
            String tr_id = dt_tr.Rows[i_tr][0].ToString();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            String tim = h.SelectedItem + ":" + m.SelectedItem + ":00";
            if(!start.SelectedIndex.Equals(dest.SelectedIndex)){
            if ((!c1_id.Equals(c2_id) && !c1_id.Equals(c3_id) && !c2_id.Equals(c3_id)))
            {
                if (tcode.Text.Length > 0 &&
                    day.SelectedItem != null && y.SelectedItem != null && mo.SelectedItem != null && d_id.Length > 0 &&
                    m.SelectedItem != null && h.SelectedItem != null && d.SelectedItem != null &&
                    c1.SelectedItem != null &&
                    c2.SelectedItem != null && c3.SelectedItem != null && start.SelectedItem != null &&
                    dest.SelectedItem != null)
                {
                    SqlConnection con =
                        new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
                    SqlDataAdapter sda11 = new SqlDataAdapter(
                        "insert into Trip (trip_code,trip_date,trip_time,trip_start,trip_destination)values(" +
                        tcode.Text + ",'" + date + "','" + tim + "','" + start.SelectedItem + "','" +
                        dest.SelectedItem + "')", con);
                    //MessageBox.Show("insert into Trip (trip_code,trip_date,trip_time,trip_start,trip_destination)values(" + tcode.Text + ",'" + date + "','" + tim + "','" + start.SelectedItem + "','" + dest.SelectedItem + "')");
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);


                    SqlDataAdapter sda12 = new SqlDataAdapter(
                        "insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" +
                        c1_id + "," + tr_id + "," + tcode.Text + ")", con);
                    //MessageBox.Show("insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" + c1_id + "," + tr_id + "," + tcode.Text + ")");
                    DataTable dt12 = new DataTable();
                    sda12.Fill(dt12);
                    SqlDataAdapter sda13 = new SqlDataAdapter(
                        "insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" + c2_id + "," + tr_id + "," + tcode.Text + ")", con);
                    //MessageBox.Show("insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" + c2_id + "," + tr_id + "," + tcode.Text + ")");
                    DataTable dt13 = new DataTable();
                    sda13.Fill(dt13);
                    SqlDataAdapter sda14 = new SqlDataAdapter(
                        "insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" +
                        c3_id + "," + tr_id + "," + tcode.Text + ")", con);
                    //MessageBox.Show("insert into Occurrance(occurrance_crew_id,occurrance_train_id,occurrance_trip_code) values (" + c3_id + "," + tr_id + "," + tcode.Text + ")");
                    DataTable dt14 = new DataTable();
                    sda14.Fill(dt14);

                    SqlDataAdapter sda15 = new SqlDataAdapter(
                        "insert into Train_Driver(driver_id,train_id,train_driver_date,train_driver_end_time,train_driver_start_time) values (" + d_id + "," + tr_id + ",'" + date + "','" + tim + "','" + tim + "')", con);
                    MessageBox.Show("insert into Train_Driver(driver_id,train_id,train_driver_date,train_driver_end_time,train_driver_start_time) values (" +d_id + "," + tr_id + ",'" + date + "','" + tim + "','" + tim + "')");
                    DataTable dt15 = new DataTable();
                    sda15.Fill(dt15);
                    MessageBox.Show("ثبت شد");



                }
                else MessageBox.Show("لطفا همه فیلد هارا پر کنید");

            }
            else MessageBox.Show("خدمه تکراری است");
        }else MessageBox.Show("مبدا و مقصد اشتباه است");


    }

        private void generate_code(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int t_code  = rnd.Next(111120, 999999);
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Trip where trip_code = "+t_code , con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            while (dt1.Rows.Count > 0)
            {
                t_code  = rnd.Next(111120, 999999);
                sda1 = new SqlDataAdapter("select * from Ticket where ticket_code = "+t_code , con);
                sda1.Fill(dt1);
                dt1 = new DataTable();
            }

            tcode.Text = t_code.ToString();
        }

        private void train_click(object sender, EventArgs e)
        {
            train.Items.Clear();
            String date = y.SelectedItem + "-" + mo.SelectedItem + "-" + day.SelectedItem;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Train tr where tr.train_id not in(select td.train_id from Train_Driver td where td.train_driver_date = '"+date+"')",con);
            DataTable dt = new DataTable();
            //MessageBox.Show("select * from Train tr where tr.train_id not in(select td.train_id from Train_Driver td where td.train_driver_date = '"+date+"')");
            sda3.Fill(dt);
            dt_tr = dt;
            int i = dt.Rows.Count;
            for(int ii=0;ii<i;ii++)
            {
                train.Items.Add(dt.Rows[ii][0] + "  " + dt.Rows[ii][1] + "  " +
                            dt.Rows[ii][2]);
            }
        }
    }
}