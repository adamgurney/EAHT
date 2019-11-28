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
            this.searchButton = new System.Windows.Forms.Button();
            this.baysButton = new System.Windows.Forms.Button();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.patientBox = new System.Windows.Forms.PictureBox();
            this.contacts = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.staffID = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.notificationsList = new System.Windows.Forms.ListView();
            this.Notification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchingLabel = new System.Windows.Forms.Label();
            this.patientSearchigBox = new System.Windows.Forms.TextBox();
            this.searchingLabel2 = new System.Windows.Forms.Label();
            this.IDSearchBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.bay1Box = new System.Windows.Forms.GroupBox();
            this.bay1Pay4 = new System.Windows.Forms.Button();
            this.bay1Pay3 = new System.Windows.Forms.Button();
            this.bay1Pay2 = new System.Windows.Forms.Button();
            this.bay1Pay1 = new System.Windows.Forms.Button();
            this.bay2Box = new System.Windows.Forms.GroupBox();
            this.bay2Pay4 = new System.Windows.Forms.Button();
            this.bay2Pay3 = new System.Windows.Forms.Button();
            this.bay2Pay2 = new System.Windows.Forms.Button();
            this.bay2Pay1 = new System.Windows.Forms.Button();
            this.patientDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientSurenameLabel = new System.Windows.Forms.Label();
            this.patientDOBLabel = new System.Windows.Forms.Label();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientContactsLabel = new System.Windows.Forms.Label();
            this.patientDiagnosisLabel = new System.Windows.Forms.Label();
            this.bloodPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bloodPressureLabel = new System.Windows.Forms.Label();
            this.bloodPressureUnit = new System.Windows.Forms.Label();
            this.bloodPressureIntSys = new System.Windows.Forms.Label();
            this.bloodPressureIntDia = new System.Windows.Forms.Label();
            this.temperaturePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tempratureLabel = new System.Windows.Forms.Label();
            this.tempratureInt = new System.Windows.Forms.Label();
            this.pulseRatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pulseRateLabel = new System.Windows.Forms.Label();
            this.pulseRateInt = new System.Windows.Forms.Label();
            this.urinePanel = new System.Windows.Forms.TableLayoutPanel();
            this.urineOutputLabel = new System.Windows.Forms.Label();
            this.urineOutputInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBox)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.bay1Box.SuspendLayout();
            this.bay2Box.SuspendLayout();
            this.patientDetailsTable.SuspendLayout();
            this.bloodPanel.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.pulseRatePanel.SuspendLayout();
            this.urinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.searchButton.Location = new System.Drawing.Point(2, 167);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 161);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // baysButton
            // 
            this.baysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.baysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baysButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.baysButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.baysButton.Location = new System.Drawing.Point(2, 332);
            this.baysButton.Margin = new System.Windows.Forms.Padding(2);
            this.baysButton.Name = "baysButton";
            this.baysButton.Size = new System.Drawing.Size(104, 161);
            this.baysButton.TabIndex = 19;
            this.baysButton.Text = "Bays";
            this.baysButton.UseVisualStyleBackColor = false;
            this.baysButton.Click += new System.EventHandler(this.Database_Click);
            // 
            // notificationsButton
            // 
            this.notificationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.notificationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.notificationsButton.Location = new System.Drawing.Point(2, 2);
            this.notificationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Size = new System.Drawing.Size(104, 161);
            this.notificationsButton.TabIndex = 18;
            this.notificationsButton.Text = "Notifications";
            this.notificationsButton.UseVisualStyleBackColor = false;
            this.notificationsButton.Click += new System.EventHandler(this.Notifications_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.exitButton.Location = new System.Drawing.Point(2, 497);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 162);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // patientBox
            // 
            this.patientBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.patientBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientBox.Location = new System.Drawing.Point(0, 0);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(179, 661);
            this.patientBox.TabIndex = 24;
            this.patientBox.TabStop = false;
            // 
            // contacts
            // 
            this.contacts.AutoSize = true;
            this.contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.contacts.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.contacts.Location = new System.Drawing.Point(11, 275);
            this.contacts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(62, 19);
            this.contacts.TabIndex = 30;
            this.contacts.Text = "Contacts: ";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.position.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.position.Location = new System.Drawing.Point(11, 256);
            this.position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(56, 19);
            this.position.TabIndex = 29;
            this.position.Text = "Position: ";
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.staffID.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.staffID.Location = new System.Drawing.Point(11, 237);
            this.staffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(54, 19);
            this.staffID.TabIndex = 28;
            this.staffID.Text = "Staff ID: ";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DOB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.DOB.Location = new System.Drawing.Point(11, 218);
            this.DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(36, 19);
            this.DOB.TabIndex = 27;
            this.DOB.Text = "DOB: ";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.surname.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.surname.Location = new System.Drawing.Point(11, 199);
            this.surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(64, 19);
            this.surname.TabIndex = 26;
            this.surname.Text = "Surname: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.name.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.name.Location = new System.Drawing.Point(11, 180);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 19);
            this.name.TabIndex = 25;
            this.name.Text = "Name: ";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Controls.Add(this.notificationsButton, 0, 0);
            this.buttonsPanel.Controls.Add(this.searchButton, 0, 1);
            this.buttonsPanel.Controls.Add(this.baysButton, 0, 2);
            this.buttonsPanel.Controls.Add(this.exitButton, 0, 3);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(179, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 4;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(108, 661);
            this.buttonsPanel.TabIndex = 31;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.notificationsLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.notificationsLabel.Location = new System.Drawing.Point(293, 17);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(78, 19);
            this.notificationsLabel.TabIndex = 32;
            this.notificationsLabel.Text = "Notifications:";
            // 
            // notificationsList
            // 
            this.notificationsList.BackColor = System.Drawing.Color.AliceBlue;
            this.notificationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notificationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Notification,
            this.TimeReceived});
            this.notificationsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.notificationsList.HideSelection = false;
            this.notificationsList.Location = new System.Drawing.Point(290, 39);
            this.notificationsList.Name = "notificationsList";
            this.notificationsList.Size = new System.Drawing.Size(782, 287);
            this.notificationsList.TabIndex = 33;
            this.notificationsList.UseCompatibleStateImageBehavior = false;
            this.notificationsList.View = System.Windows.Forms.View.Details;
            // 
            // Notification
            // 
            this.Notification.Text = "Notification";
            this.Notification.Width = 250;
            // 
            // TimeReceived
            // 
            this.TimeReceived.Text = "Time Received";
            this.TimeReceived.Width = 250;
            // 
            // searchingLabel
            // 
            this.searchingLabel.AutoSize = true;
            this.searchingLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchingLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.searchingLabel.Location = new System.Drawing.Point(595, 226);
            this.searchingLabel.Name = "searchingLabel";
            this.searchingLabel.Size = new System.Drawing.Size(209, 25);
            this.searchingLabel.TabIndex = 32;
            this.searchingLabel.Text = "Please enter patient\'s name";
            // 
            // patientSearchigBox
            // 
            this.patientSearchigBox.Location = new System.Drawing.Point(446, 256);
            this.patientSearchigBox.Name = "patientSearchigBox";
            this.patientSearchigBox.Size = new System.Drawing.Size(480, 20);
            this.patientSearchigBox.TabIndex = 33;
            // 
            // searchingLabel2
            // 
            this.searchingLabel2.AutoSize = true;
            this.searchingLabel2.BackColor = System.Drawing.Color.Transparent;
            this.searchingLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchingLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.searchingLabel2.Location = new System.Drawing.Point(614, 287);
            this.searchingLabel2.Name = "searchingLabel2";
            this.searchingLabel2.Size = new System.Drawing.Size(167, 25);
            this.searchingLabel2.TabIndex = 34;
            this.searchingLabel2.Text = "or enter the Patient ID";
            // 
            // IDSearchBox
            // 
            this.IDSearchBox.Location = new System.Drawing.Point(542, 315);
            this.IDSearchBox.Name = "IDSearchBox";
            this.IDSearchBox.Size = new System.Drawing.Size(300, 20);
            this.IDSearchBox.TabIndex = 35;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.findButton.Location = new System.Drawing.Point(619, 349);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(159, 45);
            this.findButton.TabIndex = 36;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // bay1Box
            // 
            this.bay1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay1Box.Controls.Add(this.bay1Pay4);
            this.bay1Box.Controls.Add(this.bay1Pay3);
            this.bay1Box.Controls.Add(this.bay1Pay2);
            this.bay1Box.Controls.Add(this.bay1Pay1);
            this.bay1Box.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bay1Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay1Box.Location = new System.Drawing.Point(320, 24);
            this.bay1Box.Name = "bay1Box";
            this.bay1Box.Size = new System.Drawing.Size(252, 124);
            this.bay1Box.TabIndex = 32;
            this.bay1Box.TabStop = false;
            this.bay1Box.Text = "Bay 1";

            // 
            // bay1Pay4
            // 
            this.bay1Pay4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay1Pay4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay1Pay4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay1Pay4.Location = new System.Drawing.Point(130, 67);
            this.bay1Pay4.Name = "bay1Pay4";
            this.bay1Pay4.Size = new System.Drawing.Size(104, 37);
            this.bay1Pay4.TabIndex = 3;
            this.bay1Pay4.Text = "Patient 4";
            this.bay1Pay4.UseVisualStyleBackColor = false;
            this.bay1Pay4.Click += new System.EventHandler(this.Bay1Pay4_Click);
            // 
            // bay1Pay3
            // 
            this.bay1Pay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay1Pay3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay1Pay3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay1Pay3.Location = new System.Drawing.Point(14, 67);
            this.bay1Pay3.Name = "bay1Pay3";
            this.bay1Pay3.Size = new System.Drawing.Size(110, 37);
            this.bay1Pay3.TabIndex = 2;
            this.bay1Pay3.Text = "Patient 3";
            this.bay1Pay3.UseVisualStyleBackColor = false;
            this.bay1Pay3.Click += new System.EventHandler(this.Bay1Pay3_Click);

            // 
            // bay1Pay2
            // 
            this.bay1Pay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay1Pay2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay1Pay2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay1Pay2.Location = new System.Drawing.Point(130, 29);
            this.bay1Pay2.Name = "bay1Pay2";
            this.bay1Pay2.Size = new System.Drawing.Size(104, 32);
            this.bay1Pay2.TabIndex = 1;
            this.bay1Pay2.Text = "Patient 2";
            this.bay1Pay2.UseVisualStyleBackColor = false;
            this.bay1Pay2.Click += new System.EventHandler(this.Bay1Pay2_Click);
            // 
            // bay1Pay1
            // 
            this.bay1Pay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay1Pay1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay1Pay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay1Pay1.Location = new System.Drawing.Point(14, 29);
            this.bay1Pay1.Name = "bay1Pay1";
            this.bay1Pay1.Size = new System.Drawing.Size(110, 32);
            this.bay1Pay1.TabIndex = 0;
            this.bay1Pay1.Text = "Patient 1";
            this.bay1Pay1.UseVisualStyleBackColor = false;
            this.bay1Pay1.Click += new System.EventHandler(this.Bay1Pay1_Click_1);
            // 
            // bay2Box
            // 
            this.bay2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay2Box.Controls.Add(this.bay2Pay4);
            this.bay2Box.Controls.Add(this.bay2Pay3);
            this.bay2Box.Controls.Add(this.bay2Pay2);
            this.bay2Box.Controls.Add(this.bay2Pay1);
            this.bay2Box.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bay2Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay2Box.Location = new System.Drawing.Point(578, 24);
            this.bay2Box.Name = "bay2Box";
            this.bay2Box.Size = new System.Drawing.Size(252, 124);
            this.bay2Box.TabIndex = 33;
            this.bay2Box.TabStop = false;
            this.bay2Box.Text = "Bay 2";
            // 
            // bay2Pay4
            // 
            this.bay2Pay4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay2Pay4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay2Pay4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay2Pay4.Location = new System.Drawing.Point(132, 68);
            this.bay2Pay4.Name = "bay2Pay4";
            this.bay2Pay4.Size = new System.Drawing.Size(105, 36);
            this.bay2Pay4.TabIndex = 3;
            this.bay2Pay4.Text = "Patient 4";
            this.bay2Pay4.UseVisualStyleBackColor = false;
            this.bay2Pay4.Click += new System.EventHandler(this.Bay2Pay4_Click);
            // 
            // bay2Pay3
            // 
            this.bay2Pay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay2Pay3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay2Pay3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay2Pay3.Location = new System.Drawing.Point(12, 68);
            this.bay2Pay3.Name = "bay2Pay3";
            this.bay2Pay3.Size = new System.Drawing.Size(114, 37);
            this.bay2Pay3.TabIndex = 2;
            this.bay2Pay3.Text = "Patient 3";
            this.bay2Pay3.UseVisualStyleBackColor = false;
            this.bay2Pay3.Click += new System.EventHandler(this.Bay2Pay3_Click);

            // 
            // bay2Pay2
            // 
            this.bay2Pay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay2Pay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bay2Pay2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay2Pay2.Location = new System.Drawing.Point(132, 29);
            this.bay2Pay2.Name = "bay2Pay2";
            this.bay2Pay2.Size = new System.Drawing.Size(105, 32);
            this.bay2Pay2.TabIndex = 1;
            this.bay2Pay2.Text = "Patient 2";
            this.bay2Pay2.UseVisualStyleBackColor = false;
            this.bay2Pay2.Click += new System.EventHandler(this.Bay2Pay2_Click);

            // 
            // bay2Pay1
            // 
            this.bay2Pay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bay2Pay1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bay2Pay1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bay2Pay1.Location = new System.Drawing.Point(12, 29);
            this.bay2Pay1.Name = "bay2Pay1";
            this.bay2Pay1.Size = new System.Drawing.Size(114, 32);
            this.bay2Pay1.TabIndex = 0;
            this.bay2Pay1.Text = "Patient 1";
            this.bay2Pay1.UseVisualStyleBackColor = false;
            this.bay2Pay1.Click += new System.EventHandler(this.Bay2Pay1_Click);

            // 
            // patientDetailsTable
            // 
            this.patientDetailsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.patientDetailsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.patientDetailsTable.ColumnCount = 1;
            this.patientDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.patientDetailsTable.Controls.Add(this.patientNameLabel, 0, 1);
            this.patientDetailsTable.Controls.Add(this.patientSurenameLabel, 0, 2);
            this.patientDetailsTable.Controls.Add(this.patientDOBLabel, 0, 3);
            this.patientDetailsTable.Controls.Add(this.patientIDLabel, 0, 4);
            this.patientDetailsTable.Controls.Add(this.patientContactsLabel, 0, 6);
            this.patientDetailsTable.Controls.Add(this.patientDiagnosisLabel, 0, 5);
            this.patientDetailsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.patientDetailsTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientDetailsTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.patientDetailsTable.Location = new System.Drawing.Point(858, 0);
            this.patientDetailsTable.Name = "patientDetailsTable";
            this.patientDetailsTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.patientDetailsTable.RowCount = 7;
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.18182F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.787879F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.242424F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.636364F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.939394F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.939394F));
            this.patientDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879F));
            this.patientDetailsTable.Size = new System.Drawing.Size(226, 661);
            this.patientDetailsTable.TabIndex = 70;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.patientNameLabel.Location = new System.Drawing.Point(3, 282);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(85, 23);
            this.patientNameLabel.TabIndex = 63;
            this.patientNameLabel.Text = "First Name: ";
            // 
            // patientSurenameLabel
            // 
            this.patientSurenameLabel.AutoSize = true;
            this.patientSurenameLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientSurenameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSurenameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientSurenameLabel.Location = new System.Drawing.Point(3, 307);
            this.patientSurenameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientSurenameLabel.Name = "patientSurenameLabel";
            this.patientSurenameLabel.Size = new System.Drawing.Size(74, 23);
            this.patientSurenameLabel.TabIndex = 64;
            this.patientSurenameLabel.Text = "Surname: ";
            // 
            // patientDOBLabel
            // 
            this.patientDOBLabel.AutoSize = true;
            this.patientDOBLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientDOBLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDOBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientDOBLabel.Location = new System.Drawing.Point(3, 335);
            this.patientDOBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientDOBLabel.Name = "patientDOBLabel";
            this.patientDOBLabel.Size = new System.Drawing.Size(42, 23);
            this.patientDOBLabel.TabIndex = 65;
            this.patientDOBLabel.Text = "DOB: ";
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientIDLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientIDLabel.Location = new System.Drawing.Point(3, 359);
            this.patientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(77, 23);
            this.patientIDLabel.TabIndex = 66;
            this.patientIDLabel.Text = "Patient ID: ";
            // 
            // patientContactsLabel
            // 
            this.patientContactsLabel.AutoSize = true;
            this.patientContactsLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientContactsLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientContactsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientContactsLabel.Location = new System.Drawing.Point(3, 411);
            this.patientContactsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientContactsLabel.Name = "patientContactsLabel";
            this.patientContactsLabel.Size = new System.Drawing.Size(72, 23);
            this.patientContactsLabel.TabIndex = 68;
            this.patientContactsLabel.Text = "Contacts: ";
            // 
            // patientDiagnosisLabel
            // 
            this.patientDiagnosisLabel.AutoSize = true;
            this.patientDiagnosisLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientDiagnosisLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDiagnosisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.patientDiagnosisLabel.Location = new System.Drawing.Point(3, 385);
            this.patientDiagnosisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientDiagnosisLabel.Name = "patientDiagnosisLabel";
            this.patientDiagnosisLabel.Size = new System.Drawing.Size(78, 23);
            this.patientDiagnosisLabel.TabIndex = 67;
            this.patientDiagnosisLabel.Text = "Diagnosis: ";
            // 
            // bloodPanel
            // 
            this.bloodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bloodPanel.ColumnCount = 2;
            this.bloodPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bloodPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bloodPanel.Controls.Add(this.bloodPressureLabel, 0, 0);
            this.bloodPanel.Controls.Add(this.bloodPressureUnit, 1, 0);
            this.bloodPanel.Controls.Add(this.bloodPressureIntSys, 0, 1);
            this.bloodPanel.Controls.Add(this.bloodPressureIntDia, 1, 1);
            this.bloodPanel.Location = new System.Drawing.Point(320, 151);
            this.bloodPanel.Name = "bloodPanel";
            this.bloodPanel.RowCount = 2;
            this.bloodPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bloodPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bloodPanel.Size = new System.Drawing.Size(251, 128);
            this.bloodPanel.TabIndex = 75;
            // 
            // bloodPressureLabel
            // 
            this.bloodPressureLabel.AutoSize = true;
            this.bloodPressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.bloodPressureLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bloodPressureLabel.Location = new System.Drawing.Point(2, 0);
            this.bloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodPressureLabel.Name = "bloodPressureLabel";
            this.bloodPressureLabel.Size = new System.Drawing.Size(104, 23);
            this.bloodPressureLabel.TabIndex = 50;
            this.bloodPressureLabel.Text = "Blood Pressure";
            // 
            // bloodPressureUnit
            // 
            this.bloodPressureUnit.AutoSize = true;
            this.bloodPressureUnit.BackColor = System.Drawing.Color.Transparent;
            this.bloodPressureUnit.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bloodPressureUnit.Location = new System.Drawing.Point(128, 0);
            this.bloodPressureUnit.Name = "bloodPressureUnit";
            this.bloodPressureUnit.Size = new System.Drawing.Size(72, 33);
            this.bloodPressureUnit.TabIndex = 73;
            this.bloodPressureUnit.Text = "mmHG";
            // 
            // bloodPressureIntSys
            // 
            this.bloodPressureIntSys.AutoSize = true;
            this.bloodPressureIntSys.BackColor = System.Drawing.Color.Transparent;
            this.bloodPressureIntSys.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureIntSys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bloodPressureIntSys.Location = new System.Drawing.Point(2, 64);
            this.bloodPressureIntSys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodPressureIntSys.Name = "bloodPressureIntSys";
            this.bloodPressureIntSys.Size = new System.Drawing.Size(51, 39);
            this.bloodPressureIntSys.TabIndex = 58;
            this.bloodPressureIntSys.Text = "100";
            // 
            // bloodPressureIntDia
            // 
            this.bloodPressureIntDia.AutoSize = true;
            this.bloodPressureIntDia.BackColor = System.Drawing.Color.Transparent;
            this.bloodPressureIntDia.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureIntDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.bloodPressureIntDia.Location = new System.Drawing.Point(127, 64);
            this.bloodPressureIntDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodPressureIntDia.Name = "bloodPressureIntDia";
            this.bloodPressureIntDia.Size = new System.Drawing.Size(56, 42);
            this.bloodPressureIntDia.TabIndex = 72;
            this.bloodPressureIntDia.Text = "100";
            // 
            // temperaturePanel
            // 
            this.temperaturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.temperaturePanel.ColumnCount = 1;
            this.temperaturePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.temperaturePanel.Controls.Add(this.tempratureLabel, 0, 0);
            this.temperaturePanel.Controls.Add(this.tempratureInt, 0, 1);
            this.temperaturePanel.Location = new System.Drawing.Point(577, 151);
            this.temperaturePanel.Name = "temperaturePanel";
            this.temperaturePanel.RowCount = 2;
            this.temperaturePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.temperaturePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.temperaturePanel.Size = new System.Drawing.Size(251, 128);
            this.temperaturePanel.TabIndex = 77;
            // 
            // tempratureLabel
            // 
            this.tempratureLabel.AutoSize = true;
            this.tempratureLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempratureLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempratureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.tempratureLabel.Location = new System.Drawing.Point(2, 0);
            this.tempratureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempratureLabel.Name = "tempratureLabel";
            this.tempratureLabel.Size = new System.Drawing.Size(93, 25);
            this.tempratureLabel.TabIndex = 51;
            this.tempratureLabel.Text = "Temprature";
            // 
            // tempratureInt
            // 
            this.tempratureInt.AutoSize = true;
            this.tempratureInt.BackColor = System.Drawing.Color.Transparent;
            this.tempratureInt.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempratureInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.tempratureInt.Location = new System.Drawing.Point(2, 64);
            this.tempratureInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempratureInt.Name = "tempratureInt";
            this.tempratureInt.Size = new System.Drawing.Size(121, 35);
            this.tempratureInt.TabIndex = 59;
            this.tempratureInt.Text = "37 Degrees";
            // 
            // pulseRatePanel
            // 
            this.pulseRatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.pulseRatePanel.ColumnCount = 1;
            this.pulseRatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pulseRatePanel.Controls.Add(this.pulseRateLabel, 0, 0);
            this.pulseRatePanel.Controls.Add(this.pulseRateInt, 0, 1);
            this.pulseRatePanel.Location = new System.Drawing.Point(321, 282);
            this.pulseRatePanel.Name = "pulseRatePanel";
            this.pulseRatePanel.RowCount = 2;
            this.pulseRatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pulseRatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pulseRatePanel.Size = new System.Drawing.Size(251, 128);
            this.pulseRatePanel.TabIndex = 78;
            // 
            // pulseRateLabel
            // 
            this.pulseRateLabel.AutoSize = true;
            this.pulseRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.pulseRateLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.pulseRateLabel.Location = new System.Drawing.Point(2, 0);
            this.pulseRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseRateLabel.Name = "pulseRateLabel";
            this.pulseRateLabel.Size = new System.Drawing.Size(110, 33);
            this.pulseRateLabel.TabIndex = 48;
            this.pulseRateLabel.Text = "Pulse Rate";
            // 
            // pulseRateInt
            // 
            this.pulseRateInt.AutoSize = true;
            this.pulseRateInt.BackColor = System.Drawing.Color.Transparent;
            this.pulseRateInt.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseRateInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.pulseRateInt.Location = new System.Drawing.Point(2, 64);
            this.pulseRateInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseRateInt.Name = "pulseRateInt";
            this.pulseRateInt.Size = new System.Drawing.Size(93, 39);
            this.pulseRateInt.TabIndex = 60;
            this.pulseRateInt.Text = "70 BPM";
            // 
            // urinePanel
            // 
            this.urinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.urinePanel.ColumnCount = 1;
            this.urinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.urinePanel.Controls.Add(this.urineOutputLabel, 0, 0);
            this.urinePanel.Controls.Add(this.urineOutputInt, 0, 1);
            this.urinePanel.Location = new System.Drawing.Point(577, 282);
            this.urinePanel.Name = "urinePanel";
            this.urinePanel.RowCount = 2;
            this.urinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.urinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.urinePanel.Size = new System.Drawing.Size(251, 128);
            this.urinePanel.TabIndex = 79;
            // 
            // urineOutputLabel
            // 
            this.urineOutputLabel.AutoSize = true;
            this.urineOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.urineOutputLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urineOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.urineOutputLabel.Location = new System.Drawing.Point(2, 0);
            this.urineOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urineOutputLabel.Name = "urineOutputLabel";
            this.urineOutputLabel.Size = new System.Drawing.Size(125, 33);
            this.urineOutputLabel.TabIndex = 49;
            this.urineOutputLabel.Text = "Urine Output";
            // 
            // urineOutputInt
            // 
            this.urineOutputInt.AutoSize = true;
            this.urineOutputInt.BackColor = System.Drawing.Color.Transparent;
            this.urineOutputInt.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urineOutputInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.urineOutputInt.Location = new System.Drawing.Point(2, 64);
            this.urineOutputInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urineOutputInt.Name = "urineOutputInt";
            this.urineOutputInt.Size = new System.Drawing.Size(84, 39);
            this.urineOutputInt.TabIndex = 61;
            this.urineOutputInt.Text = "100 ml";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.position);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.patientBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBox)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.bay1Box.ResumeLayout(false);
            this.bay2Box.ResumeLayout(false);
            this.patientDetailsTable.ResumeLayout(false);
            this.patientDetailsTable.PerformLayout();
            this.bloodPanel.ResumeLayout(false);
            this.bloodPanel.PerformLayout();
            this.temperaturePanel.ResumeLayout(false);
            this.temperaturePanel.PerformLayout();
            this.pulseRatePanel.ResumeLayout(false);
            this.pulseRatePanel.PerformLayout();
            this.urinePanel.ResumeLayout(false);
            this.urinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button baysButton;
        private System.Windows.Forms.Button notificationsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox patientBox;
        private System.Windows.Forms.Label contacts;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.ListView notificationsList;
        private System.Windows.Forms.ColumnHeader Notification;
        private System.Windows.Forms.ColumnHeader TimeReceived;
        private System.Windows.Forms.Label searchingLabel;
        private System.Windows.Forms.TextBox patientSearchigBox;
        private System.Windows.Forms.Label searchingLabel2;
        private System.Windows.Forms.TextBox IDSearchBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox bay1Box;
        private System.Windows.Forms.Button bay1Pay4;
        private System.Windows.Forms.Button bay1Pay3;
        private System.Windows.Forms.Button bay1Pay2;
        private System.Windows.Forms.Button bay1Pay1;
        private System.Windows.Forms.GroupBox bay2Box;
        private System.Windows.Forms.Button bay2Pay4;
        private System.Windows.Forms.Button bay2Pay3;
        private System.Windows.Forms.Button bay2Pay2;
        private System.Windows.Forms.Button bay2Pay1;
        private System.Windows.Forms.TableLayoutPanel patientDetailsTable;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientSurenameLabel;
        private System.Windows.Forms.Label patientDOBLabel;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label patientContactsLabel;
        private System.Windows.Forms.Label patientDiagnosisLabel;
        private System.Windows.Forms.TableLayoutPanel bloodPanel;
        private System.Windows.Forms.Label bloodPressureLabel;
        private System.Windows.Forms.Label bloodPressureUnit;
        private System.Windows.Forms.Label bloodPressureIntSys;
        private System.Windows.Forms.Label bloodPressureIntDia;
        private System.Windows.Forms.TableLayoutPanel temperaturePanel;
        private System.Windows.Forms.Label tempratureLabel;
        private System.Windows.Forms.Label tempratureInt;
        private System.Windows.Forms.TableLayoutPanel pulseRatePanel;
        private System.Windows.Forms.Label pulseRateLabel;
        private System.Windows.Forms.Label pulseRateInt;
        private System.Windows.Forms.TableLayoutPanel urinePanel;
        private System.Windows.Forms.Label urineOutputLabel;
        private System.Windows.Forms.Label urineOutputInt;
    }
}