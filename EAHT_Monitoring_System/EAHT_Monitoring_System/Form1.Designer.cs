namespace EAHT_Monitoring_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Staff_ID_textbox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_ID_textbox
            // 
            this.Staff_ID_textbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Staff_ID_textbox.ForeColor = System.Drawing.Color.White;
            this.Staff_ID_textbox.Location = new System.Drawing.Point(428, 274);
            this.Staff_ID_textbox.Name = "Staff_ID_textbox";
            this.Staff_ID_textbox.Size = new System.Drawing.Size(350, 26);
            this.Staff_ID_textbox.TabIndex = 0;
            this.Staff_ID_textbox.TextChanged += new System.EventHandler(this.StaffID_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(428, 338);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(350, 26);
            this.Password.TabIndex = 1;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(543, 402);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(122, 37);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "ENTER";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPassword.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.ForgotPassword.Location = new System.Drawing.Point(535, 645);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(138, 20);
            this.ForgotPassword.TabIndex = 6;
            this.ForgotPassword.TabStop = true;
            this.ForgotPassword.Text = "Forgot Password?";
            this.ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Staff_ID_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Monitoring System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Staff_ID_textbox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.LinkLabel ForgotPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

