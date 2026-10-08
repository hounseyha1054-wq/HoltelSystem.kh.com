namespace Hotel_Management_System
{
    partial class Staff
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
            this.statusStaff = new System.Windows.Forms.ComboBox();
            this.txtStaffgender = new System.Windows.Forms.ComboBox();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.DeleteStaff = new System.Windows.Forms.Button();
            this.UpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtEmailStaff = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtRoleStaff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStaff
            // 
            this.statusStaff.FormattingEnabled = true;
            this.statusStaff.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "onLeave"});
            this.statusStaff.Location = new System.Drawing.Point(696, 623);
            this.statusStaff.Name = "statusStaff";
            this.statusStaff.Size = new System.Drawing.Size(208, 24);
            this.statusStaff.TabIndex = 45;
            // 
            // txtStaffgender
            // 
            this.txtStaffgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffgender.FormattingEnabled = true;
            this.txtStaffgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "other"});
            this.txtStaffgender.Location = new System.Drawing.Point(271, 571);
            this.txtStaffgender.Name = "txtStaffgender";
            this.txtStaffgender.Size = new System.Drawing.Size(246, 33);
            this.txtStaffgender.TabIndex = 44;
            // 
            // btnClearStaff
            // 
            this.btnClearStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearStaff.ForeColor = System.Drawing.Color.White;
            this.btnClearStaff.Location = new System.Drawing.Point(766, 715);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(158, 39);
            this.btnClearStaff.TabIndex = 40;
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.UseVisualStyleBackColor = false;
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteStaff.ForeColor = System.Drawing.Color.White;
            this.DeleteStaff.Location = new System.Drawing.Point(570, 715);
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.Size = new System.Drawing.Size(158, 39);
            this.DeleteStaff.TabIndex = 41;
            this.DeleteStaff.Text = "Delete Staff";
            this.DeleteStaff.UseVisualStyleBackColor = false;
            this.DeleteStaff.Click += new System.EventHandler(this.DeleteStaff_Click);
            // 
            // UpdateStaff
            // 
            this.UpdateStaff.BackColor = System.Drawing.Color.Yellow;
            this.UpdateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateStaff.ForeColor = System.Drawing.Color.Black;
            this.UpdateStaff.Location = new System.Drawing.Point(359, 715);
            this.UpdateStaff.Name = "UpdateStaff";
            this.UpdateStaff.Size = new System.Drawing.Size(158, 39);
            this.UpdateStaff.TabIndex = 42;
            this.UpdateStaff.Text = "Update Staff";
            this.UpdateStaff.UseVisualStyleBackColor = false;
            this.UpdateStaff.Click += new System.EventHandler(this.UpdateStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Blue;
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(144, 715);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(158, 39);
            this.btnAddStaff.TabIndex = 43;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtEmailStaff
            // 
            this.txtEmailStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailStaff.Location = new System.Drawing.Point(271, 623);
            this.txtEmailStaff.Multiline = true;
            this.txtEmailStaff.Name = "txtEmailStaff";
            this.txtEmailStaff.Size = new System.Drawing.Size(246, 35);
            this.txtEmailStaff.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(568, 632);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(566, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 28;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(271, 623);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(246, 35);
            this.textBox11.TabIndex = 32;
            // 
            // txtRoleStaff
            // 
            this.txtRoleStaff.Location = new System.Drawing.Point(696, 560);
            this.txtRoleStaff.Multiline = true;
            this.txtRoleStaff.Name = "txtRoleStaff";
            this.txtRoleStaff.Size = new System.Drawing.Size(208, 35);
            this.txtRoleStaff.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Eamil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(566, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender:";
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Location = new System.Drawing.Point(696, 504);
            this.txtAddressStaff.Multiline = true;
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(208, 35);
            this.txtAddressStaff.TabIndex = 35;
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(271, 504);
            this.txtfullname.Multiline = true;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(246, 35);
            this.txtfullname.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Address:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(271, 442);
            this.txtStaffId.Multiline = true;
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(246, 35);
            this.txtStaffId.TabIndex = 37;
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Location = new System.Drawing.Point(696, 442);
            this.txtPhoneStaff.Multiline = true;
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(208, 35);
            this.txtPhoneStaff.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Full Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(271, 442);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 35);
            this.textBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Staff ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Staff Data";
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaff.Location = new System.Drawing.Point(86, 115);
            this.dataGridStaff.Name = "dataGridStaff";
            this.dataGridStaff.RowHeadersWidth = 51;
            this.dataGridStaff.RowTemplate.Height = 24;
            this.dataGridStaff.Size = new System.Drawing.Size(904, 287);
            this.dataGridStaff.TabIndex = 20;
            this.dataGridStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStaff_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1035, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.statusStaff);
            this.Controls.Add(this.txtStaffgender);
            this.Controls.Add(this.btnClearStaff);
            this.Controls.Add(this.DeleteStaff);
            this.Controls.Add(this.UpdateStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtEmailStaff);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.txtRoleStaff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddressStaff);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.txtPhoneStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridStaff);
            this.Name = "Staff";
            this.Size = new System.Drawing.Size(1070, 823);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusStaff;
        private System.Windows.Forms.ComboBox txtStaffgender;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.Button DeleteStaff;
        private System.Windows.Forms.Button UpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtEmailStaff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtRoleStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.Label label12;
    }
}
