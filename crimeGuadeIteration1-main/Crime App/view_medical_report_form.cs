using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class view_medical_report_form : Form
    {
        public view_medical_report_form()

        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            fillIdComboBox(selectPrisonerId,"select distinct prisonerId as id from medicalReport");
            fillIdComboBox(selectDoctorId, "select distinct doctorId as id from medicalReport");
        }

        public void fillIdComboBox(ComboBox c,string query)
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
        private void selectPrisonerId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public SQLiteDataReader Db_Read(string query, int prisonerId)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            selectCommand.Parameters.AddWithValue("@prisonerId", prisonerId); // Add the parameter
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader Db_Read2(string query, int prisonerId, int doctorId)
        {
            SQLiteDataReader reader;
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open(); // Open the connection before executing the query
                using (SQLiteCommand selectCommand = new SQLiteCommand(query, connection))
                {
                    selectCommand.Parameters.AddWithValue("@prisonerId", prisonerId); // Add the prisonerId parameter
                    selectCommand.Parameters.AddWithValue("@doctorId", doctorId); // Add the doctorId parameter
                    reader = selectCommand.ExecuteReader();
                    connection.Close();
                    return reader;
                }
            }
        }

        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ageInYears = 0;
            int prisonerIdd = Convert.ToInt32(selectPrisonerId.SelectedItem);
            int doctorIdd = Convert.ToInt32(selectDoctorId.SelectedItem);
            if (prisonerIdd != 0 && doctorIdd!= 0)
            {
                // Retrieve prisoner's name
                string prisoner_Name = "";
                string prisoner_age = "";
                string prisoner_gender = "";
                new_prisoner_form n = new new_prisoner_form();
                SQLiteDataReader reader = Db_Read("SELECT   name, dob, gender FROM prisoners WHERE p_id = @prisonerId", prisonerIdd);

                if (reader != null && reader.Read())
                {
                    prisoner_Name = reader["name"].ToString();
                    // Retrieve age and gender similarly
                    prisoner_age = reader["dob"].ToString();
                    
           
                    
                  

                  
                   
                    prisoner_gender = reader["gender"].ToString();
                }


                // Retrieve doctor's name
                string doctor_name = "";
                prisonerIdd = Convert.ToInt32(selectPrisonerId.SelectedItem);
                reader = Db_Read("select name from doctor where  id =@prisonerId", prisonerIdd);
                if (reader != null && reader.Read())
                {
                    doctor_name = reader["name"].ToString();
                }


                // Clear the text in textboxes
                doctorId.Clear();
                prisonerAge.Clear();
                
                prisonerName.Clear();
                doctorName.Clear();
                date.Clear();
                time.Clear();
                medicalHistory.Clear();
                disease.Clear();
                treatmentPlan.Clear();
                mentalCondition.Clear();
                prisonerAge.Clear();
                prisonerGender.Clear();

                // Retrieve medical report information
                string date_r = "";
                string time_r = "";
                string medicalhistory_r = "";
                string disease_r = "";
                string treatmentPlan_r = "";
                string mentalCondition_r = "";

                int prisoner_Id = Convert.ToInt32(selectPrisonerId.SelectedItem);
                int doctor_Id = Convert.ToInt32(selectDoctorId.SelectedItem);
                string query = "SELECT  time, medicalHistory, disease, treatmentPlan, mentalcondition FROM medicalReport where  prisonerid = @prisonerId order by reportid LIMIT 1";

                using (SQLiteConnection connection = Db_Connection())
                {
                    connection.Open(); // Open the connection before executing the query

                    using (SQLiteCommand selectCommand = new SQLiteCommand(query, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@prisonerId", prisoner_Id); // Add the prisonerId parameter
                         // Add the doctorId parameter

                        using (SQLiteDataReader reader1 = selectCommand.ExecuteReader())
                        {
                            // Process the results
                            while (reader1.Read())
                            {

                                // Retrieve the data and process it
                                
                               
                                 time_r = reader1["time"].ToString();
                               
                                 medicalhistory_r = reader1["medicalHistory"].ToString();
                                 disease_r = reader1["disease"].ToString();
                                 treatmentPlan_r = reader1["treatmentPlan"].ToString();
                                mentalCondition_r = reader1["mentalcondition"].ToString();

                                // Use the retrieved data as needed
                            }
                        }
                    }
                }

                // Check if there are rows returned by the query
 
                // Display retrieved information
                prisonerName.AppendText(prisoner_Name);
                doctorName.AppendText(doctor_name);
                date.AppendText(time_r);
                time.AppendText(time_r);
                medicalHistory.AppendText(medicalhistory_r);
                disease.AppendText(disease_r);
                treatmentPlan.AppendText(treatmentPlan_r);
                mentalCondition.AppendText(mentalCondition_r);
                prisonerAge.AppendText(prisoner_age.ToString());
                prisonerGender.AppendText(prisoner_gender);
                 prisoner_Id = Convert.ToInt32(selectPrisonerId.SelectedItem);
                doctor_Id = Convert.ToInt32(selectDoctorId.SelectedItem);
                doctorId.AppendText(doctor_Id.ToString());
            }
            else
            {
                MessageBox.Show("Select Again!!!!");
            }
        }

        private void prisonerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prisoner_form f = new prisoner_form();
            f.Show();
        }

        private void doctorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void disease_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_medical_report_form_Load(object sender, EventArgs e)
        {

        }
    }
}
