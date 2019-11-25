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
    }
}
