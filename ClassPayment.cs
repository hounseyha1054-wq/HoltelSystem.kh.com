using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class ClassPayment
    {
        public int ID { get; set; } //0
        public string BookingId { get; set; } //1
        public string AmountPaid { get; set; } //2
        public string PaymentDate { get; set; } //3
        public string StatusPay { get; set; } //4


        public List<ClassPayment> DataPayment()
        {
            List<ClassPayment> list = new List<ClassPayment>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True"))
            {
                string query = "SELECT id, booking_id, amount_paid,payment_date, method FROM Payments WHERE Delete_at IS NULL";
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ClassPayment
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("id")),
                        BookingId = reader["booking_id"].ToString(),
                        AmountPaid = reader["amount_paid"].ToString(),
                        PaymentDate = reader["payment_date"].ToString(),
                        StatusPay = reader["method"].ToString()
                    });
                }
            }

            return list;
        }



    }
}
