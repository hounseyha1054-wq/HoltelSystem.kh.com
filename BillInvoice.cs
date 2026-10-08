using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
 


namespace Hotel_Management_System
{
    public partial class BillInvoice : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MYSQLSERVER;Initial Catalog=HotelSystem;Integrated Security=True");

        private PrintDocument printDocument = new PrintDocument();
        public BillInvoice()
        {
            InitializeComponent();
            displaypayment();
            printDocument.PrintPage += new PrintPageEventHandler(PrintReceipt);
        }
        public void displaypayment()
        {
           
            ClassPayment data = new ClassPayment();
            List<ClassPayment> dataList = data.DataPayment();
            dataGridPayment.DataSource = dataList;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (txtAmountPaid.Text == "" || txtPaymentBookingId.Text == "" || StatusPayment.Text == "" || dateTimePayment.Text == "")
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {


                    try
                    {
                        connect.Open();
                        string insert = "INSERT INTO Payments (booking_id,amount_paid,payment_date,method)" +
                            "VALUES(@bookingId,@Amount,@Payment,@method)";

                        using (SqlCommand cmd = new SqlCommand(insert, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookingId",txtPaymentBookingId.Text.Trim());
                            cmd.Parameters.AddWithValue("@Amount",txtAmountPaid.Text.ToString());
                            cmd.Parameters.AddWithValue("@Payment",dateTimePayment.Value);
                            cmd.Parameters.AddWithValue("@method",StatusPayment.Text.ToString());
                            
                            
                            cmd.ExecuteNonQuery();

                        }
                        displaypayment();
                        Clear();
                        

                        MessageBox.Show("Payment Successfully!",
                          "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
        public void Clear()
        {
            txtAmountPaid.Text = "";
            txtPaymentBookingId.Text = "";
          
            dateTimePayment.Text = "";
            StatusPayment.Text = "";
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void dataGridPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =  dataGridPayment.Rows[e.RowIndex];
                txtPaymentBookingId.Text = row.Cells["BookingId"].Value.ToString();
                txtAmountPaid.Text = row.Cells["AmountPaid"].Value.ToString();
                dateTimePayment.Text = row.Cells["PaymentDate"].Value.ToString();
                StatusPayment.Text = row.Cells["StatusPay"].Value.ToString();
            }

        }

        private void UpdatePayment_Click(object sender, EventArgs e)
        {
            if (txtAmountPaid.Text == "" || txtPaymentBookingId.Text == "" || StatusPayment.Text == "" || dateTimePayment.Text == "")
            {
                MessageBox.Show("Please fill in the blank!", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you want to Update ?", txtPaymentBookingId.Text.Trim()+ "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check==DialogResult.Yes)
                {
                    try
                    {


                        connect.Open();
                        string Update = "UPDATE  Payments SET amount_paid=@Amount,payment_date=@Payment,method=@method,Update_at=@Update WHERE  booking_id=@BookingId";
                        DateTime today = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(Update, connect))
                        {
                            
                            cmd.Parameters.AddWithValue("@Amount",txtAmountPaid.Text.ToString());
                            cmd.Parameters.AddWithValue("@Payment", dateTimePayment.Value);
                            cmd.Parameters.AddWithValue("@method", StatusPayment.Text.ToString());
                            cmd.Parameters.AddWithValue("@Update", today);
                            cmd.Parameters.AddWithValue("@BookingId",txtPaymentBookingId.Text.ToString());


                            cmd.ExecuteNonQuery();

                        }
                        displaypayment();
                        Clear();


                        MessageBox.Show("Update Successfully!",
                          "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void ViewPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentBookingId.Text))
            {
                MessageBox.Show("Please select a payment record first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show print preview
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();


        }


        // ✅ Print the Receipt
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            // Layout setup
            int leftMargin = 50;
            int topMargin = 100;
            int lineHeight = 30;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Header
            e.Graphics.DrawString("HOTEL INVOICE RECEIPT", titleFont, brush, leftMargin, topMargin);
            topMargin += 50;

            // Payment Info Section
            e.Graphics.DrawString("Booking ID: " + txtPaymentBookingId.Text, contentFont, brush, leftMargin, topMargin);
            topMargin += lineHeight;

            e.Graphics.DrawString("Payment Date: " + dateTimePayment.Text, contentFont, brush, leftMargin, topMargin);
            topMargin += lineHeight;

            e.Graphics.DrawString("Payment Method: " + StatusPayment.Text, contentFont, brush, leftMargin, topMargin);
            topMargin += lineHeight;

            e.Graphics.DrawString("Amount Paid: $" + txtAmountPaid.Text, contentFont, brush, leftMargin, topMargin);
            topMargin += lineHeight;

            // Footer
            topMargin += 50;
            e.Graphics.DrawString("Thank you for your payment!", contentFont, brush, leftMargin, topMargin);
            topMargin += 20;

            e.Graphics.DrawString("Printed on: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"),
                new Font("Arial", 10, FontStyle.Italic), brush, leftMargin, topMargin);
        }

        private void dataGridPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BillInvoice_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Payment.BackColor = Color.Transparent;
            Payment.ForeColor = Color.Transparent;

        }
    }
    }

