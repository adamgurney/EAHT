using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAHT_Monitoring_System
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        //"Bays" button
        private void bays_Click(object sender, EventArgs e)
        {
            //Removes all the windows of the Database Page
            removeDatabasePage();
            //Removes all the windows of the Search Page
            removeSearchPage();

            this.Controls.Add(this.bay2Box);
            this.Controls.Add(this.bay1Box);

            //Removes Bays Page
            removeBaySysytem();
        }

        //"Search" button
        private void Search_Click(object sender, EventArgs e)
        {
            //Removes all the windows of the Bays Page
            this.Controls.Remove(this.baysPatient);
            //Removes all the windows of the Database Page
            removeDatabasePage();
            //Removes the search feature which isnt used yet
            this.Controls.Remove(this.patientSearchDetails);

            this.Controls.Remove(this.bay2Box);
            this.Controls.Remove(this.bay1Box);

            addSearchPage();
            removeBaySysytem();
        }

        //"Database" button
        private void database_Click(object sender, EventArgs e)
        {
           //Removes all the windows of the Bays Page
            this.Controls.Remove(this.baysPatient);
            // Removes all the windows of the Search Page
            removeSearchPage();

            this.Controls.Remove(this.bay2Box);
            this.Controls.Remove(this.bay1Box);

            //Adds Database Page
            addDatabasePage();
            //Removes Bays System
            removeBaySysytem();

        }

        //"Notification" button
        private void notifications_Click(object sender, EventArgs e)
        {
            // Removes all the windows of the Bays Page
            this.Controls.Remove(this.baysPatient);
            // Removes all the windows of the Database Page
            removeDatabasePage();
            // Removes all the windows of the Search Page
            removeSearchPage();

            removeBaySysytem();
        }

        //Group of bays with patients
        private void baysPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            addBaySystem();
        }

        //List of Registered Alarms
        private void alarmsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //List of all on call shifts of the Medical Team
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Add the Bay system used to look at bays
        public void addBaySystem()
        {

            this.Controls.Add(this.urineOutputLabel);
            this.Controls.Add(this.urineOutputInt);
            this.Controls.Add(this.urineOutputBox);

            this.Controls.Add(this.tempratureLabel);
            this.Controls.Add(this.tempratureInt);
            this.Controls.Add(this.tempratureBox);

            this.Controls.Add(this.pulseRateInt);
            this.Controls.Add(this.pulsePic1);
            this.Controls.Add(this.pulseRateLabel);
            this.Controls.Add(this.pulseRateBox);

            this.Controls.Add(this.bloodPressureUnit);
            this.Controls.Add(this.bloodPressureLabel);
            this.Controls.Add(this.bloodPressureIntDia);
            this.Controls.Add(this.bloodPressureIntSys);
            this.Controls.Add(this.bloodPressureIntBox);
            this.Controls.Add(this.bloodPressureBox);

            this.Controls.Add(this.patientContactsLabel);
            this.Controls.Add(this.patientDiagnosisLabel);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.patientDOBLabel);
            this.Controls.Add(this.patientSurenameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientPicture);
            this.Controls.Add(this.patientDetailsBox);

            this.Controls.Add(this.patientDetailsGroupBox);
        }

        //Removes the Bay system used to look at bays
        public void removeBaySysytem()
        {
            this.Controls.Remove(this.urineOutputLabel);
            this.Controls.Remove(this.urineOutputInt);
            this.Controls.Remove(this.urineOutputBox);

            this.Controls.Remove(this.tempratureBox);
            this.Controls.Remove(this.tempratureLabel);
            this.Controls.Remove(this.tempratureInt);

            this.Controls.Remove(this.pulseRateInt);
            this.Controls.Remove(this.pulsePic1);
            this.Controls.Remove(this.pulseRateLabel);
            this.Controls.Remove(this.pulseRateBox);

            this.Controls.Remove(this.bloodPressureUnit);
            this.Controls.Remove(this.bloodPressureIntBox);
            this.Controls.Remove(this.bloodPressureIntDia);
            this.Controls.Remove(this.bloodPressureIntSys);
            this.Controls.Remove(this.bloodPressureLabel);
            this.Controls.Remove(this.bloodPressureBox);

            this.Controls.Remove(this.patientDetailsGroupBox);

            this.Controls.Remove(this.patientContactsLabel);
            this.Controls.Remove(this.patientDiagnosisLabel);
            this.Controls.Remove(this.patientIDLabel);
            this.Controls.Remove(this.patientDOBLabel);
            this.Controls.Remove(this.patientSurenameLabel);
            this.Controls.Remove(this.patientNameLabel);
            this.Controls.Remove(this.patientPicture);
            this.Controls.Remove(this.patientDetailsBox);

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadShiftsDatabase();
            LoadAlarmsDatabase();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void name_Click(object sender, EventArgs e)
        {

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

        public void updateStaffDetails(int staffIDSQL)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From StaffDatabase where StaffID='" + staffIDSQL + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            name.Text = "Name: " + dt.Rows[0][1].ToString();
            surname.Text = "Surname: " + dt.Rows[0][2].ToString();
            DOB.Text = "DOB: " + dt.Rows[0][4].ToString();
            staffID.Text = "Staff ID: " + dt.Rows[0][0].ToString();
            position.Text = "Position: " + dt.Rows[0][5].ToString();
            contacts.Text = "Contacts: " + dt.Rows[0][6].ToString();


        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From patientDatabase where PatientID='" + IDSearchBox.Text + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("Select * From patientDatabase where PatientID='" + IDSearchBox.Text + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                MessageBox.Show("Patient ID: " + dt2.Rows[0][0].ToString() + "\n" +
                    " First Name: " + dt2.Rows[0][1].ToString() + "\n" +
                    " Last Name: " + dt2.Rows[0][2].ToString() + "\n" +
                    " DOB: " + dt2.Rows[0][8].ToString()+ "\n" +
                    " Diagnosis: "+dt2.Rows[0][9].ToString());
            }
            
            else
            {
                MessageBox.Show("Please check patient details");
            }

        }

        private void TempratureLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodPressureLabel_Click(object sender, EventArgs e)
        {

        }

        private void PatientDetailsGroupBox_Click(object sender, EventArgs e)
        {

        }

        private void BreathRateBox_Click(object sender, EventArgs e)
        {

        }

        private void BreathRateInt_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadAlarmsDatabase()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM alarmsDatabase";
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listItem = new ListViewItem(dr["PatientID"].ToString());
                    listItem.SubItems.Add(dr["Bay"].ToString());
                    listItem.SubItems.Add(dr["timeGenerated"].ToString());
                    listItem.SubItems.Add(dr["timeRectified"].ToString());
                    alarmsList.Items.Add(listItem);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadShiftsDatabase()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM shiftsDatabase";
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listItem = new ListViewItem(dr["MedicID"].ToString());
                    listItem.SubItems.Add(dr["timeRegistered"].ToString());
                    listItem.SubItems.Add(dr["timeDeregistered"].ToString());
                    shiftsList.Items.Add(listItem);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void surname_Click(object sender, EventArgs e)
        {

        }

        private void addSearchPage()
        {
            this.Controls.Add(this.IDSearchBox);
            this.Controls.Add(this.searchingLabel2);
            this.Controls.Add(this.patientSearchigBox);
            this.Controls.Add(this.searchingLabel);
            this.Controls.Add(this.findButton);
        }

        private void removeSearchPage()
        {
            this.Controls.Remove(this.IDSearchBox);
            this.Controls.Remove(this.searchingLabel);
            this.Controls.Remove(this.patientSearchigBox);
            this.Controls.Remove(this.searchingLabel2);
            this.Controls.Remove(this.findButton);
        }

        private void addDatabasePage()
        {
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.alarmsLabel);
            this.Controls.Add(this.shiftsList);
            this.Controls.Add(this.alarmsList);
        }

        private void removeDatabasePage()
        {
            this.Controls.Remove(this.shiftsLabel);
            this.Controls.Remove(this.alarmsLabel);
            this.Controls.Remove(this.shiftsList);
            this.Controls.Remove(this.alarmsList);
            this.Controls.Remove(this.bay2Box);
            this.Controls.Remove(this.bay1Box);
        }

        private void searchingPatient()
        {

        }


    }
}
