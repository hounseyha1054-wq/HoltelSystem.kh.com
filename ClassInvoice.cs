using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class ClassInvoice
    {

        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");

        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdCard { get; set; }

        public List<ClassInvoice> DataInvoice()
        {
            List<ClassInvoice> dataInvoice = new List<ClassInvoice>();


            try
            {
                connect.Open();
                string Select = "SELECT fullname, email,phonenumber,id_card FROM Customers WHERE Delete_at IS NULL";
                using (SqlCommand cmd = new SqlCommand(Select, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            ClassInvoice Indata = new ClassInvoice()
                            {

                                Fullname = reader["fullname"].ToString(),
                                Email = reader["email"].ToString(),
                                Phone = reader["phonenumber"].ToString(),
                                IdCard = reader["id_card"].ToString()
                            };
                            dataInvoice.Add(Indata);

                        }
                    }
                }
                ;
            }catch(Exception e)
            {

                MessageBox.Show("Error Message connection: " + e.Message,
                             "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connect.Close();
            }

            return dataInvoice;

             

        }


    }
}
