using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        private string _userName;

        public dashboard(string userName)
        {
            InitializeComponent();
            _userName = userName;

           
            dashboardlabel.Text = "Welcome, " + _userName + "!";
        }
        public dashboard()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRentals cdf = new ViewRentals();
            cdf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            bookingform cdf = new bookingform();
            cdf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboardlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
