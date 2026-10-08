namespace Hotel_Management_System
{
    partial class customers
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
            this.DeleteCustomers = new System.Windows.Forms.Button();
            this.UpdateCustomers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddCustomers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteCustomers
            // 
            this.DeleteCustomers.BackColor = System.Drawing.Color.Yellow;
            this.DeleteCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomers.ForeColor = System.Drawing.Color.Black;
            this.DeleteCustomers.Location = new System.Drawing.Point(589, 749);
            this.DeleteCustomers.Name = "DeleteCustomers";
            this.DeleteCustomers.Size = new System.Drawing.Size(158, 39);
            this.DeleteCustomers.TabIndex = 33;
            this.DeleteCustomers.Text = "Delete Customers";
            this.DeleteCustomers.UseVisualStyleBackColor = false;
            this.DeleteCustomers.Click += new System.EventHandler(this.DeleteCustomers_Click);
            // 
            // UpdateCustomers
            // 
            this.UpdateCustomers.BackColor = System.Drawing.Color.Navy;
            this.UpdateCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomers.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomers.Location = new System.Drawing.Point(381, 749);
            this.UpdateCustomers.Name = "UpdateCustomers";
            this.UpdateCustomers.Size = new System.Drawing.Size(158, 39);
            this.UpdateCustomers.TabIndex = 34;
            this.UpdateCustomers.Text = "Update Customers";
            this.UpdateCustomers.UseVisualStyleBackColor = false;
            this.UpdateCustomers.Click += new System.EventHandler(this.UpdateCustomers_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(789, 749);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 39);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddCustomers
            // 
            this.AddCustomers.BackColor = System.Drawing.Color.Black;
            this.AddCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomers.ForeColor = System.Drawing.Color.White;
            this.AddCustomers.Location = new System.Drawing.Point(180, 749);
            this.AddCustomers.Name = "AddCustomers";
            this.AddCustomers.Size = new System.Drawing.Size(158, 39);
            this.AddCustomers.TabIndex = 32;
            this.AddCustomers.Text = "Add Customers";
            this.AddCustomers.UseVisualStyleBackColor = false;
            this.AddCustomers.Click += new System.EventHandler(this.AddCustomers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Customer_ID:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(239, 533);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(262, 37);
            this.txtFullName.TabIndex = 21;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(238, 438);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(263, 41);
            this.txtCustomerId.TabIndex = 22;
            // 
            // txtCardId
            // 
            this.txtCardId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardId.Location = new System.Drawing.Point(462, 622);
            this.txtCardId.Multiline = true;
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(254, 36);
            this.txtCardId.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(711, 533);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 41);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(711, 438);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(263, 41);
            this.txtPhone.TabIndex = 25;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(99, 107);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersWidth = 51;
            this.dataGridCustomer.RowTemplate.Height = 24;
            this.dataGridCustomer.Size = new System.Drawing.Size(904, 287);
            this.dataGridCustomer.TabIndex = 20;
            this.dataGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellClick);
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Management";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1036, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteCustomers);
            this.Controls.Add(this.UpdateCustomers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.AddCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtCardId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.label1);
            this.Name = "customers";
            this.Size = new System.Drawing.Size(1070, 823);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteCustomers;
        private System.Windows.Forms.Button UpdateCustomers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button AddCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
