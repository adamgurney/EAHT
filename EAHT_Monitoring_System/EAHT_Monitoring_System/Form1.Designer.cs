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
            this.staffIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_ID_textbox
            // 
            this.Staff_ID_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.Staff_ID_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staff_ID_textbox.ForeColor = System.Drawing.Color.White;
            this.Staff_ID_textbox.Location = new System.Drawing.Point(285, 189);
            this.Staff_ID_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Staff_ID_textbox.Name = "Staff_ID_textbox";
            this.Staff_ID_textbox.Size = new System.Drawing.Size(235, 13);
            this.Staff_ID_textbox.TabIndex = 0;
            this.Staff_ID_textbox.TextChanged += new System.EventHandler(this.StaffID_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(284, 229);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(235, 13);
            this.Password.TabIndex = 1;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(362, 261);
            this.SignIn.Margin = new System.Windows.Forms.Padding(2);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(81, 24);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "ENTER";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.ForgotPassword.Location = new System.Drawing.Point(359, 415);
            this.ForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(78, 14);
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
            this.pictureBox1.Location = new System.Drawing.Point(232, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // staffIdLabel
            // 
            this.staffIdLabel.AutoSize = true;
            this.staffIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.staffIdLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.staffIdLabel.Location = new System.Drawing.Point(281, 169);
            this.staffIdLabel.Name = "staffIdLabel";
            this.staffIdLabel.Size = new System.Drawing.Size(44, 18);
            this.staffIdLabel.TabIndex = 8;
            this.staffIdLabel.Text = "Staff ID";
            this.staffIdLabel.Click += new System.EventHandler(this.StaffIdLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.passwordLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLabel.Location = new System.Drawing.Point(281, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 18);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox2.Location = new System.Drawing.Point(284, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 1);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox3.Location = new System.Drawing.Point(284, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 1);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 549);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.staffIdLabel);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Staff_ID_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Monitoring System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label staffIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

