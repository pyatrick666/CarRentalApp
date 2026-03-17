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
    public partial class Login_page : Form
    {
        private string _userName;

        public Login_page(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void PASSWORD_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string userName = Username.Text;
            string password = Password.Text;

            
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Username cannot be empty.", "Failed Attempt");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.", "Failed Attempt");
            }

            else if (userName == "sta001" && password == "givemethekeys123")
            {
                MessageBox.Show("Successfully logged in","Login Success",MessageBoxButtons.OK,MessageBoxIcon.Information
                );
                //_userName = userName;

                dashboard db = new dashboard(_userName);
                db.Show();
                this.Hide();

            }
            else if (userName != "sta001" || password != "givemethekeys123")
            {
                MessageBox.Show("Credentials are invalid, try again!!!","Failed Attempt",MessageBoxButtons.OK,MessageBoxIcon.Warning
                );
            }
                           }
        

           
        



        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) =>
            
            Password.UseSystemPasswordChar = !checkBox1.Checked;

        private void backbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcomescreen().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}

