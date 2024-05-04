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
using System.Xml.Linq;

namespace Crime_App
{
    public partial class visitor_register_form : Form
    {
        public visitor_register_form()
        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            ClearAllBoxes();

        }
        public void  ClearAllBoxes()
        {
            visitorName.Clear();
            visitorAddress.Clear();
            visitorContactInformation.Clear();
            visitorRelationship.Clear();
            visitorVehicleInformation.Clear();
            visitorNotes.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled out
            if (string.IsNullOrEmpty(visitorName.Text) ||
                string.IsNullOrEmpty(visitorAddress.Text) ||
                string.IsNullOrEmpty(visitorContactInformation.Text) ||
                string.IsNullOrEmpty(visitorRelationship.Text) ||
                string.IsNullOrEmpty(visitorIdentification.Text) ||
                string.IsNullOrEmpty(visitorNotes.Text) ||
                string.IsNullOrEmpty(selectDob.Text) ||
                string.IsNullOrEmpty(selectGender.Text) ||
                string.IsNullOrEmpty(selectSecurityClearance.Text) ||
                string.IsNullOrEmpty(visitorVehicleInformation.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            // Construct the query
            string query = "INSERT INTO Visitor " +
                           "(name, gender, dateOfBirth, address, contactInformation, relationshipToInmate, " +
                           "identification, securityClearance, vehicleInformation, notes) " +
                           "VALUES " +
                           "(@name, @gender, @dateOfBirth, @address, @contactInformation, @relationshipToInmate, " +
                           "@identification, @securityClearance, @vehicleInformation, @notes)";

            // Create a connection to the database
            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();

                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters and bind their values
                    command.Parameters.AddWithValue("@name", visitorName.Text);
                    command.Parameters.AddWithValue("@gender", selectGender.Text);
                    DateTime dateAcquired = selectDob.Value.Date;
                    command.Parameters.AddWithValue("@dateOfBirth", dateAcquired);
                    command.Parameters.AddWithValue("@address", visitorAddress.Text);
                    command.Parameters.AddWithValue("@contactInformation", visitorContactInformation.Text);
                    command.Parameters.AddWithValue("@relationshipToInmate", visitorRelationship.Text);
                    command.Parameters.AddWithValue("@identification", visitorIdentification.Text);
                    command.Parameters.AddWithValue("@securityClearance", selectSecurityClearance.Text);
                    command.Parameters.AddWithValue("@vehicleInformation", visitorVehicleInformation.Text);
                    command.Parameters.AddWithValue("@notes", visitorNotes.Text);

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Display success message
                    MessageBox.Show("Visitor information has been successfully added to the database.");
                }
            }
        }

        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        private void visitor_register_form_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            visitor_form v = new visitor_form();
            v.Show();
        }

        private void selectDob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
