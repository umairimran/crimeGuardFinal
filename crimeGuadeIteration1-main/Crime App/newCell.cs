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
    public partial class newCell : Form
    {
        public newCell()
        {
            InitializeComponent();
                       cellNumber.Clear();
            cellCapacity.Clear();
            discription.Clear();
            maintainanceNotes.Clear();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int cell_number;

            if (int.TryParse(cellNumber.Text, out cell_number))
            {
                // Parsing succeeded, 'cell_number' now contains the parsed integer value
            }
            else
            {
                // Parsing failed, 'cell_number' will be 0
                // Display an error message to the user or handle the error appropriately
                MessageBox.Show("Please enter a valid integer for the cell number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsCellNumberExists(cell_number))
            {
                MessageBox.Show("Cell number already exists. Please enter a different cell number.");
                return;
            }


            int cell_capacity =int.Parse(cellCapacity.Text);
            string cell_description = discription.Text;
            string security_level = securityLevel.SelectedItem.ToString();
            string maintenance_notes = maintainanceNotes.Text;
            string inspection_date = startInspectionDate.Text;
            string next_inspection_date = nextInspectionDate.Text;
            int cell_occupancy = 0; // Default value for now
            string cell_cleanliness = cleanliness.Text;
            string cell_accessibility = accessibility.Text;
            string cell_status = "Available";
            if (!string.IsNullOrEmpty(cell_description) &&
                !string.IsNullOrEmpty(security_level) &&
                !string.IsNullOrEmpty(maintenance_notes) &&
                !string.IsNullOrEmpty(inspection_date) &&
                !string.IsNullOrEmpty(next_inspection_date) &&
                !string.IsNullOrEmpty(cell_cleanliness) &&
                !string.IsNullOrEmpty(cell_accessibility) &&
                int.TryParse(cellNumber.Text, out cell_number) &&
                int.TryParse(cellCapacity.Text, out cell_capacity))
            {
                // Proceed with the data as all conditions are met
                string query = @"INSERT INTO cell 
                     (cellNumber, capacity, occupancy, description, securityLevel, 
                     maintenanceNotes, lastInspectionDate, nextInspectionDate, cleanliness, accessibility,status)
                     VALUES 
                     (@cellNumber, @cellCapacity, @cellOccupancy, @cellDescription, @securityLevel, 
                     @maintenanceNotes, @lastInspectionDate, @nextInspectionDate, @cleanliness, @accessibility,@status)";

                using (SQLiteConnection connection = Db_Connection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@cellNumber", cell_number);
                        command.Parameters.AddWithValue("@cellCapacity", cell_capacity);
                        command.Parameters.AddWithValue("@cellOccupancy", cell_occupancy);
                        command.Parameters.AddWithValue("@cellDescription", cell_description);
                        command.Parameters.AddWithValue("@securityLevel", security_level);
                        DateTime dateAcquired = startInspectionDate.Value.Date;
                        command.Parameters.AddWithValue("@maintenanceNotes", maintenance_notes);

                        command.Parameters.AddWithValue("@lastInspectionDate", dateAcquired);
                        dateAcquired = nextInspectionDate.Value.Date;
                        command.Parameters.AddWithValue("@nextInspectionDate", dateAcquired);
                        
                        command.Parameters.AddWithValue("@cleanliness", cell_cleanliness);
                        command.Parameters.AddWithValue("@accessibility", cell_accessibility);
                        command.Parameters.AddWithValue("@status", cell_status);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                // Show message to enter data again
                MessageBox.Show("Please make sure all fields are filled correctly. Enter data again.");
                // Or any other action you want to take if the conditions fail
            }

            // Check if the cell number already exists

            // Prepare the INSERT query
           
            // Optionally display a success message or perform other actions
        }

        private bool IsCellNumberExists(int cellNumber)
        {
            // Check if the cell number already exists in the database
            string query = "SELECT COUNT(*) FROM cell WHERE cellNumber = @cellNumber";
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cellNumber", cellNumber);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void newCell_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cell_management c =  new cell_management();
            c.Show();
        }
    }
}
