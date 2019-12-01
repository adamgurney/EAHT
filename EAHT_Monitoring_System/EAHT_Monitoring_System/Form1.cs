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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void staffID_label_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event for logging in the system when button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Connection to the EAHT Database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            //Data adapter to the menegement staff database
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From staffDatabase where StaffID='" + Staff_ID_textbox.Text + "' and Password='" + Password.Text + "'", con);
            //Data adapter to the medical staff database
            SqlDataAdapter mda = new SqlDataAdapter("Select Count(*) From medicsDatabase where MedicID='" + Staff_ID_textbox.Text + "' and Password='" + Password.Text + "'", con);

            DataTable dt2 = new DataTable();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mda.Fill(dt2);

            //Condition for checking if input username and password match with the ones in the Management Staff Database
            if (dt.Rows[0][0].ToString() == "1")
            {
                //If user input is valid this window hides and new window for manager opens
                this.Hide();
                Form2 f2 = new Form2();
                int idForStaff = Convert.ToInt32(Staff_ID_textbox.Text);
                f2.updateStaffDetails(idForStaff); //Updating menegement staff details
                f2.ShowDialog();
            }

            //Conditions for checking input username and password match with the ones in the Medical Team Database
            else if (dt2.Rows[0][0].ToString()=="1")
            {
                //If user input is valid, new window for medical team member opens
                RegisterShift();    //Registration of shift's startting time
                this.Hide();
                Form3 f3 = new Form3();
                int idForMedics = Convert.ToInt32(Staff_ID_textbox.Text);
                f3.updateMedicsDetails(idForMedics);  //Updating medics details
                f3.ShowDialog();
            }

            //Else condition for displaying error message if user inputs are not valid
            else
            {
                MessageBox.Show("Please check your StaffID and password");
            }
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact with hospital management team");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterShift()
        {
            using (SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into shiftsDatabase (MedicID, timeRegistered) VALUES (@MedicID, @timeRegistered)";
                    command.Parameters.AddWithValue("@MedicID",Staff_ID_textbox.Text);
                    command.Parameters.AddWithValue("@timeRegistered", DateTime.Now);


                    try
                    {
                        Conn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        Conn.Close();
                    }
                }
            }
        }

        private void StaffIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
