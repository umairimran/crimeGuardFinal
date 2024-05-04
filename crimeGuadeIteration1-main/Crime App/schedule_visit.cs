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
    public partial class schedule_visit : Form
    {
        public schedule_visit()
        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            fillIdComboBox(selectPrisonerId, "select p_id as id from prisoners");
            fillIdComboBox(selectVisitorId, "select visitorId as id from visitor");
         
        }

        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
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

        private void schedule_visit_Load(object sender, EventArgs e)
        {

        }

        private void selectPrisonerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectPrisonerId.SelectedItem == null || selectVisitorId.SelectedItem == null)
            {
                MessageBox.Show("Please select valid prisoner and visitor IDs.");
                return;
            }

            int prisoner_id;
            int visitor_id;

            // Try to parse the selected item to an integer
            if (!int.TryParse(selectPrisonerId.SelectedItem.ToString(), out prisoner_id) ||
                !int.TryParse(selectVisitorId.SelectedItem.ToString(), out visitor_id))
            {
                MessageBox.Show("Please select valid prisoner and visitor IDs.");
                return;
            }
            string prisoner_name = prisonerName.Text;
            
            string visitor_name = visitorName.Text;
            string purpose_of_visit =purposeOfVisit.Text;
            string entery_date_time =entryDateTime.Text;
            string exit_date_time = exitDateTime.Text;
            int duration_of_visit;
            try
            {
                duration_of_visit = Convert.ToInt32(durationOfVisit.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Duration of visit must be a valid integer.");
                return;
            }
            prisoner_name = GetName(prisoner_id);
            visitor_name = GetNameVisitor(visitor_id);
            prisonerName.AppendText(prisoner_name);
            visitorName.AppendText(visitor_name);
            if (
    string.IsNullOrEmpty(prisoner_name) ||
    string.IsNullOrEmpty(visitor_name) ||
    string.IsNullOrEmpty(purpose_of_visit) ||
    string.IsNullOrEmpty(entery_date_time) ||
    string.IsNullOrEmpty(exit_date_time) ||
   duration_of_visit==0)
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }



            string query = @"INSERT INTO visitor_history 
                (visitorId, prisonerId, prisonerName, visitorName, purposeOfVisit, entryTime, exitTime, dateOfVisit, timeOfVisit, durationOfVisit) 
                VALUES 
                (@visitorId, @prisonerId, @prisonerName, @visitorName, @purposeOfVisit, @entryTime, @exitTime, @dateOfVisit, @timeOfVisit, @durationOfVisit);";

            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@visitorId", visitor_id);
                    command.Parameters.AddWithValue("@prisonerId", prisoner_id);
                    command.Parameters.AddWithValue("@prisonerName", prisoner_name);
                    command.Parameters.AddWithValue("@visitorName", visitor_name);
                    command.Parameters.AddWithValue("@purposeOfVisit", purpose_of_visit);
                    DateTime dateAcquired = entryDateTime.Value.Date;
                    command.Parameters.AddWithValue("@entryTime", dateAcquired);
                     dateAcquired = exitDateTime.Value.Date;
                    command.Parameters.AddWithValue("@exitTime", dateAcquired);
                    command.Parameters.AddWithValue("@dateOfVisit", DateTime.Now.Date); // Assuming current date
                    command.Parameters.AddWithValue("@timeOfVisit", DateTime.Now.TimeOfDay); // Assuming current time
                    command.Parameters.AddWithValue("@durationOfVisit", duration_of_visit);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Visitor Schedule  has been successfully added to the database.");

                }
            }




        }
        private string GetName(int prisonerId)
        {
            // Perform a database query to retrieve the name of the prisoner with the given ID
            // Replace this with your actual database query logic
            string prisonerName = "";

            // Example query using SQLiteCommand
            string query = "SELECT name FROM prisoners WHERE p_id = @prisonerId";

            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prisonerId", prisonerId);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        prisonerName = result.ToString();
                    }
                }
            }

            return prisonerName;
        }
        private string GetNameVisitor(int visitor_id)
        {
            // Perform a database query to retrieve the name of the prisoner with the given ID
            // Replace this with your actual database query logic
            string visitor_name = "";

            // Example query using SQLiteCommand
            string query = "SELECT name FROM visitor WHERE visitorid = @visitor_id";

            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@visitor_id", visitor_id);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        visitor_name = result.ToString();
                    }
                }
            }

            return visitor_name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            visitor_form f = new visitor_form();
            f.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
