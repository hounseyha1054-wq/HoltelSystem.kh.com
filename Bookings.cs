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
    public partial class Bookings : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog= HotelSystem ;Integrated Security=True");

        public Bookings()
        {
            InitializeComponent();
            showBooking();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void showBooking()
        {
           BookingClass bookingClass = new BookingClass();
            List<BookingClass> ed = bookingClass.DataBooking();
            dataGridBooking.DataSource = ed;
        }

        public void clearform() { 
        
            txtBookingCustomerId.Text = "";
            txtBookingId.Text = "";
            txtBookingRoomID.Text = "";
            txtBookingTotal.Text = "";
            txtcheckin.Text = "";
            txtBookingStatus.SelectedIndex = -1;

        }
        private void Add_Booking_Click(object sender, EventArgs e)
        {
            if (txtBookingCustomerId.Text == "" || txtBookingId.Text == ""
                || txtBookingRoomID.Text == ""
                || txtBookingTotal.Text == ""
                || txtcheckin.Text == ""
                || txtBookingStatus.Text == ""
                || txtcheckout.Text == ""
                )
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                
                    try
                    {
                        connect.Open();

                    string CheckBooing = "SELECT COUNT(*) FROM Bookings WHERE booking_id=@bookingId";
                        using (SqlCommand cmd = new SqlCommand(CheckBooing, connect))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", txtBookingId.Text.ToString());
                        int Count= (int)cmd.ExecuteScalar();
                        if(Count > 0)
                        {
                            MessageBox.Show(txtBookingId.Text.Trim() + " is already exist",
                               "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                         

                        string Insert = "INSERT INTO Bookings (customer_id,room_id,checkin_date,checkout_date,totalprice,status,booking_id)" +
                            " VAlUES(@CsId,@roomId,@Cin,@Cout,@total,@status,@bookingId)";
                        using (SqlCommand cmd = new SqlCommand(Insert, connect))
                        {

                            cmd.Parameters.AddWithValue("@CsId",txtBookingCustomerId.Text.ToString());
                            cmd.Parameters.AddWithValue("@roomId", txtBookingRoomID.Text.Trim());
                            cmd.Parameters.AddWithValue("@Cin",txtcheckin.Text.ToString());
                            cmd.Parameters.AddWithValue("@Cout",txtcheckout.Text.ToString());

                            cmd.Parameters.AddWithValue("@total",txtBookingTotal.Text.ToString());
                            cmd.Parameters.AddWithValue("@status",txtBookingStatus.Text.ToString());
                            cmd.Parameters.AddWithValue("@bookingId", txtBookingId.Text.ToString());

                            cmd.ExecuteNonQuery();


                        }

                        showBooking();
                        clearform();



                        MessageBox.Show("Add Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)


                    {

                        MessageBox.Show("Error connection information " + ex.Message, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
                }


            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClearBooking_Click(object sender, EventArgs e)
        {
            if( txtcheckin.Text==""|| txtcheckin.Text==""|| txtBookingCustomerId.Text==""|| txtBookingId.Text==""
                || txtBookingStatus.Text==""|| txtBookingTotal.Text==""|| txtBookingRoomID.Text=="")
            {
                MessageBox.Show("Nothing data!","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                clearform();
            }

        }

        private void dataGridBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow R = dataGridBooking.Rows[e.RowIndex];

                txtBookingId.Text = R.Cells[1].Value?.ToString();
                txtBookingCustomerId.Text = R.Cells[2].Value?.ToString();
                txtBookingRoomID.Text = R.Cells[3].Value?.ToString();
                txtcheckin.Text = R.Cells[4].Value?.ToString();
                txtcheckout.Text = R.Cells[5].Value?.ToString();
                txtBookingStatus.Text = R.Cells[6].Value?.ToString();
                txtBookingTotal.Text = R.Cells[7].Value?.ToString();
            }

        }

        private void Update_Booking_Click(object sender, EventArgs e)
        {
            if (txtBookingCustomerId.Text == "" || txtBookingId.Text == ""
               || txtBookingRoomID.Text == ""
               || txtBookingTotal.Text == ""
               || txtcheckin.Text == ""
               || txtBookingStatus.Text == ""
               || txtcheckout.Text == ""
               )
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DialogResult check = MessageBox.Show("Are you want to update ?" + txtBookingId.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //DialogResult Check =MessageBox.Show("Are you want to update?",txtBookingId.Text.Trim(),MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check ==DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string Update =
                              "UPDATE Bookings SET " +
                              "customer_id = @CsT, " +
                              "room_id = @roomId, " +
                              "checkin_date = @In, " +
                              "checkout_date = @Out, " +
                              "totalprice = @TotalPrice, " +
                              "status = @Status, " +
                              "Update_ate = @Update " +
                              "WHERE booking_id = @bookingId";

                        DateTime today = DateTime.Today;

                        using(SqlCommand cmd= new SqlCommand(Update,connect))
                        {
                            cmd.Parameters.AddWithValue("@CsT",txtBookingCustomerId.Text.ToString());
                            cmd.Parameters.AddWithValue("@roomId",txtBookingRoomID.Text.ToString());
                            cmd.Parameters.AddWithValue("@In",txtcheckin.Text.ToString());
                            cmd.Parameters.AddWithValue("@Out", txtcheckout.Text.ToString());
                            cmd.Parameters.AddWithValue("@TotalPrice",txtBookingTotal.Text.ToString());
                            cmd.Parameters.AddWithValue("@Status",txtBookingStatus.Text.ToString());
                             
                            cmd.Parameters.AddWithValue("@bookingId", txtBookingId.Text.ToString());
                            cmd.Parameters.AddWithValue("@Update", today);

                            cmd.ExecuteNonQuery();
                            
                        }
                        showBooking();
                        clearform();



                        MessageBox.Show("Update Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error Message"+ Ex,"Error Contnection",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }



            }





        }

        private void Delete_Booking_Click(object sender, EventArgs e)
        {

            if (txtBookingCustomerId.Text == "" || txtBookingId.Text == ""
              || txtBookingRoomID.Text == ""
              || txtBookingTotal.Text == ""
              || txtcheckin.Text == ""
              || txtBookingStatus.Text == ""
              || txtcheckout.Text == ""
              )
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you want to Delete ?" + txtBookingId.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //DialogResult Check =MessageBox.Show("Are you want to update?",txtBookingId.Text.Trim(),MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string Update = "UPDATE  Bookings SET Delete_at= @Delete  WHERE booking_id = @BookingId ";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(Update, connect))
                        {
                             

                            cmd.Parameters.AddWithValue("@BookingId",txtBookingId.Text.ToString());
                            cmd.Parameters.AddWithValue("@Delete", today);

                            cmd.ExecuteNonQuery();

                        }
                        showBooking();
                        clearform();



                        MessageBox.Show("Delete  Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error Message" + Ex, "Error Contnection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }



            }


        }
    }

}
