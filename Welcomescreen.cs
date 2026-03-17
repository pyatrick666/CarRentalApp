using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Welcomescreen : Form
    {
        public Welcomescreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            this.Hide();
            Login_page login = new Login_page(userName);
            login.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message =
        "1. Login:\n" +
        "- Open the application.\n" +
        "- Enter your Full Name.\n" +
        "- Tap 'Let's get started' and fill in your basic details (username and password) in the login screen of the application.\n" +
        "- Verify your username and password using the given credentials.\n\n" +

        "2. Dashboard or Menu Access:\n" +
        "- Navigate to dashboard once logged in.\n\n" +

        "3. Search and View Rented Cars:\n" +
        "- On the dashboard screen, select 'view rentals' to learn about active rentals registered in the application.\n" +
        "- Browse the available cars. You can filter by car type, brand, price, and features.\n" +
        "- Tap on a car to view details such as specifications, rental price, and terms.\n\n" +

        "4. Book Your Car:\n" +
        "- Tap 'new booking'.\n" +
        "- Review the rental details including type of car, rental period, and total cost.\n" +
        "- Confirm your booking by tapping 'register'.\n\n" +

        "5. During Your Rental Process:\n" +
        "- Show your booking confirmation and a valid driver's license.";
            MessageBox.Show(message,"How to Use the Car Rental Application",MessageBoxButtons.OK,MessageBoxIcon.Information);
       
        }

        private void Welcomescreen_Load(object sender, EventArgs e)
        {

        }
    }
}
