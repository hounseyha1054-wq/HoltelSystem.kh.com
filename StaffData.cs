using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class StaffData
    {

        public int Id { get; set; }
        public string staffID { get; set; } //1
        public string staffName { get; set; } //2

        public string gender { get; set; }//3
        public string email { get; set; } //4
        public string phone { get; set; } //5
        public string Address { get; set; } //6
        public string role { get; set; } //7
        public string status { get; set; } //8



        public List<StaffData> DataStaff()
        {
            List<StaffData> data = new List<StaffData>();
            string connectionString = @"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True";

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Staff WHERE delete_at IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StaffData ed = new StaffData
                                {
                                    Id = (int)reader["id"],
                                    staffID = reader["staff_ID"]?.ToString(),
                                    staffName = reader["fullname"]?.ToString(),
                                    gender = reader["gender"]?.ToString(),
                                    email = reader["email"]?.ToString(),
                                    phone = reader["phone"]?.ToString(),
                                    Address = reader["address"]?.ToString(),
                                    role = reader["role"]?.ToString(),
                                    status = reader["status"]?.ToString()
                                };

                                data.Add(ed);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }





    }
}


