using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class Customer
    {


        public int ID { get; set; } // 0
        public string CustomerID { get; set; } //1
        public string IdCard { get; set; } //2
        public string CustomerName { get; set; } // 3

        public string CustomerPhone { get; set; } //4

        public string  Email {  get; set; } //5


     public   List<Customer> DataCustomer()
        {


            List<Customer> data = new List<Customer>();

            SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");

            try
            {
                connect.Open();

                string selectQuery = "SELECT * FROM Customers WHERE Delete_at IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer Cst = new Customer();

                        Cst.ID = Convert.ToInt32(reader["id"]);
                        Cst.CustomerID = reader["customer_id"].ToString();
                        Cst.IdCard= reader["id_card"].ToString();
                        Cst.CustomerName = reader["fullname"].ToString();
                        Cst.CustomerPhone = reader["phonenumber"].ToString();
                        Cst.Email = reader["email"] == DBNull.Value ? "" : reader["email"].ToString();

                        data.Add(Cst);
                    }
                 }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error Message connection: " + s.Message,
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data;


        }



    }
}
