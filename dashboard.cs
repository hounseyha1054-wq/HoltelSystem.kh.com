using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you want logout?"," Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (check == DialogResult.Yes) {

                login login = new login();
                login.Show();
                this.Hide();


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {


            showdeatail1.Visible = true;
            rooms1.Visible = false;
            customers1.Visible = false;
            bookings1.Visible = false;
            billInvoice1.Visible = false;
            staff1.Visible = false;

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            showdeatail1.Visible = false;
            rooms1.Visible = true;
            customers1.Visible = false;
            bookings1.Visible = false;
            billInvoice1.Visible = false;
            staff1.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showdeatail1.Visible = false;
            rooms1.Visible = false;
            customers1.Visible = true;
            bookings1.Visible = false;
            billInvoice1.Visible = false;
            staff1.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            showdeatail1.Visible = false;
            rooms1.Visible = false;
            customers1.Visible = false;
            bookings1.Visible = true;
            billInvoice1.Visible = false;
            staff1.Visible = false;
        }

        private void btnBill_Invoice_Click(object sender, EventArgs e)
        {
            showdeatail1.Visible = false;
            rooms1.Visible = false;
            customers1.Visible = false;
            bookings1.Visible = false;
            billInvoice1.Visible = true;
            staff1.Visible = false;

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            showdeatail1.Visible = false;
            rooms1.Visible = false;
            customers1.Visible = false;
            bookings1.Visible = false;
            billInvoice1.Visible = false;
            staff1.Visible = true;
        }

        private void staff1_Load(object sender, EventArgs e)
        {

        }
    }
}
