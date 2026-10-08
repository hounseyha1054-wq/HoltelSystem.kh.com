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
    public partial class customers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog= HotelSystem ;Integrated Security=True");

        public customers()
        {
            InitializeComponent();
            displaycustomer();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void displaycustomer()


        {

            Customer cst= new Customer();
            List<Customer> get = cst.DataCustomer();
            //dataGridCustomer.DataSource = list;
            dataGridCustomer.DataSource =get;




        }

        private void AddCustomers_Click(object sender, EventArgs e)
        {


            if(txtCustomerId.Text ==" "|| 
               txtFullName.Text ==" "
               || txtEmail.Text==""
               || txtCardId.Text==""
               || txtPhone.Text== "")
            {
                MessageBox.Show("Please fill in the blank!! ",
                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {




                try
                {

                    connect.Open();

                    string CheckEmID = "SELECT COUNT(*) FROM Customers WHERE  customer_id = @emID AND delete_at IS NULL";

                    using (SqlCommand CheckEm = new SqlCommand(CheckEmID, connect))
                    {
                        CheckEm.Parameters.AddWithValue("@emID", txtCustomerId.Text.Trim());

                        int count = (int)CheckEm.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(txtCustomerId.Text.Trim() + " is already exist",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string Insert = "INSERT INTO  Customers (fullname , email , phonenumber , id_card, Insert_at,customer_id)" +
                        " VALUES(@FullName, @Email, @Phone, @Idcard, @Insert,@CustomerId) ";

                    DateTime today = DateTime.Today;

                 using (SqlCommand cmd = new SqlCommand(Insert, connect))
                 {


                        cmd.Parameters.AddWithValue("@FullName",txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                        cmd.Parameters.AddWithValue("@Idcard",txtCardId.Text.Trim());
                        cmd.Parameters.AddWithValue("@Insert",today);
                        cmd.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text.Trim());

                        cmd.ExecuteNonQuery(); 

                    }

                    displaycustomer();
                    clearCs();
                    MessageBox.Show("Add Successfully ", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Information);







                }
                catch (Exception ex) {

                    MessageBox.Show("Error Message connection " + ex.Message,
                      "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                finally
                {
                    connect.Close();
                }

            }
        }
        public void clearCs()
        {
            txtCardId.Text = "";
            txtCustomerId.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtFullName.Text = "";
        }

        private void UpdateCustomers_Click(object sender, EventArgs e)
        {

            if (txtCustomerId.Text == "" || txtCardId.Text == "" || txtFullName.Text == "" || txtEmail.Text == "" || txtPhone.Text=="")
            {

                MessageBox.Show("Please fill in the Blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                DialogResult check = MessageBox.Show("Are you want to update ?" + txtCustomerId.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string Update ="UPDATE Customers SET " +
                            "fullname=@fullname," +
                            "email =@email," +
                            "phonenumber =@number," +
                             "id_card=@idcard," +
                         
                            "Update_at=@update " +
                          " WHERE customer_id=@CsID ";

                        DateTime today = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(Update, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname",txtFullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@number", txtPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@idcard",txtCardId.Text.Trim());

                            cmd.Parameters.AddWithValue("@update", today);
                            cmd.Parameters.AddWithValue("@CsID", txtCustomerId.Text.Trim());

                            cmd.ExecuteNonQuery();

                        }

                        displaycustomer();
                        clearCs();




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

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)

            {



                DataGridViewRow row =  dataGridCustomer.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells[1].Value?.ToString()?? "";
                txtCardId.Text = row.Cells[2].Value?.ToString() ?? "";
               txtFullName.Text = row.Cells[3].Value?.ToString() ?? "";
               txtPhone.Text = row.Cells[4].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[5].Value?.ToString() ?? "";
               




            }
            {

            }
        }

        private void DeleteCustomers_Click(object sender, EventArgs e)
        {
            if(txtCardId.Text==""|| txtCustomerId.Text==""|| txtEmail.Text==""|| txtPhone.Text==""|| txtFullName.Text == "")
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Check = MessageBox.Show(
                                               "Are you want to DElETE STAFF ID " + txtCustomerId.Text.Trim() + "?",
                                               "Confirmation Message",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

                if (Check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string Delete = "UPDATE Customers SET Delete_at= @deleteAt" +
                            " WHERE customer_id= @customerId";
                        using (SqlCommand cmd = new SqlCommand(Delete,connect)) {

                             cmd.Parameters.AddWithValue("@deleteAt", today);
                            cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

                            cmd.ExecuteNonQuery();
                        
                        }
                        displaycustomer();
                        clearCs();

                        MessageBox.Show("Delete Succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex) {

                        MessageBox.Show("Error Message Connection " + ex.Message,"Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtCardId.Text == "" || txtCustomerId.Text == "" || txtEmail.Text == "" || txtFullName.Text == "" || txtPhone.Text=="")
            {
                MessageBox.Show("Noting Data ", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPhone.Text = "";
               txtCardId.Text = "";
                txtEmail.Text = "";
              txtFullName.Text="";
                txtCustomerId.Text = "";

            }

        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
