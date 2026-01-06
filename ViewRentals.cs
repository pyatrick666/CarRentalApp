using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewRentals : Form
    {
        private DataTable bookingsTable;   // 🔴 MUST be global

        public ViewRentals()
        {
            InitializeComponent();
            this.Load += ViewRentals_Load;
        }

        private void ViewRentals_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = true;

            bookingsTable = new DataTable();

            bookingsTable.Columns.Add("BookingID", typeof(int));
            bookingsTable.Columns.Add("Firstname");
            bookingsTable.Columns.Add("Lastname");
            bookingsTable.Columns.Add("Address");
            bookingsTable.Columns.Add("Age", typeof(int));
            bookingsTable.Columns.Add("HasLicense", typeof(bool));
            bookingsTable.Columns.Add("RentalDays", typeof(int));
            bookingsTable.Columns.Add("CarType");
            bookingsTable.Columns.Add("FuelType");
            bookingsTable.Columns.Add("UnlimitedMileage", typeof(bool));
            bookingsTable.Columns.Add("BreakdownCoverage", typeof(bool));

            BookingRepos repo = new BookingRepos();
            var data = repo.GetDetails();

            foreach (var i in data)
            {
                bookingsTable.Rows.Add(
                    i.BookingID,
                    i.FirstName,
                    i.LastName,
                    i.Address,
                    i.Age,
                    i.HasLicense,
                    i.RentalDays,
                    i.CarType,
                    i.FuelType,
                    i.UnlimitedMileage,
                    i.BreakdownCover
                );
            }

            dataGridView1.DataSource = bookingsTable;

                dataGridView1.Sort(
                dataGridView1.Columns["BookingID"],
                ListSortDirection.Ascending
            );
        }

        // 🔍 SEARCH BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (bookingsTable == null) return;

            if (!string.IsNullOrEmpty(keyword))
            {
                DataView dv = bookingsTable.DefaultView;
                dv.RowFilter =
                    $"Convert(BookingID, 'System.String') LIKE '%{keyword}%'" +
                    $" OR Firstname LIKE '%{keyword}%'" +
                    $" OR Lastname LIKE '%{keyword}%'";

                dataGridView1.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView1.DataSource = bookingsTable;
            }
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new dashboard().Show();
        }
    }
}
