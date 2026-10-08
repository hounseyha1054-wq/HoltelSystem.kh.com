namespace Hotel_Management_System
{
    partial class Bookings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClearBooking = new System.Windows.Forms.Button();
            this.Delete_Booking = new System.Windows.Forms.Button();
            this.Update_Booking = new System.Windows.Forms.Button();
            this.Add_Booking = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridBooking = new System.Windows.Forms.DataGridView();
            this.txtBookingStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingRoomID = new System.Windows.Forms.TextBox();
            this.txtBookingCustomerId = new System.Windows.Forms.TextBox();
            this.txtBookingTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.txtcheckin = new System.Windows.Forms.DateTimePicker();
            this.txtcheckout = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearBooking
            // 
            this.btnClearBooking.BackColor = System.Drawing.Color.Navy;
            this.btnClearBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBooking.ForeColor = System.Drawing.Color.White;
            this.btnClearBooking.Location = new System.Drawing.Point(798, 733);
            this.btnClearBooking.Name = "btnClearBooking";
            this.btnClearBooking.Size = new System.Drawing.Size(158, 39);
            this.btnClearBooking.TabIndex = 45;
            this.btnClearBooking.Text = "Clear";
            this.btnClearBooking.UseVisualStyleBackColor = false;
            this.btnClearBooking.Click += new System.EventHandler(this.btnClearBooking_Click);
            // 
            // Delete_Booking
            // 
            this.Delete_Booking.BackColor = System.Drawing.Color.DeepPink;
            this.Delete_Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Booking.ForeColor = System.Drawing.Color.White;
            this.Delete_Booking.Location = new System.Drawing.Point(602, 733);
            this.Delete_Booking.Name = "Delete_Booking";
            this.Delete_Booking.Size = new System.Drawing.Size(158, 39);
            this.Delete_Booking.TabIndex = 46;
            this.Delete_Booking.Text = "Delete Booking";
            this.Delete_Booking.UseVisualStyleBackColor = false;
            this.Delete_Booking.Click += new System.EventHandler(this.Delete_Booking_Click);
            // 
            // Update_Booking
            // 
            this.Update_Booking.BackColor = System.Drawing.Color.Purple;
            this.Update_Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Booking.ForeColor = System.Drawing.Color.White;
            this.Update_Booking.Location = new System.Drawing.Point(391, 733);
            this.Update_Booking.Name = "Update_Booking";
            this.Update_Booking.Size = new System.Drawing.Size(158, 39);
            this.Update_Booking.TabIndex = 47;
            this.Update_Booking.Text = "Update Booking";
            this.Update_Booking.UseVisualStyleBackColor = false;
            this.Update_Booking.Click += new System.EventHandler(this.Update_Booking_Click);
            // 
            // Add_Booking
            // 
            this.Add_Booking.BackColor = System.Drawing.Color.LightSlateGray;
            this.Add_Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Booking.ForeColor = System.Drawing.Color.White;
            this.Add_Booking.Location = new System.Drawing.Point(176, 733);
            this.Add_Booking.Name = "Add_Booking";
            this.Add_Booking.Size = new System.Drawing.Size(158, 39);
            this.Add_Booking.TabIndex = 48;
            this.Add_Booking.Text = "Add Booking";
            this.Add_Booking.UseVisualStyleBackColor = false;
            this.Add_Booking.Click += new System.EventHandler(this.Add_Booking_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(399, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 34);
            this.label7.TabIndex = 44;
            this.label7.Text = "Booking Management";
            // 
            // dataGridBooking
            // 
            this.dataGridBooking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooking.Location = new System.Drawing.Point(102, 107);
            this.dataGridBooking.Name = "dataGridBooking";
            this.dataGridBooking.RowHeadersWidth = 51;
            this.dataGridBooking.RowTemplate.Height = 24;
            this.dataGridBooking.Size = new System.Drawing.Size(904, 287);
            this.dataGridBooking.TabIndex = 43;
            this.dataGridBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooking_CellClick);
            // 
            // txtBookingStatus
            // 
            this.txtBookingStatus.FormattingEnabled = true;
            this.txtBookingStatus.Items.AddRange(new object[] {
            "Reserved",
            "Cancelled"});
            this.txtBookingStatus.Location = new System.Drawing.Point(487, 642);
            this.txtBookingStatus.Name = "txtBookingStatus";
            this.txtBookingStatus.Size = new System.Drawing.Size(273, 24);
            this.txtBookingStatus.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "checkin date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Room ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "checkout date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Customer_ID:";
            // 
            // txtBookingRoomID
            // 
            this.txtBookingRoomID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingRoomID.Location = new System.Drawing.Point(243, 575);
            this.txtBookingRoomID.Multiline = true;
            this.txtBookingRoomID.Name = "txtBookingRoomID";
            this.txtBookingRoomID.Size = new System.Drawing.Size(267, 30);
            this.txtBookingRoomID.TabIndex = 31;
            // 
            // txtBookingCustomerId
            // 
            this.txtBookingCustomerId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerId.Location = new System.Drawing.Point(243, 509);
            this.txtBookingCustomerId.Multiline = true;
            this.txtBookingCustomerId.Name = "txtBookingCustomerId";
            this.txtBookingCustomerId.Size = new System.Drawing.Size(268, 34);
            this.txtBookingCustomerId.TabIndex = 32;
            // 
            // txtBookingTotal
            // 
            this.txtBookingTotal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingTotal.Location = new System.Drawing.Point(709, 569);
            this.txtBookingTotal.Multiline = true;
            this.txtBookingTotal.Name = "txtBookingTotal";
            this.txtBookingTotal.Size = new System.Drawing.Size(268, 34);
            this.txtBookingTotal.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1031, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 51;
            this.label9.Text = "Booking_ID:";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingId.Location = new System.Drawing.Point(242, 449);
            this.txtBookingId.Multiline = true;
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(268, 34);
            this.txtBookingId.TabIndex = 50;
            // 
            // txtcheckin
            // 
            this.txtcheckin.CustomFormat = "dd-MM-yyyy";
            this.txtcheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcheckin.Location = new System.Drawing.Point(709, 460);
            this.txtcheckin.Name = "txtcheckin";
            this.txtcheckin.Size = new System.Drawing.Size(268, 22);
            this.txtcheckin.TabIndex = 52;
            this.txtcheckin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtcheckout
            // 
            this.txtcheckout.CustomFormat = "dd-MM-yyyy";
            this.txtcheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcheckout.Location = new System.Drawing.Point(709, 521);
            this.txtcheckout.Name = "txtcheckout";
            this.txtcheckout.Size = new System.Drawing.Size(268, 22);
            this.txtcheckout.TabIndex = 52;
            this.txtcheckout.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.txtcheckout);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearBooking);
            this.Controls.Add(this.Delete_Booking);
            this.Controls.Add(this.Update_Booking);
            this.Controls.Add(this.Add_Booking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridBooking);
            this.Controls.Add(this.txtBookingStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookingRoomID);
            this.Controls.Add(this.txtBookingCustomerId);
            this.Controls.Add(this.txtBookingTotal);
            this.Name = "Bookings";
            this.Size = new System.Drawing.Size(1070, 823);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearBooking;
        private System.Windows.Forms.Button Delete_Booking;
        private System.Windows.Forms.Button Update_Booking;
        private System.Windows.Forms.Button Add_Booking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridBooking;
        private System.Windows.Forms.ComboBox txtBookingStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookingRoomID;
        private System.Windows.Forms.TextBox txtBookingCustomerId;
        private System.Windows.Forms.TextBox txtBookingTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.DateTimePicker txtcheckin;
        private System.Windows.Forms.DateTimePicker txtcheckout;
    }
}
