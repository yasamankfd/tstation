using System;
using System.Windows.Forms;

namespace tstation
{
    public partial class DriverAccount : Form
    {
        private String ID;
        public DriverAccount(String id)
        {
            ID = id;
            InitializeComponent();
        }
    }
}