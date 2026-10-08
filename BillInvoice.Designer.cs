namespace Hotel_Management_System
{
    partial class BillInvoice
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
            this.dateTimePayment = new System.Windows.Forms.DateTimePicker();
            this.StatusPayment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtPaymentBookingId = new System.Windows.Forms.TextBox();
            this.btnClearPayment = new System.Windows.Forms.Button();
            this.UpdatePayment = new System.Windows.Forms.Button();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.dataGridPayment = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewPayment = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePayment
            // 
            this.dateTimePayment.CustomFormat = "yyyy-MMM-ddd";
            this.dateTimePayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePayment.Location = new System.Drawing.Point(726, 497);
            this.dateTimePayment.Name = "dateTimePayment";
            this.dateTimePayment.Size = new System.Drawing.Size(265, 22);
            this.dateTimePayment.TabIndex = 31;
            // 
            // StatusPayment
            // 
            this.StatusPayment.FormattingEnabled = true;
            this.StatusPayment.Items.AddRange(new object[] {
            "Bank",
            "Cash"});
            this.StatusPayment.Location = new System.Drawing.Point(726, 613);
            this.StatusPayment.Name = "StatusPayment";
            this.StatusPayment.Size = new System.Drawing.Size(265, 24);
            this.StatusPayment.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 620);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Amount Paid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Payment Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Booking ID:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(253, 617);
            this.txtAmountPaid.Multiline = true;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(268, 31);
            this.txtAmountPaid.TabIndex = 24;
            // 
            // txtPaymentBookingId
            // 
            this.txtPaymentBookingId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentBookingId.Location = new System.Drawing.Point(253, 497);
            this.txtPaymentBookingId.Multiline = true;
            this.txtPaymentBookingId.Name = "txtPaymentBookingId";
            this.txtPaymentBookingId.Size = new System.Drawing.Size(269, 31);
            this.txtPaymentBookingId.TabIndex = 25;
            // 
            // btnClearPayment
            // 
            this.btnClearPayment.BackColor = System.Drawing.Color.Red;
            this.btnClearPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPayment.ForeColor = System.Drawing.Color.White;
            this.btnClearPayment.Location = new System.Drawing.Point(790, 738);
            this.btnClearPayment.Name = "btnClearPayment";
            this.btnClearPayment.Size = new System.Drawing.Size(158, 39);
            this.btnClearPayment.TabIndex = 21;
            this.btnClearPayment.Text = "Clear";
            this.btnClearPayment.UseVisualStyleBackColor = false;
            this.btnClearPayment.Click += new System.EventHandler(this.btnClearPayment_Click);
            // 
            // UpdatePayment
            // 
            this.UpdatePayment.BackColor = System.Drawing.Color.Teal;
            this.UpdatePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePayment.ForeColor = System.Drawing.Color.White;
            this.UpdatePayment.Location = new System.Drawing.Point(599, 738);
            this.UpdatePayment.Name = "UpdatePayment";
            this.UpdatePayment.Size = new System.Drawing.Size(158, 39);
            this.UpdatePayment.TabIndex = 22;
            this.UpdatePayment.Text = "Update Payment";
            this.UpdatePayment.UseVisualStyleBackColor = false;
            this.UpdatePayment.Click += new System.EventHandler(this.UpdatePayment_Click);
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.Navy;
            this.btnSavePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.Location = new System.Drawing.Point(412, 738);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(158, 39);
            this.btnSavePayment.TabIndex = 23;
            this.btnSavePayment.Text = "Payment";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // dataGridPayment
            // 
            this.dataGridPayment.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayment.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridPayment.Location = new System.Drawing.Point(79, 130);
            this.dataGridPayment.Name = "dataGridPayment";
            this.dataGridPayment.RowHeadersWidth = 51;
            this.dataGridPayment.RowTemplate.Height = 24;
            this.dataGridPayment.Size = new System.Drawing.Size(904, 287);
            this.dataGridPayment.TabIndex = 20;
            this.dataGridPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPayment_CellClick);
            this.dataGridPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPayment_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1035, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ViewPayment
            // 
            this.ViewPayment.BackColor = System.Drawing.Color.LimeGreen;
            this.ViewPayment.ForeColor = System.Drawing.Color.White;
            this.ViewPayment.Location = new System.Drawing.Point(180, 738);
            this.ViewPayment.Name = "ViewPayment";
            this.ViewPayment.Size = new System.Drawing.Size(158, 39);
            this.ViewPayment.TabIndex = 33;
            this.ViewPayment.Text = "ViewPayment";
            this.ViewPayment.UseVisualStyleBackColor = false;
            this.ViewPayment.Click += new System.EventHandler(this.ViewPayment_Click);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Payment.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(379, 37);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(367, 34);
            this.Payment.TabIndex = 29;
            this.Payment.Text = "Management Payment Hotel";
            this.Payment.Click += new System.EventHandler(this.label1_Click);
            // 
            // BillInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ViewPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePayment);
            this.Controls.Add(this.StatusPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.txtPaymentBookingId);
            this.Controls.Add(this.btnClearPayment);
            this.Controls.Add(this.UpdatePayment);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.dataGridPayment);
            this.Name = "BillInvoice";
            this.Size = new System.Drawing.Size(1070, 823);
            this.Load += new System.EventHandler(this.BillInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePayment;
        private System.Windows.Forms.ComboBox StatusPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtPaymentBookingId;
        private System.Windows.Forms.Button btnClearPayment;
        private System.Windows.Forms.Button UpdatePayment;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.DataGridView dataGridPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ViewPayment;
        private System.Windows.Forms.Label Payment;
    }
}
