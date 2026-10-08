using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class showdeatail : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");

        public showdeatail()
        {
            InitializeComponent();
            DisplayTR();
            DisplayTB();
            DisplayTotalIncome();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTotalrooms_Click(object sender, EventArgs e)
        {
            
        }


        private void DisplayTR()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string selectData = "SELECT COUNT(id) FROM Room WHERE delete_at IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            txtTotalrooms.Text = count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                    connect.Close();
            }
        }


        private void DisplayTB()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string selectData = "SELECT COUNT(id) FROM Bookings WHERE Delete_at IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            txtTotalBooking.Text = count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                connect.Close();
            }
        }


        private void DisplayTotalIncome()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string selectData = "SELECT SUM(amount_paid) FROM Payments WHERE delete_at IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            txtTotalincome.Text = count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                connect.Close();
            }
        }


    }
}
