using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Reception_add_passenger : Form
    {
        private String p, g, n, ln, bd, ni ;
        private ReceptionAccount ra;
        public Reception_add_passenger(ReceptionAccount r)
        {
            InitializeComponent();
            ra = r;
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
        
        private void submit_click(object sender, EventArgs e)
        {
            p = phone.Text;
            n = name.Text;
            ln = lname.Text;
            ni = nid.Text;
            bd = y.SelectedItem + "-" + m.SelectedItem + "-" + d.SelectedItem;
            if (woman.Checked)
            {
                g = "1";
            }
            if (man.Checked)
            {
                g = "0";
            }
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda3 = new SqlDataAdapter("exec SP_2_insert_passenger @pnid = "+ni+", @pname = '"+n+"', @plname = '"+ln+"', @pgen = "+g+", @pbdate = '"+bd+"', @pphone="+p,con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            MessageBox.Show("مسافر ثبت شد");

        }

        private void w_click(object sender, EventArgs e)
        {
            if (woman.Checked)
            {
                man.Checked = false;
            }
        }

        private void m_click(object sender, EventArgs e)
        {
            if (man.Checked)
            {
                woman.Checked = false;
            }
        }


        private void back_Click(object sender, EventArgs e)
        {
            ra.Show();
            this.Close();
        }
    }
}