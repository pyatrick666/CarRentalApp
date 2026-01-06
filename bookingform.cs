using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class bookingform : Form
    {
        private readonly string _userName;

        public bookingform()
        {
            InitializeComponent();
        }

        public bookingform(string userName) : this()
        {
            _userName = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                MessageBox.Show("Please fill in the First name field.");
                return;
            }
            if (string.IsNullOrWhiteSpace(lname.Text))
            {
                MessageBox.Show("Please fill in the Surname field.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Address.Text))
            {
                MessageBox.Show("Please fill in the Address field.");
                return;
            }
            if (!verifylicense.Checked)
            {
                MessageBox.Show("Please confirm you have a valid driving license.");
                return;
            }
            if (cartype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Car Type.");
                return;
            }
            if (fueltype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Fuel Type.");
                return;
            }

            int days = (int)duration.Value;
            int totalCost = 25 * days;

            if (cartype.SelectedIndex == 1) totalCost += 50;
            else if (cartype.SelectedIndex == 2) totalCost += 75;
            else if (cartype.SelectedIndex == 3) totalCost += 65;

            if (fueltype.SelectedIndex == 2) totalCost += 30;
            else if (fueltype.SelectedIndex == 3) totalCost += 50;

            if (optional.Checked) totalCost += 10 * days;
            if (breakdown.Checked) totalCost += 2 * days;

            MessageBox.Show(
                $"Customer Details:\n" +
                $"Name: {fname.Text} {lname.Text}\n" +
                $"Address: {Address.Text}\n" +
                $"Age: {ageinput.Value}\n" +
                $"Car Type: {cartype.Text}\n" +
                $"Fuel Type: {fueltype.Text}\n" +
                $"Total Cost: {totalCost:C}",
                "Booking Summary"
            );

            SaveBooking();
        }

        private void SaveBooking()
        {
            try
            {
                ModelBooking modelBooking = new ModelBooking
                {
                    FirstName = fname.Text,
                    LastName = lname.Text,
                    Address = Address.Text,
                    Age = (int)ageinput.Value,
                    HasLicense = verifylicense.Checked,
                    RentalDays = (int)duration.Value,
                    CarType = cartype.Text,
                    FuelType = fueltype.Text,
                    UnlimitedMileage = optional.Checked,
                    BreakdownCover = breakdown.Checked
                };

                BookingRepos repo = new BookingRepos();

                if (repo.InsertBooking(modelBooking))
                    MessageBox.Show("Your Booking Is Done Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:\n" + ex.Message);
            }
        }

        private void backbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashboard(_userName).Show();
        }

        private void bookingform_Load(object sender, EventArgs e)
        {

        }
    }
}
