using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Staff : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");

        public Staff()
        {
            InitializeComponent();
            displaystaff();
           
        }

        public void displaystaff()
        {
            StaffData  ed= new  StaffData();
            List<StaffData> listData = ed.DataStaff();

            dataGridStaff.DataSource = listData;

        }

        public void cleaafiled()
        {
            txtStaffId.Text = "";
            txtfullname.Text = "";
            txtPhoneStaff.Text = "";
            txtPhoneStaff.Text = "";
            txtAddressStaff.Text = "";
            txtStaffgender.SelectedIndex = -1;
            txtRoleStaff.Text = "";
            statusStaff.SelectedIndex = -1;
            txtEmailStaff.Text = "";
            

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffId.Text == "" || txtfullname.Text == ""

            || txtEmailStaff.Text == ""
            || txtAddressStaff.Text == ""
            || txtPhoneStaff.Text==""
            || txtRoleStaff.Text==""
            || txtStaffgender.Text==""
            || statusStaff.Text==""

              )
            {
                MessageBox.Show("Please fill in the blanks!!", "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // 1. Check if staff ID exists in active records (delete_at IS NULL)
                        string CheckEmID = "SELECT COUNT(*) FROM Staff WHERE staff_ID = @emID AND delete_at IS NULL";

                        using (SqlCommand CheckEm = new SqlCommand(CheckEmID, connect))
                        {
                            CheckEm.Parameters.AddWithValue("@emID", txtStaffId.Text.Trim());

                            int count = (int)CheckEm.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(txtStaffId.Text.Trim() + " is already exist",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // stop insert if duplicate
                            }
                        }

                        // 2. Insert data with matching parameters and correct values
                        string insertData = "INSERT INTO Staff " +
                            "(staff_id, fullname, gender, email, phone, address, role, status, insert_at) " +
                            "VALUES (@staffId, @fullName, @gender, @Email, @Phone, @Address, @Role, @Status, @Insertat)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@staffId", txtStaffId.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullName", txtfullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", txtStaffgender.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmailStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txtPhoneStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txtAddressStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Role", txtRoleStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Status", statusStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Insertat", today);

                            cmd.ExecuteNonQuery();
                        }

                        // 3. Refresh the grid and clear input
                        displaystaff();
                        cleaafiled();

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

        private void dataGridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                DataGridViewRow row =dataGridStaff.Rows[e.RowIndex];

                // Set text values
                txtStaffId.Text = row.Cells[1].Value?.ToString() ?? "";
                txtfullname.Text = row.Cells[2].Value?.ToString() ?? "";
                txtStaffgender.Text = row.Cells[3].Value?.ToString() ?? "";
                txtEmailStaff.Text = row.Cells[4].Value?.ToString() ?? "";
                txtPhoneStaff.Text = row.Cells[5].Value?.ToString() ?? "";
                txtAddressStaff.Text = row.Cells[6].Value?.ToString() ?? "";
                txtRoleStaff.Text = row.Cells[7].Value?.ToString() ?? "";
                statusStaff.Text = row.Cells[8].Value?.ToString() ?? "";




                // Get image filename from cell


            }






        }

        private void UpdateStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffId.Text == "" || txtfullname.Text == ""

           || txtEmailStaff.Text == ""
           || txtAddressStaff.Text == ""
           || txtPhoneStaff.Text == ""
           || txtRoleStaff.Text == ""
           || txtStaffgender.Text == ""
           || statusStaff.Text == ""

             )
            {
                MessageBox.Show("Please fill in the blanks!!", "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {
                DialogResult Check = MessageBox.Show(
                                                 "Are you want to UPDATE STAFF ID " + txtStaffId.Text.Trim() + "?",
                                                 "Confirmation Message",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                if (Check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string UpdateData = "UPDATE Staff SET " +
                            "fullname = @fullName, " +
                            "gender = @gender, " +
                            "email = @Email, " +
                            "phone = @Phone, " +
                            "address = @Address, " +
                            "role = @Role, " +
                            "status = @Status, " +
                            "update_at = @updateat " +
                            "WHERE staff_ID = @staffId";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(UpdateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", txtfullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", txtStaffgender.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmailStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txtPhoneStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txtAddressStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Role", txtRoleStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@Status", statusStaff.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateat", today);
                            cmd.Parameters.AddWithValue("@staffId", txtStaffId.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        displaystaff();
                        cleaafiled();

                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClearStaff_Click(object sender, EventArgs e)
        {
            cleaafiled();
        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffId.Text == "" || txtfullname.Text == ""

         || txtEmailStaff.Text == ""
         || txtAddressStaff.Text == ""
         || txtPhoneStaff.Text == ""
         || txtRoleStaff.Text == ""
         || txtStaffgender.Text == ""
         || statusStaff.Text == ""

           )
            {
                MessageBox.Show("Please fill in the blanks!!", "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {
                DialogResult Check = MessageBox.Show(
                                                 "Are you want to DElETE STAFF ID " + txtStaffId.Text.Trim() + "?",
                                                 "Confirmation Message",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                if (Check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string UpdateData = " UPDATE Staff SET delete_at =@delete_at" +
                            " WHERE staff_ID= @staffId";


                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(UpdateData, connect))
                        {
                          
                            cmd.Parameters.AddWithValue("@delete_at", today);
                            cmd.Parameters.AddWithValue("@staffId", txtStaffId.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        displaystaff();
                        cleaafiled();

                        MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message connection " + ex.Message,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
