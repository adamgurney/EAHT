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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EAHT_Database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From staffDatabase where StaffID='" + Staff_ID_textbox.Text + "' and Password='" + Password.Text + "'", con);
            SqlDataAdapter mda = new SqlDataAdapter("Select Count(*) From medicsDatabase where MedicID='" + Staff_ID_textbox.Text + "' and Password='" + Password.Text + "'", con);

            DataTable dt2 = new DataTable();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mda.Fill(dt2);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 f2 = new Form2();
                int idForStaff = Convert.ToInt32(Staff_ID_textbox.Text);
                f2.updateStaffDetails(idForStaff);
                f2.ShowDialog();
            }

            else if (dt2.Rows[0][0].ToString()=="1")
            {
                RegisterShift();
                this.Hide();
                Form3 f3 = new Form3();
                int idForMedics = Convert.ToInt32(Staff_ID_textbox.Text);
                f3.updateMedicsDetails(idForMedics);
                f3.ShowDialog();
            }

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
