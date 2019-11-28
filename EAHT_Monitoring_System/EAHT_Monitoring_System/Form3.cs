using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EAHT_Monitoring_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void contacts_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DeregisterShift();
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void DeregisterShift()
        {
            //Properties.Settings.Default.DBConnStr
            using (SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;"))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE shiftsDatabase SET timeDeregistered=@timeDeregistered Where MedicID IS NOT NULL AND timeDeregistered IS NULL";
                    command.Parameters.AddWithValue("@timeDeregistered", DateTime.Now);

                    try
                    {
                        Conn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Shift is't deregistered + **" + e.Message + "**");
                    }
                    finally
                    {
                        Conn.Close();
                    }
                }
            }
        }

        public void updateMedicsDetails(int medicsIDSQL)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From medicsDatabase where MedicID='" + medicsIDSQL + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            name.Text = "Name: " + dt.Rows[0][1].ToString();
            surname.Text = "Surname: " + dt.Rows[0][2].ToString();
            DOB.Text = "DOB: " + dt.Rows[0][4].ToString();
            staffID.Text = "Staff ID: " + dt.Rows[0][0].ToString();
            position.Text = "Position: " + dt.Rows[0][5].ToString();
            contacts.Text = "Contacts: " + dt.Rows[0][6].ToString();


        }

        private void Notifications_Click(object sender, EventArgs e)
        {
            addNotificationsPage();
            removeSearchPage();
            removeBaySysytem();

            this.Controls.Remove(this.bay2Box);
            this.Controls.Remove(this.bay1Box);

        }


        private void Search_Click(object sender, EventArgs e)
        {
            addSearchPage();
            removeNotificationPage();
            removeBaySysytem();

            this.Controls.Remove(this.bay2Box);
            this.Controls.Remove(this.bay1Box);
        }

        private void Database_Click(object sender, EventArgs e)
        {

            this.Controls.Add(this.bay2Box);
            this.Controls.Add(this.bay1Box);

            removeNotificationPage();
            removeSearchPage();
        }

        private void addSearchPage()
        {
            this.Controls.Add(this.IDSearchBox);
            this.Controls.Add(this.searchingLabel2);
            this.Controls.Add(this.patientSearchigBox);
            this.Controls.Add(this.searchingLabel);
            this.Controls.Add(this.findButton);
        }

        public void removeBaySysytem()
        {
            this.Controls.Remove(this.urinePanel);
            this.Controls.Remove(this.temperaturePanel);
            this.Controls.Remove(this.pulseRatePanel);
            this.Controls.Remove(this.bloodPanel);
            this.Controls.Remove(this.patientDetailsTable);
        }

        private void removeSearchPage()
        {
            this.Controls.Remove(this.IDSearchBox);
            this.Controls.Remove(this.searchingLabel);
            this.Controls.Remove(this.patientSearchigBox);
            this.Controls.Remove(this.searchingLabel2);
            this.Controls.Remove(this.findButton);
        }

        private void addNotificationsPage()
        {
            this.Controls.Add(this.notificationsList);
            this.Controls.Add(this.notificationsLabel);
        }

        private void removeNotificationPage()
        {
            this.Controls.Remove(this.notificationsList);
            this.Controls.Remove(this.notificationsLabel);
        }

        public void addBaySystem()
        {
            this.Controls.Add(this.urinePanel);
            this.Controls.Add(this.temperaturePanel);
            this.Controls.Add(this.pulseRatePanel);
            this.Controls.Add(this.bloodPanel);
            this.Controls.Add(this.patientDetailsTable);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From patientDatabase where PatientID='" + IDSearchBox.Text + "' Or [First Name]='" + patientSearchigBox.Text + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("Select * From patientDatabase where PatientID='" + IDSearchBox.Text + "' Or [First Name]='" + patientSearchigBox.Text + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                MessageBox.Show("Patient ID: " + dt2.Rows[0][0].ToString() + "\n" +
                    "First Name: " + dt2.Rows[0][1].ToString() + "\n" +
                    "Last Name: " + dt2.Rows[0][2].ToString() + "\n" +
                    "Bay No: " + dt2.Rows[0][11].ToString() + "\n" +
                    "Patient No " + dt2.Rows[0][12].ToString() + "\n" +
                    "DOB: " + dt2.Rows[0][8].ToString() + "\n" +
                    "Diagnosis: " + dt2.Rows[0][9].ToString());
            }

            else
            {
                MessageBox.Show("Please check patient details");
            }
        }

        private void updateDetails(int bayNum)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From patientDatabase where PatientID='" + bayNum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            patientIDLabel.Text = "Patient ID: " + dt.Rows[0][0].ToString();
            patientNameLabel.Text = "First Name: " + dt.Rows[0][1].ToString();
            patientSurenameLabel.Text = "Surename: " + dt.Rows[0][2].ToString();
            pulseRateInt.Text = dt.Rows[0][3].ToString() + " BPM";
            bloodPressureIntSys.Text = dt.Rows[0][4].ToString();
            bloodPressureIntDia.Text = dt.Rows[0][5].ToString();
            tempratureInt.Text = dt.Rows[0][6].ToString() + " Degrees";
            urineOutputInt.Text = dt.Rows[0][7].ToString() + " ml";
            patientDOBLabel.Text = "DOB: " + dt.Rows[0][8].ToString();
            patientDiagnosisLabel.Text = "Diagnosis: " + dt.Rows[0][9].ToString();
            patientContactsLabel.Text = "Contact Details: " + dt.Rows[0][10].ToString();
        }

        private void Bay1Pay1_Click_1(object sender, EventArgs e)
        {
            updateDetails(1);
            addBaySystem();
        }

        private void Bay1Pay2_Click(object sender, EventArgs e)
        {
            updateDetails(2);
            addBaySystem();
        }

        private void Bay1Pay3_Click(object sender, EventArgs e)
        {
            updateDetails(3);
            addBaySystem();
        }

        private void Bay1Pay4_Click(object sender, EventArgs e)
        {
            updateDetails(4);
            addBaySystem();
        }

        private void Bay2Pay1_Click(object sender, EventArgs e)
        {
            updateDetails(5);
            addBaySystem();
        }

        private void Bay2Pay2_Click(object sender, EventArgs e)
        {
            updateDetails(6);
            addBaySystem();
        }

        private void Bay2Pay3_Click(object sender, EventArgs e)
        {
            updateDetails(7);
            addBaySystem();
        }

        private void Bay2Pay4_Click(object sender, EventArgs e)
        {
            updateDetails(8);
            addBaySystem();
        }
    }
}
