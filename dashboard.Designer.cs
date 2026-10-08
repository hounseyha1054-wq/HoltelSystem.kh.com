namespace Hotel_Management_System
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnstaff = new System.Windows.Forms.Button();
            this.btnBill_Invoice = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staff1 = new Hotel_Management_System.Staff();
            this.billInvoice1 = new Hotel_Management_System.BillInvoice();
            this.bookings1 = new Hotel_Management_System.Bookings();
            this.customers1 = new Hotel_Management_System.customers();
            this.rooms1 = new Hotel_Management_System.Rooms();
            this.showdeatail1 = new Hotel_Management_System.showdeatail();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnstaff);
            this.panel1.Controls.Add(this.btnBill_Invoice);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 829);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 774);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "signout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(167, 774);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaff.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.Image = ((System.Drawing.Image)(resources.GetObject("btnstaff.Image")));
            this.btnstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstaff.Location = new System.Drawing.Point(39, 654);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(281, 65);
            this.btnstaff.TabIndex = 3;
            this.btnstaff.Text = "Staff Management";
            this.btnstaff.UseVisualStyleBackColor = false;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btnBill_Invoice
            // 
            this.btnBill_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBill_Invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill_Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill_Invoice.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill_Invoice.ForeColor = System.Drawing.Color.White;
            this.btnBill_Invoice.Image = ((System.Drawing.Image)(resources.GetObject("btnBill_Invoice.Image")));
            this.btnBill_Invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill_Invoice.Location = new System.Drawing.Point(39, 575);
            this.btnBill_Invoice.Name = "btnBill_Invoice";
            this.btnBill_Invoice.Size = new System.Drawing.Size(281, 65);
            this.btnBill_Invoice.TabIndex = 3;
            this.btnBill_Invoice.Text = "Bill And Invoice";
            this.btnBill_Invoice.UseVisualStyleBackColor = false;
            this.btnBill_Invoice.Click += new System.EventHandler(this.btnBill_Invoice_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(39, 490);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(281, 65);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(39, 410);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(281, 65);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(39, 328);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(281, 65);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(39, 241);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(281, 65);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome , Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.staff1);
            this.panel2.Controls.Add(this.billInvoice1);
            this.panel2.Controls.Add(this.bookings1);
            this.panel2.Controls.Add(this.customers1);
            this.panel2.Controls.Add(this.rooms1);
            this.panel2.Controls.Add(this.showdeatail1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(340, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 823);
            this.panel2.TabIndex = 3;
            // 
            // staff1
            // 
            this.staff1.Location = new System.Drawing.Point(0, 0);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(1070, 823);
            this.staff1.TabIndex = 8;
            this.staff1.Load += new System.EventHandler(this.staff1_Load);
            // 
            // billInvoice1
            // 
            this.billInvoice1.Location = new System.Drawing.Point(0, -3);
            this.billInvoice1.Name = "billInvoice1";
            this.billInvoice1.Size = new System.Drawing.Size(1070, 823);
            this.billInvoice1.TabIndex = 7;
            // 
            // bookings1
            // 
            this.bookings1.Location = new System.Drawing.Point(0, 0);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(1070, 823);
            this.bookings1.TabIndex = 6;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(0, 0);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1070, 823);
            this.customers1.TabIndex = 5;
            // 
            // rooms1
            // 
            this.rooms1.Location = new System.Drawing.Point(0, -3);
            this.rooms1.Name = "rooms1";
            this.rooms1.Size = new System.Drawing.Size(1070, 823);
            this.rooms1.TabIndex = 4;
            // 
            // showdeatail1
            // 
            this.showdeatail1.Location = new System.Drawing.Point(0, -3);
            this.showdeatail1.Name = "showdeatail1";
            this.showdeatail1.Size = new System.Drawing.Size(1070, 823);
            this.showdeatail1.TabIndex = 3;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 825);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Button btnBill_Invoice;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel panel2;
        private showdeatail showdeatail1;
        private Staff staff1;
        private BillInvoice billInvoice1;
        private Bookings bookings1;
        private customers customers1;
        private Rooms rooms1;
    }
}