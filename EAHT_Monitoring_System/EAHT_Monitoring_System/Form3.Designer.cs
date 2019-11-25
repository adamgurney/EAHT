namespace EAHT_Monitoring_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.contacts = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.Button();
            this.notifications = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.Label();
            this.staffID = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.staff_Picture = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // contacts
            // 
            this.contacts.AutoSize = true;
            this.contacts.Location = new System.Drawing.Point(26, 517);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(77, 20);
            this.contacts.TabIndex = 22;
            this.contacts.Text = "Contacts:";
            this.contacts.Click += new System.EventHandler(this.contacts_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(250, 193);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 149);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(250, 352);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(150, 149);
            this.database.TabIndex = 19;
            this.database.Text = "Bays";
            this.database.UseVisualStyleBackColor = true;
            // 
            // notifications
            // 
            this.notifications.Location = new System.Drawing.Point(250, 31);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(150, 149);
            this.notifications.TabIndex = 18;
            this.notifications.Text = "Notifications";
            this.notifications.UseVisualStyleBackColor = true;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(26, 460);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(69, 20);
            this.position.TabIndex = 17;
            this.position.Text = "Position:";
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Location = new System.Drawing.Point(26, 406);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(69, 20);
            this.staffID.TabIndex = 16;
            this.staffID.Text = "Staff ID:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(26, 352);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(48, 20);
            this.DOB.TabIndex = 15;
            this.DOB.Text = "DOB:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(26, 305);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(78, 20);
            this.surname.TabIndex = 14;
            this.surname.Text = "Surname:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(26, 257);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 13;
            this.name.Text = "Name:";
            // 
            // staff_Picture
            // 
            this.staff_Picture.Image = ((System.Drawing.Image)(resources.GetObject("staff_Picture.Image")));
            this.staff_Picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("staff_Picture.InitialImage")));
            this.staff_Picture.Location = new System.Drawing.Point(30, 31);
            this.staff_Picture.Name = "staff_Picture";
            this.staff_Picture.Size = new System.Drawing.Size(200, 200);
            this.staff_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staff_Picture.TabIndex = 12;
            this.staff_Picture.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(250, 508);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 39);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1626, 1017);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.database);
            this.Controls.Add(this.notifications);
            this.Controls.Add(this.position);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.staff_Picture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contacts;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button database;
        private System.Windows.Forms.Button notifications;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox staff_Picture;
        private System.Windows.Forms.Button exitButton;
    }
}