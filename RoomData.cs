using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    internal class RoomData
    {
        public int ID { get; set; } //0
        public string RoomId { get; set; } //1
        public string RoomType { get; set; } //2
        public decimal Price { get; set; } //3
        public string Status { get; set; } //4


        public List<RoomData> DataRooms()
        {
            List<RoomData> list = new List<RoomData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True"))
            {
                string query = "SELECT id, room_id, roomtype, price, status FROM Room WHERE delete_at IS NULL";
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                   
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoomData
                    {
                        ID = (int)reader["id"],
                        RoomId = reader["room_id"].ToString(),
                        RoomType = reader["roomtype"].ToString(),
                        Price = Convert.ToDecimal(reader["price"]),
                        Status = reader["status"].ToString()
                    });
                }
            }

            return list;
        }


    }
}
