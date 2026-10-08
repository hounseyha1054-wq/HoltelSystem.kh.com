using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class BookingClass
    {
        public int ID { get; set; } 
        public string BookigID { get; set; } // 1
        public string CustomerID { get; set; } //2
        public string RoomID { get; set; } //3

        public string checkIn { get; set; } ///4

        public string checkOut { get; set; } //5

        public string Status { get; set; } //6
        public string Total { get; set; }//7
        public string Update_at { get; set; }





 

        public List<BookingClass> DataBooking()
        {
            List<BookingClass> books = new List<BookingClass>();
            SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog= HotelSystem ;Integrated Security=True");


            try
            {
                connect.Open();
                string query = "SELECT id,customer_id,room_id,checkin_date,checkout_date,totalprice ,status,booking_id,Update_ate FROM Bookings WHERE Delete_at IS NULL";

                using (SqlCommand cm = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookingClass bookingClass = new BookingClass
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                BookigID = reader["booking_id"].ToString(),
                                CustomerID = reader["customer_id"].ToString(),
                                RoomID = reader["room_id"].ToString(),
                                checkIn = reader["checkin_date"].ToString(),
                                checkOut = reader["checkout_date"].ToString(),
                                Update_at= reader["Update_ate"].ToString(),

                                Status = reader["status"].ToString(),
                                Total = reader["totalprice"].ToString()
                            };

                            books.Add(bookingClass);
                        }
                    }
                }

            }catch (Exception e)
            {
                MessageBox.Show("Error Message connection: " + e.Message,
                              "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return books;
        }


    }
}
