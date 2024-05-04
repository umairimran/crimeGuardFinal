using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class create_medical_report : Form
    {
        public  bool alreadyRecorded = false;
        public create_medical_report()
        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            addPrisonerToCell a= new addPrisonerToCell();
            a.fillIdComboBox(selectPrisonerId, "select p_id as id from prisoners ");
            a.fillIdComboBox(selectDoctorId, "select id as id from doctor");
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_medical_report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedPrisonerId = selectPrisonerId.SelectedItem?.ToString();
            string selectedDoctorId = selectDoctorId.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPrisonerId) || string.IsNullOrEmpty(selectedDoctorId))
            {
                MessageBox.Show("Please select a prisoner and a doctor.");
                return;
            }

            int prisoner_id = int.Parse(selectedPrisonerId);
            int doctor_id = int.Parse(selectedDoctorId);
            if (IsCellNumberExists(prisoner_id, doctor_id))
            {
                MessageBox.Show("This Patient with this doctor already exist to update previous report not create new. ");
                fillTheFields(prisoner_id,doctor_id);
                alreadyRecorded = true;
               
            }
            else
            {
                MessageBox.Show("Record dont exist so you can create new record with this doctor.");
                previousDateOfReport.Text = "No Record";
                previousMedicalHistory.Text = "No Record";
                priviousDisease.Text = "No Record";
                priviousMentalCondition.Text = "No Record";
                priviousTreatementPlan.Text = "No Record";
                alreadyRecorded = false;
                // crreate new report
            }
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        public void fillTheFields(int prisoner_id,int doctor_id)
        {
            
            SQLiteDataReader reader2 = Db_Read("select medicalHistory,disease,treatmentPlan,mentalcondition,date,time from medicalReport where prisonerid=@prisoner_id and doctorid=@doctor_id",prisoner_id,doctor_id);

            if(reader2!=null && reader2.HasRows)
            {
                while(reader2.Read())
                {
                    previousDateOfReport.Text = reader2["time"].ToString();
                    previousMedicalHistory.Text = reader2["medicalHistory"].ToString();
                    priviousDisease.Text = reader2["disease"].ToString();
                    priviousTreatementPlan.Text = reader2["treatmentPlan"].ToString();
                    priviousMentalCondition.Text = reader2["mentalCondition"].ToString();

                }
            }

        }
        public SQLiteDataReader Db_Read(string query, int prisonerId,int doctorid)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query

            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            selectCommand.Parameters.AddWithValue("@prisoner_id", prisonerId);
            selectCommand.Parameters.AddWithValue("@doctor_id", doctorid);

            SQLiteDataReader reader = selectCommand.ExecuteReader();

            // Return the reader, don't close the connection here to allow the caller to manage it
            return reader;
        }
        public bool IsCellNumberExists(int prisoner_id, int activity_id)
        {
            // Check if the cell number already exists in the database
            register_prisoner_to_activity r = new register_prisoner_to_activity();
            string query = "SELECT COUNT(*) FROM medicalreport WHERE prisonerid = @prisoner_id and doctorid=@activity_id";
            using (SQLiteConnection connection = r.Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prisoner_id", prisoner_id);

                    command.Parameters.AddWithValue("@activity_id", activity_id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedPrisonerId = selectPrisonerId.SelectedItem?.ToString();
            string selectedDoctorId = selectDoctorId.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPrisonerId) || string.IsNullOrEmpty(selectedDoctorId))
            {
                MessageBox.Show("Please select a prisoner and a doctor.");
                return;
            }

            int prisoner_id = int.Parse(selectedPrisonerId);
            int doctor_id = int.Parse(selectedDoctorId);
            string current_date = currentDate.Text;
            string current_medical_condition = currentMedicalCondition.Text;
            string current_disease = currentDisease.Text;
            string current_treatment_plan = currentTreatmentPlan.Text;
            string current_mentalCondition = currentMentalCondition.Text;
            if(alreadyRecorded==false)
            {
                InsertMedicalReport(prisoner_id, doctor_id, current_date, current_medical_condition, current_disease, current_treatment_plan, current_mentalCondition);
            }
            if(alreadyRecorded==true)
            {
                UpdateMedicalReport(prisoner_id, doctor_id, current_date,current_medical_condition, current_disease, current_treatment_plan, current_mentalCondition);

            }
        }



        // Add a method to insert a medical report
        private void InsertMedicalReport(int prisonerId, int doctorId, string date, string medicalHistory, string disease, string treatmentPlan, string mentalCondition)
        {
            // SQL insert query with parameters
            string sql = @"INSERT INTO medicalReport (doctorid, prisonerid, date, medicalHistory, disease, treatmentPlan, mentalcondition) 
                   VALUES (@doctorId, @prisonerId, @date, @medicalHistory, @disease, @treatmentPlan, @mentalCondition)";

            using (SQLiteConnection connection = Db_Connection())
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@doctorId", doctorId);
                command.Parameters.AddWithValue("@prisonerId", prisonerId);
                DateTime dateAcquired = currentDate.Value.Date;
                command.Parameters.AddWithValue("@date", dateAcquired);

                command.Parameters.AddWithValue("@medicalHistory", medicalHistory);
                command.Parameters.AddWithValue("@disease", disease);
                command.Parameters.AddWithValue("@treatmentPlan", treatmentPlan);
                command.Parameters.AddWithValue("@mentalCondition", mentalCondition);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medical report inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert medical report.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Call this method where you want to insert a medical report
         private void UpdateMedicalReport(int prisonerId, int doctorId, string date,  string medicalHistory, string disease, string treatmentPlan, string mentalCondition)
        {
            string sql = @"UPDATE medicalReport
                   SET date = @date,
                       
                       medicalHistory = @medicalHistory,
                       disease = @disease,
                       treatmentPlan = @treatmentPlan,
                       mentalcondition = @mentalCondition
                   WHERE doctorid = @doctorId
                     AND prisonerid = @prisonerId";

            using (SQLiteConnection connection = Db_Connection())
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@doctorId", doctorId);
                command.Parameters.AddWithValue("@prisonerId", prisonerId);
                DateTime dateAcquired = currentDate.Value.Date;
                command.Parameters.AddWithValue("@date", dateAcquired);

                command.Parameters.AddWithValue("@medicalHistory", medicalHistory);
                command.Parameters.AddWithValue("@disease", disease);
                command.Parameters.AddWithValue("@treatmentPlan", treatmentPlan);
                command.Parameters.AddWithValue("@mentalCondition", mentalCondition);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medical report updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No matching records found for update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Call this method where you want to update a medical report
     
        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prisoner_form f = new prisoner_form();
            f.Show();
        }
    }
}
