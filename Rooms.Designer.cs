namespace Hotel_Management_System
{
    partial class Rooms
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
            this.StatusRoom = new System.Windows.Forms.ComboBox();
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.DeleteRoom = new System.Windows.Forms.Button();
            this.UpdateRoom = new System.Windows.Forms.Button();
            this.Addroom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomIDHotel = new System.Windows.Forms.TextBox();
            this.txtRoomPriceHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtroomtypehotel = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusRoom
            // 
            this.StatusRoom.FormattingEnabled = true;
            this.StatusRoom.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Reserved"});
            this.StatusRoom.Location = new System.Drawing.Point(716, 608);
            this.StatusRoom.Name = "StatusRoom";
            this.StatusRoom.Size = new System.Drawing.Size(265, 24);
            this.StatusRoom.TabIndex = 19;
            this.StatusRoom.SelectedIndexChanged += new System.EventHandler(this.StatusRoom_SelectedIndexChanged);
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridRoom.Location = new System.Drawing.Point(77, 120);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.RowHeadersWidth = 51;
            this.dataGridRoom.RowTemplate.Height = 24;
            this.dataGridRoom.ShowRowErrors = false;
            this.dataGridRoom.Size = new System.Drawing.Size(904, 287);
            this.dataGridRoom.TabIndex = 18;
            this.dataGridRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(780, 735);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 42);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DeleteRoom
            // 
            this.DeleteRoom.BackColor = System.Drawing.Color.LightPink;
            this.DeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteRoom.ForeColor = System.Drawing.Color.White;
            this.DeleteRoom.Location = new System.Drawing.Point(584, 735);
            this.DeleteRoom.Name = "DeleteRoom";
            this.DeleteRoom.Size = new System.Drawing.Size(177, 42);
            this.DeleteRoom.TabIndex = 15;
            this.DeleteRoom.Text = "Delete Room";
            this.DeleteRoom.UseVisualStyleBackColor = false;
            this.DeleteRoom.Click += new System.EventHandler(this.DeleteRoom_Click);
            // 
            // UpdateRoom
            // 
            this.UpdateRoom.BackColor = System.Drawing.Color.Blue;
            this.UpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateRoom.ForeColor = System.Drawing.Color.White;
            this.UpdateRoom.Location = new System.Drawing.Point(373, 735);
            this.UpdateRoom.Name = "UpdateRoom";
            this.UpdateRoom.Size = new System.Drawing.Size(177, 42);
            this.UpdateRoom.TabIndex = 16;
            this.UpdateRoom.Text = "Update Room";
            this.UpdateRoom.UseVisualStyleBackColor = false;
            this.UpdateRoom.Click += new System.EventHandler(this.UpdateRoom_Click);
            // 
            // Addroom
            // 
            this.Addroom.BackColor = System.Drawing.Color.Magenta;
            this.Addroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addroom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addroom.ForeColor = System.Drawing.Color.White;
            this.Addroom.Location = new System.Drawing.Point(158, 735);
            this.Addroom.Name = "Addroom";
            this.Addroom.Size = new System.Drawing.Size(177, 42);
            this.Addroom.TabIndex = 17;
            this.Addroom.Text = "Add Room";
            this.Addroom.UseVisualStyleBackColor = false;
            this.Addroom.Click += new System.EventHandler(this.Addroom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Room Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Room ID:";
            // 
            // txtRoomIDHotel
            // 
            this.txtRoomIDHotel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomIDHotel.Location = new System.Drawing.Point(252, 498);
            this.txtRoomIDHotel.Multiline = true;
            this.txtRoomIDHotel.Name = "txtRoomIDHotel";
            this.txtRoomIDHotel.Size = new System.Drawing.Size(260, 34);
            this.txtRoomIDHotel.TabIndex = 8;
            // 
            // txtRoomPriceHotel
            // 
            this.txtRoomPriceHotel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPriceHotel.Location = new System.Drawing.Point(716, 498);
            this.txtRoomPriceHotel.Multiline = true;
            this.txtRoomPriceHotel.Name = "txtRoomPriceHotel";
            this.txtRoomPriceHotel.Size = new System.Drawing.Size(265, 34);
            this.txtRoomPriceHotel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Detail  Room in  Hotel ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1031, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtroomtypehotel
            // 
            this.txtroomtypehotel.FormattingEnabled = true;
            this.txtroomtypehotel.Items.AddRange(new object[] {
            "VIP",
            "Simple"});
            this.txtroomtypehotel.Location = new System.Drawing.Point(252, 612);
            this.txtroomtypehotel.Name = "txtroomtypehotel";
            this.txtroomtypehotel.Size = new System.Drawing.Size(260, 24);
            this.txtroomtypehotel.TabIndex = 21;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.txtroomtypehotel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusRoom);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DeleteRoom);
            this.Controls.Add(this.UpdateRoom);
            this.Controls.Add(this.Addroom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoomIDHotel);
            this.Controls.Add(this.txtRoomPriceHotel);
            this.Controls.Add(this.label1);
            this.Name = "Rooms";
            this.Size = new System.Drawing.Size(1070, 823);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusRoom;
        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button DeleteRoom;
        private System.Windows.Forms.Button UpdateRoom;
        private System.Windows.Forms.Button Addroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomIDHotel;
        private System.Windows.Forms.TextBox txtRoomPriceHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtroomtypehotel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
