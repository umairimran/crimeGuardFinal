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
    public partial class crime_input_page : Form
    {
        public crime_input_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string district = district_selection_box.SelectedItem?.ToString();
            string division = division_selection_box.SelectedItem?.ToString();
            int year = date_selection_box.Value.Year;
            string weapon = weapon_selection_box.SelectedItem?.ToString();
            string gender = gender_selection_box.SelectedItem?.ToString();
            string age_group = age_selection_box.SelectedItem?.ToString();
            string time = time_selection_box.SelectedItem?.ToString();
            string crime_type = crime_type_selction_box.SelectedItem?.ToString();
            if (district == null || division == null || year == null || weapon == null || gender == null || age_group == null || time == null || crime_type == null)
            {
                MessageBox.Show("Enter Again");
            }
            else
            {
                // Fetch latitude and longitude based on the provided district or division
                double latitude = 0.0;  // Initialize with default value
                double longitude = 0.0;  // Initialize with default value
                string connectionString = "";
                if (!string.IsNullOrEmpty(district) || !string.IsNullOrEmpty(division))
                {
                    // Perform query to fetch latitude and longitude from your database based on district or division
                    // Example query: SELECT Latitude, Longitude FROM CityCoordinates WHERE City = @City
                    // Replace CityCoordinates with your actual table name and City with the column name for city or division
                    connectionString = "Data Source=crime_db.db;Version=3;";
                    string sqlQuery = "SELECT Latitude, Longitude FROM crime_data WHERE district = @City ";  // Modify query as needed
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@City", !string.IsNullOrEmpty(district) ? district : division);
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    latitude = Convert.ToDouble(reader["Latitude"]);
                                    longitude = Convert.ToDouble(reader["Longitude"]);
                                }
                            }
                        }
                    }
                }

                connectionString = "Data Source=crime_db.db;Version=3;";
                string sqlInsert = "INSERT INTO crime_data (Year, Division, District, CrimeType, CrimeCount, Population, Weapon, Time, [Day/Night], Victim_Sex, Latitude, Longitude, age_group,day_night) VALUES (@Year, @Division, @District, @CrimeType, NULL, NULL, @Weapon, @Time, NULL, @Gender, @Latitude, @Longitude, @AgeGroup,@Time)";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlInsert, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@District", string.IsNullOrEmpty(district) ? DBNull.Value : (object)district);
                        command.Parameters.AddWithValue("@Division", string.IsNullOrEmpty(division) ? DBNull.Value : (object)division);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Weapon", string.IsNullOrEmpty(weapon) ? DBNull.Value : (object)weapon);
                        command.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(gender) ? DBNull.Value : (object)gender);
                        command.Parameters.AddWithValue("@AgeGroup", string.IsNullOrEmpty(age_group) ? DBNull.Value : (object)age_group);
                        command.Parameters.AddWithValue("@Time", string.IsNullOrEmpty(time) ? DBNull.Value : (object)time);
                        command.Parameters.AddWithValue("@CrimeType", string.IsNullOrEmpty(crime_type) ? DBNull.Value : (object)crime_type);
                        command.Parameters.AddWithValue("@Latitude", latitude);
                        command.Parameters.AddWithValue("@Longitude", longitude);
                        command.Parameters.AddWithValue("@Time", string.IsNullOrEmpty(time) ? DBNull.Value : (object)time);


                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Value inserted successfully!");
            }
        }

        private void division_selection_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void time_selection_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crime_input_page_Load(object sender, EventArgs e)
        {

        }
    }
}
