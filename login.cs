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
    public partial class login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog= HotelSystem ;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Register registerAccount = new Register();
            registerAccount.Show();
            this.Hide();
             
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == " " || txtPassword.Text == " ")
            {

                MessageBox.Show("Please fill in all fields.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {

                    string selectData = "SELECT * FROM Users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        // ✅ Make sure parameter names match exactly (no spaces!)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);

                        if (tb.Rows.Count > 0)
                        {
                            // Get the username from the result
                            string username = tb.Rows[0]["username"].ToString();
                            MessageBox.Show("Login Successful", "Information Message",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Check if user is admin
                            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                            {
                                // Admin goes to dashboard
                                dashboard formMain = new dashboard();
                                formMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Non-admin users go to another form
                                WelcomeUser userForm = new WelcomeUser();
                                userForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.",
                                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                }



            }







                //dashboard dashboards = new dashboard();
                //dashboards.Show();
                //this.Hide();
            }
        

        private void login_password_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = login_password.Checked ? '\0' : '*';
        }
    }
}
