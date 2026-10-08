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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            displayInvoice();
        }
        public void displayInvoice()
        {
            ClassInvoice  classInvoice = new ClassInvoice();
            List<ClassInvoice> DataShow = classInvoice.DataInvoice();
            dataGridInvoice.DataSource = DataShow;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();


        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void dataGridInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
