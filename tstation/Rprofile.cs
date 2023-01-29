using System;
using System.Data;
using System.Windows.Forms;

namespace tstation
{
    public partial class Rprofile : Form
    {
        private ReceptionAccount RA;
        public Rprofile(DataTable dt , ReceptionAccount ra)
        {
            InitializeComponent();
            RA = ra;
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][7].ToString();
            if (dt.Rows[0][4].Equals("0"))
            {
                textBox5.Text = "مجرد";
            }else textBox5.Text = "متاهل";
            //textBox5.Text = dt.Rows[0][3].ToString();
            if (dt.Rows[0][3].Equals("0"))
            {
                textBox6.Text = "مرد";
            }else textBox6.Text = "زن";
            //textBox6.Text = dt.Rows[0][4].ToString();
            textBox7.Text = dt.Rows[0][5].ToString();
            textBox8.Text = dt.Rows[0][8].ToString();
            textBox9.Text = dt.Rows[0][6].ToString();
            

        }

        private void back_Click(object sender, EventArgs e)
        {
            RA.Show();
            this.Close();
        }
    }
}