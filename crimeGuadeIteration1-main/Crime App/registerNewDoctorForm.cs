using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class registerNewDoctorForm : Form
    {
        public registerNewDoctorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;


        }

        private void registerNewDoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(doctorName.Text) ||
    string.IsNullOrWhiteSpace(selectDoctorSpecialization.SelectedItem.ToString()) ||
    string.IsNullOrWhiteSpace(selectDoctorGender.SelectedItem.ToString()) ||
    string.IsNullOrWhiteSpace(doctorDob.Text) ||
    string.IsNullOrWhiteSpace(selectAvailabilityStart.Text) ||
    string.IsNullOrWhiteSpace(selectAvailabilityEnd.Text) ||
    string.IsNullOrWhiteSpace(doctorLanguage.Text))
            {
                // Handle the case where at least one of the fields is empty
                // For example, you can show a message to the user or log the error.
                MessageBox.Show("Error: One or more fields are empty.")
                    ; return;
            }
            else
            {
                // All fields have values, proceed with your logic here
            }

            string doctor_name = doctorName.Text;
            string doctor_specialization = selectDoctorSpecialization.SelectedItem.ToString();
            string doctor_gender = selectDoctorGender.SelectedItem.ToString();
            string doctor_dob = doctorDob.Text;
            string doctor_start_time = selectAvailabilityStart.Text; // Assuming these are TextBox controls
            string doctor_end_time = selectAvailabilityEnd.Text;
            string doctor_language = doctorLanguage.Text;

            string query = "INSERT INTO doctor " +
                           "(name, specialization, gender, dob, " +
                           "availability_start, availability_end, language) " +
                           "VALUES (@doctor_name, @doctor_specialization, " +
                           "@doctor_gender, @doctor_dob, @doctor_start_time, " +
                           "@doctor_end_time, @doctor_language)";

            string connectionString = "Data Source=fir_db.db;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@doctor_name", doctor_name);
                    command.Parameters.AddWithValue("@doctor_specialization", doctor_specialization);
                    command.Parameters.AddWithValue("@doctor_gender", doctor_gender);
                    DateTime doctorDobDate;
                    if (DateTime.TryParse(doctorDob.Text, out doctorDobDate))
                    {
                        // Parsing successful, 'doctorDobDate' contains the parsed date value
                        DateTime dateOnly = doctorDobDate.Date; // Extracting just the date part
                        command.Parameters.AddWithValue("@doctor_dob", dateOnly);
                    }
                    else
                    {
                         Console.WriteLine("Error: Invalid date format.");
                    }
                   
                    command.Parameters.AddWithValue("@doctor_start_time", doctor_start_time);
                    command.Parameters.AddWithValue("@doctor_end_time", doctor_end_time);
                    command.Parameters.AddWithValue("@doctor_language", doctor_language);

                    try
                    {
                       
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            doctor_management_module   d = new doctor_management_module(); ;
            d.Show();
        }
    }
}
