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
    public partial class Rooms : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog= HotelSystem ;Integrated Security=True");


        public Rooms()
        {
            InitializeComponent();
            displayRoom();
            

        }

        public void displayRoom()
        {
            RoomData roomData = new RoomData();
            List<RoomData> Data = roomData.DataRooms();

            dataGridRoom.DataSource = Data;
        }

        
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addroom_Click(object sender, EventArgs e)
        {

            if (txtRoomIDHotel.Text == "" ||txtroomtypehotel.Text == ""

          || txtRoomPriceHotel.Text == ""
          || StatusRoom.Text == ""
           

            )
            {
                MessageBox.Show("Please fill in the blanks!!"," Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();


                        string CheckEmID = "SELECT COUNT(*) FROM Room WHERE room_id = @emID AND delete_at IS NULL";

                        using (SqlCommand CheckEm = new SqlCommand(CheckEmID, connect))
                        {
                            CheckEm.Parameters.AddWithValue("@emID", txtRoomIDHotel.Text.Trim());

                            int count = (int)CheckEm.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(txtRoomIDHotel.Text.Trim() + " is already exist",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }


                        string insertData = "INSERT INTO Room  (room_id , roomtype, price,status, insert_at) " +
                            "VALUES (@RoomId,@Roomtype,@Price,@Status,@Insert)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@RoomId",txtRoomIDHotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Roomtype",txtroomtypehotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Price",txtRoomPriceHotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Status",StatusRoom.Text.Trim());
                            
                            cmd.Parameters.AddWithValue("@Insert", today);

                            cmd.ExecuteNonQuery();
 
                           



                        }
                        displayRoom();
                        ClearRoom();



                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message connection " + ex.Message,
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }



            }





        }


        public void ClearRoom()
        {
            txtRoomIDHotel.Text = "";
            txtRoomPriceHotel.Text = "";
            txtroomtypehotel.SelectedIndex = -1;
            StatusRoom.SelectedIndex = -1;
            
            
        }

        private void StatusRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridRoom.Rows[e.RowIndex];

                txtRoomIDHotel.Text = row.Cells["RoomId"].Value?.ToString() ?? "";
                txtroomtypehotel.Text = row.Cells["RoomType"].Value?.ToString() ?? "";
                txtRoomPriceHotel.Text = row.Cells["Price"].Value?.ToString() ?? "";
                StatusRoom.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }

        }

        private void UpdateRoom_Click(object sender, EventArgs e)
        {


            if(txtRoomIDHotel.Text ==""|| txtroomtypehotel.Text=="" || txtRoomPriceHotel.Text==""|| StatusRoom.Text == "") { 

                MessageBox.Show("Please fill in the Blank!","Error Message ",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                DialogResult check = MessageBox.Show("Are you want to update ?" + txtRoomIDHotel.Text.Trim() + "?", "Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string Update = "UPDATE Room SET " +
                            "roomtype= @Roomtype," +
                            "price =@Price," +
                            "status =@Status," +
                            "update_at=@update " +
                            " WHERE room_id=@RoomID ";

                        DateTime today= DateTime.Today;
                       using(SqlCommand cmd= new SqlCommand(Update,connect))
                        {
                            cmd.Parameters.AddWithValue("@Roomtype",txtroomtypehotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Price",txtRoomPriceHotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Status",StatusRoom.Text.Trim());
                            cmd.Parameters.AddWithValue("@update", today);
                            cmd.Parameters.AddWithValue("@RoomID",txtRoomIDHotel.Text.Trim());

                            cmd.ExecuteNonQuery();

                        }
                        displayRoom();
                        ClearRoom();

                        MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }catch (Exception ex)
                    {
                        MessageBox.Show("Error connection "+ex,"Error Message ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void DeleteRoom_Click(object sender, EventArgs e)
        {

            if (txtRoomIDHotel.Text == "" || txtroomtypehotel.Text == "" || txtRoomPriceHotel.Text == "" || StatusRoom.Text == "")
            {

                MessageBox.Show("Please fill in the Blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                DialogResult check = MessageBox.Show("Are you want to Delete ?" + txtRoomIDHotel.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string Update = "UPDATE Room SET delete_at=@Delete WHERE room_id= @RoomId";

                        DateTime today = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(Update, connect))
                        {
                          
                           
                            
                            cmd.Parameters.AddWithValue("@RoomID", txtRoomIDHotel.Text.Trim());
                            cmd.Parameters.AddWithValue("@Delete", today);

                            cmd.ExecuteNonQuery();

                        }
                        displayRoom();
                        ClearRoom();

                        MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connection " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if(txtroomtypehotel.Text==""|| txtRoomIDHotel.Text ==""|| StatusRoom.Text==""|| txtRoomIDHotel.Text == "")
            {
                MessageBox.Show("Noting Data ", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtRoomIDHotel.Text = "";
                txtRoomPriceHotel.Text = "";
                txtroomtypehotel.SelectedIndex = -1;
                StatusRoom.SelectedIndex = -1;

            }
               
        }
    }
}
