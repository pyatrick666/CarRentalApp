using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class ModelBooking
    {
        public int BookingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool HasLicense { get; set; }
        public int RentalDays { get; set; }
        public string CarType { get; set; }
        public string FuelType { get; set; }
        public bool UnlimitedMileage { get; set; }
        public bool BreakdownCover { get; set; }
    }

    public class BookingRepos
    {
        private readonly string connString;

        public BookingRepos()
        {
            var settings = ConfigurationManager.ConnectionStrings["BookingDB"];
            if (settings == null)
                throw new Exception("BookingDB connection string missing");

            connString = settings.ConnectionString;
        }

        public bool InsertBooking(ModelBooking bk)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = @"
INSERT INTO dbo.bookinginfo
(fname, lname, address, age, haslicense, rentaldays,
 cartype, fueltype, unlimitedmil, breakdowncov)
VALUES
(@fname, @lname, @address, @age, @haslicense, @rentaldays,
 @cartype, @fueltype, @unlimitedmil, @breakdowncov)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", bk.FirstName);
                cmd.Parameters.AddWithValue("@lname", bk.LastName);
                cmd.Parameters.AddWithValue("@address", bk.Address);
                cmd.Parameters.AddWithValue("@age", bk.Age);
                cmd.Parameters.AddWithValue("@haslicense", bk.HasLicense);
                cmd.Parameters.AddWithValue("@rentaldays", bk.RentalDays);
                cmd.Parameters.AddWithValue("@cartype", bk.CarType);
                cmd.Parameters.AddWithValue("@fueltype", bk.FuelType);
                cmd.Parameters.AddWithValue("@unlimitedmil", bk.UnlimitedMileage);
                cmd.Parameters.AddWithValue("@breakdowncov", bk.BreakdownCover);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
      

        public List<ModelBooking> GetDetails()
        {
            List<ModelBooking> bookings = new List<ModelBooking>();

            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "SELECT * FROM dbo.bookinginfo ORDER BY BookingID DESC";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    bookings.Add(new ModelBooking
                    {
                        BookingID = Convert.ToInt32(rd["BookingID"]),
                        FirstName = rd["fname"].ToString(),
                        LastName = rd["lname"].ToString(),
                        Address = rd["address"].ToString(),
                        Age = Convert.ToInt32(rd["age"]),
                        HasLicense = Convert.ToBoolean(rd["haslicense"]),
                        RentalDays = Convert.ToInt32(rd["rentaldays"]),
                        CarType = rd["cartype"].ToString(),
                        FuelType = rd["fueltype"].ToString(),
                        UnlimitedMileage = Convert.ToBoolean(rd["unlimitedmil"]),
                        BreakdownCover = Convert.ToBoolean(rd["breakdowncov"])
                    });
                }
            }

            return bookings;
        }

        public List<ModelBooking> SearchBooking(string keyword)
        {
            List<ModelBooking> bookings = new List<ModelBooking>();

            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = @"
        SELECT * FROM dbo.bookinginfo
        WHERE 
            CAST(BookingID AS NVARCHAR) LIKE @key
            OR fname LIKE @key
            OR lname LIKE @key
        ORDER BY BookingID DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    bookings.Add(new ModelBooking
                    {
                        BookingID = Convert.ToInt32(rd["BookingID"]),
                        FirstName = rd["fname"].ToString(),
                        LastName = rd["lname"].ToString(),
                        Address = rd["address"].ToString(),
                        Age = Convert.ToInt32(rd["age"]),
                        HasLicense = Convert.ToBoolean(rd["haslicense"]),
                        RentalDays = Convert.ToInt32(rd["rentaldays"]),
                        CarType = rd["cartype"].ToString(),
                        FuelType = rd["fueltype"].ToString(),
                        UnlimitedMileage = Convert.ToBoolean(rd["unlimitedmil"]),
                        BreakdownCover = Convert.ToBoolean(rd["breakdowncov"])
                    });
                }
            }

            return bookings;
        }






    }
}
        

