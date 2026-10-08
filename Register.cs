using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{

 
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");


        public Register()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            login formlogin = new login();
            formlogin.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectUserName = "SELECT COUNT(id) FROM Users WHERE Username = @users";

                    using (SqlCommand Checkeduser = new SqlCommand(selectUserName, connect))
                    {
                        Checkeduser.Parameters.AddWithValue("@users", txtUsername.Text.Trim());
                        int count = (int)Checkeduser.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(txtUsername.Text.Trim() + " is already taken as a username!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            string insertdata = "INSERT INTO Users (username, password, date_register) VALUES (@username, @password, @dateReg)";
                            using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                            {
                                cmd.Parameters.AddWithValue("@username",  txtUsername.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateReg", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                login formlogin = new login();
                                formlogin.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void login_password_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = register_password.Checked ? '\0' : '*';

        }
    }
}
