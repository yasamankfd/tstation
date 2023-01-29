using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tstation
{
    public partial class Remove_trip : Form
    {
        public Remove_trip()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TrainStation; Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Reception where reception_id = ",con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
        }
    }
}