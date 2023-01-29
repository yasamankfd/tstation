using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//DESKTOP-EOKK6AC/MSSQLSERVER
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("exec SP_Login @id="+textBox1.Text+",@pass="+textBox2.Text,con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                String role = dt.Rows[0][0].ToString();
                if (role.Contains("driver"))
                {
                    this.Hide();
                    DriverAccount da = new DriverAccount(textBox1.Text);
                    da.Show();
                }
                else if (role.Contains("crew"))
                {
                    this.Hide();
                    CrewAccount da = new CrewAccount(textBox1.Text);
                    da.Show();
                }
                else if (role.Contains("reception"))
                {
                    this.Hide();
                    ReceptionAccount da = new ReceptionAccount(textBox1.Text);
                    da.Show();
                }
                else if (role.Contains("admin"))
                {
                    this.Hide();
                    Admin_account ad = new Admin_account();
                    ad.Show();
                }


            }
            else MessageBox.Show("رمز یا نام کابری اشتبه است");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}