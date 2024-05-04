using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class view_doctor_information : Form
    {
        public view_doctor_information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            fillIdComboBox(selectDoctorId, "select id from doctor");
        }
        public void fillIdComboBox(ComboBox c, string query)
        {
            List<int> distinctIDs = new List<int>();
            new_prisoner_form n = new new_prisoner_form();

            SQLiteDataReader reader = n.Db_Read(query);
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                distinctIDs.Add(id);

            }
            foreach (int id in distinctIDs)
            {
                c.Items.Add(id);
            }
        }
        public SQLiteDataReader Db_Read(string query)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            // Add the parameter
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        private void view_doctor_information_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int doctor_id;
            if (selectDoctorId.SelectedItem != null)
            {
                doctor_id = Convert.ToInt32(selectDoctorId.SelectedItem.ToString());
            }
            else
            {
                // Handle the case where no item is selected
                // For example, you could assign a default value to doctor_id or show a message to the user
                doctor_id = -1; // Assigning a default value of -1
                MessageBox.Show("Please select a doctor.");
                return;
            }
            if (doctor_id != 0)
            {
                string doctor_name = "";
                string doctor_specialization = "";
                string doctor_gender = "";
                string doctor_dob = "";
                string doctor_availibility_start = "";
                string doctor_availability_end = "";
                string doctor_language = "";

                SQLiteConnection connection = Db_Connection();
                connection.Open(); // Open the connection before executing the query
                SQLiteCommand selectCommand = new SQLiteCommand("select name,specialization,gender,dob,availability_start,availability_end,language from doctor where id=@doctor_id", connection);
                selectCommand.Parameters.AddWithValue("@doctor_id", doctor_id); // Add the parameter
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                if (reader != null && reader.Read()) {
                    doctor_name = reader["name"].ToString();
                    doctor_specialization = reader["specialization"].ToString();
                    doctor_dob = reader["dob"].ToString();
                    doctor_availibility_start = reader["availability_start"].ToString();
                    doctor_availability_end = reader["availability_end"].ToString();
                    doctor_language = reader["language"].ToString();
                    doctor_gender = reader["gender"].ToString();
                }
                doctorName.Clear();
                doctorSpecialization.Clear();
                doctorGender.Clear();
                doctorAvailabilityEnd.Clear();
                doctorAvailabilityStart.Clear(); ;
                doctorLanguage.Clear();
                doctorDob.Clear();

                doctorName.AppendText(doctor_name);
                doctorSpecialization.AppendText(doctor_specialization);
                doctorGender.AppendText(doctor_gender);
                doctorAvailabilityStart.AppendText(doctor_availibility_start);
                doctorAvailabilityEnd.AppendText(doctor_availability_end);
                doctorLanguage.AppendText(doctor_language);
                doctorDob.AppendText(doctor_dob);
                

            }
            else
            {
                MessageBox.Show("Select Again!!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            doctor_management_module d = new doctor_management_module();
            d.Show();
        }

        private void doctorLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
