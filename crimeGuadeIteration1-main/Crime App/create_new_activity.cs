using Google.Protobuf.WellKnownTypes;
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
    public partial class create_new_activity : Form
    {
        public create_new_activity()
        {
            InitializeComponent();
        }

        private void create_new_activity_Load(object sender, EventArgs e)
        {

        }


private void button1_Click(object sender, EventArgs e)
    {
        // Retrieve values from the textboxes
        string activity_name = activityName.Text;
        string activity_description = activityDescription.Text;
        string activity_location = activityLocation.Text;
        string activity_date = activityDate.Text;
        string activity_start_time = activityStartTime.Text;
        string activity_end_time = activityEndTime.Text;
        string duration = activityDuration.Text;
        string activity_supervisor = activitySupervisor.Text;
        string activity_equipment = activityResources.Text;

        // Check if any of the variables are null or empty
        if (string.IsNullOrEmpty(activity_name) ||
            string.IsNullOrEmpty(activity_description) ||
            string.IsNullOrEmpty(activity_location) ||
            string.IsNullOrEmpty(activity_date) ||
            string.IsNullOrEmpty(activity_start_time) ||
            string.IsNullOrEmpty(activity_end_time) ||
            string.IsNullOrEmpty(duration) ||
            string.IsNullOrEmpty(activity_supervisor) ||
            string.IsNullOrEmpty(activity_equipment))
        {
            // Display a message box to prompt the user to enter the missing information
            MessageBox.Show("Please enter values for all fields.");
            return;
        }

        // Connection string for SQLite database
        string connectionString = "Data Source=fir_db.db;Version=3;";

        // SQL insert query with parameters
        string sql = "INSERT INTO Activity (activityName, description, location, date, startTime, endTime, duration, supervisor, equipmentResources) " +
                     "VALUES (@activityName, @description, @location, @date, @startTime, @endTime, @duration, @supervisor, @equipmentResources)";

        // Create connection and command objects
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            // Add parameters to the command
            command.Parameters.AddWithValue("@activityName", activity_name);
            command.Parameters.AddWithValue("@description", activity_description);
            command.Parameters.AddWithValue("@location", activity_location);
                DateTime dateAcquired = activityDate.Value.Date;
                command.Parameters.AddWithValue("@date", dateAcquired);
            command.Parameters.AddWithValue("@startTime", activity_start_time);
            command.Parameters.AddWithValue("@endTime", activity_end_time);
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@supervisor", activity_supervisor);
            command.Parameters.AddWithValue("@equipmentResources", activity_equipment);

            try
            {
                // Open the connection
                connection.Open();

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Activity inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert activity.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            activity_module m = new activity_module();
            m.Show();
        }
    }
}
