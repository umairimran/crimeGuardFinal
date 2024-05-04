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
    public partial class create_new_belonging : Form
    {
        public create_new_belonging()
        {
            InitializeComponent();
            ClearAllBoxes();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            fillIdComboBox(comboBox1, "select p_id as id from prisoners");
        }
        public void ClearAllBoxes()
        {
            itemName.Clear();
            itemDescription.Clear();
            itemNotes.Clear();
            itemStorageLocation.Clear();
            

        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            InsertPrisonerBelonging();

        }
        private void InsertPrisonerBelonging()
        {
            // Check if all required fields are filled out
            if (string.IsNullOrEmpty(itemStorageLocation.Text) ||
                string.IsNullOrEmpty(itemName.Text) ||
                string.IsNullOrEmpty(itemDescription.Text) ||
                string.IsNullOrEmpty(itemNotes.Text) ||
                string.IsNullOrEmpty(selectDateAcquired.Text) ||
                string.IsNullOrEmpty(selectItemCondition.Text) ||
                string.IsNullOrEmpty(selectItemStatus.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            // Construct the insert query
            string query = "INSERT INTO prisonerBelongings " +
                           "(prisonerId, itemName, description, condition, storageLocation, " +
                           "dateAcquired, status, notes) " +
                           "VALUES " +
                           "(@prisonerId, @itemName, @description, @condition, @storageLocation, " +
                           "@dateAcquired, @status, @notes)";
            int prisonerId=Convert.ToInt32(comboBox1.SelectedItem.ToString());
            // Create a connection to the database
            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();

                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters and bind their values
                    command.Parameters.AddWithValue("@prisonerId", prisonerId); // Assuming prisonerId is available
                    command.Parameters.AddWithValue("@itemName", itemName.Text);
                    command.Parameters.AddWithValue("@description", itemDescription.Text);
                    command.Parameters.AddWithValue("@condition", selectItemCondition.Text);
                    command.Parameters.AddWithValue("@storageLocation", itemStorageLocation.Text);
                    DateTime dateAcquired = selectDateAcquired.Value.Date;
                    command.Parameters.AddWithValue("@dateAcquired", dateAcquired);
                    command.Parameters.AddWithValue("@status", selectItemStatus.Text);
                    command.Parameters.AddWithValue("@notes", itemNotes.Text);

                    // Execute the query
                    command.ExecuteNonQuery();

                    // Display success message
                    MessageBox.Show("Prisoner belonging has been successfully added to the database.");
                }
            }
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

        private void create_new_belonging_Load(object sender, EventArgs e)
        {

        }

        private void selectDateAcquired_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personalBelongingsManagementPortal p = new personalBelongingsManagementPortal();
            p.Show();
        }
    }
}
