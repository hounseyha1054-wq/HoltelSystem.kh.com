namespace Hotel_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel2 = new System.Windows.Forms.Panel();
            this.register_password = new System.Windows.Forms.CheckBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.register_password);
            this.panel2.Controls.Add(this.btnSignin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(379, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 453);
            this.panel2.TabIndex = 2;
            // 
            // register_password
            // 
            this.register_password.AutoSize = true;
            this.register_password.ForeColor = System.Drawing.Color.White;
            this.register_password.Location = new System.Drawing.Point(191, 273);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(123, 20);
            this.register_password.TabIndex = 5;
            this.register_password.Text = "show Password";
            this.register_password.UseVisualStyleBackColor = true;
            this.register_password.CheckedChanged += new System.EventHandler(this.login_password_CheckedChanged);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.White;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.Black;
            this.btnSignin.Location = new System.Drawing.Point(158, 350);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(140, 34);
            this.btnSignin.TabIndex = 3;
            this.btnSignin.Text = "Signup";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(389, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 209);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(131, 132);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 32);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Your Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 453);
            this.panel1.TabIndex = 4;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(126, 350);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(140, 34);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Signin";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Back Login Your  Account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox register_password;
    }
}