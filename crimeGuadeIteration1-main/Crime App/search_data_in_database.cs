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
    public partial class search_data_in_database : Form
    {
        public search_data_in_database()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            this.Load += Form_Load;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=crime_db.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                try
                {
                    string district = cmbDistrict.SelectedItem?.ToString();
                    string division = cmbDivision.SelectedItem?.ToString();
                    string crimeType = cmbCrimeType.SelectedItem?.ToString();
                    string weapon = cmbWeapon.SelectedItem?.ToString();
                    string year = cmbYear.SelectedItem?.ToString();
                    string selectedTime = cmbTime.SelectedItem?.ToString();
                    string age_group = cmbAgeGroup.SelectedItem?.ToString();
                    string victim_sex = cmbGender.SelectedItem?.ToString();

                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1"; // Start with a true condition to allow easy appending

                    // Add conditions for each selected value, excluding nulls (not selected)
                    if (!string.IsNullOrEmpty(district))
                        whereClause += $" AND District = '{district}'";

                    if (!string.IsNullOrEmpty(division))
                        whereClause += $" AND Division = '{division}'";

                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND CrimeType = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND Weapon = '{weapon}'";

                    if (!string.IsNullOrEmpty(year))
                        whereClause += $" AND Year = '{year}'";
                    
                   
                    if (!string.IsNullOrEmpty(selectedTime))
                        whereClause += $" AND [day/night] = '{selectedTime}'";
                     
                    if (!string.IsNullOrEmpty(age_group))
                        whereClause += $" AND Age_Group = '{age_group}'";

                    if (!string.IsNullOrEmpty(victim_sex))
                        whereClause += $" AND victim_sex = '{victim_sex}'";

                    // Final SQL query
                    string query = "SELECT * FROM crime_data " + whereClause;

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dataGridView1.DataSource = table;
                    }
                }
                }
                catch (Exception ex)
                {
                    // Log or display the exception
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }




        private List<string> GetDistinctValues(string category)
        {
            List<string> values = new List<string>();

            // Your database connection string
            string connectionString = "Data Source=crime_db.db;Version=3";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Execute a query to retrieve distinct values for the specified category
                string sqlQuery = $"SELECT DISTINCT \"{category}\"  FROM crime_data";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            values.Add(reader[category].ToString());
                        }
                    }
                }
            }

            return values;
        }

        private void PopulateComboBox(ComboBox comboBox, string category)
        {
            // Retrieve distinct values for the specified category from the database
            List<string> values = GetDistinctValues(category);

            // Clear existing items and add new items to the ComboBox
            comboBox.Items.Clear();
            comboBox.Items.AddRange(values.ToArray());
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes for different categories
            PopulateComboBox(cmbDistrict, "District");           PopulateComboBox(cmbGender, "victim_sex");
            PopulateComboBox(cmbDivision, "division");   PopulateComboBox(cmbCrimeType, "crimeType");
            PopulateComboBox(cmbYear, "Year");PopulateComboBox(cmbAgeGroup, "age_group");
            PopulateComboBox(cmbWeapon, "Weapon");
            PopulateComboBox(cmbTime, "day/night"); 
 
            
         
            // Add more ComboBoxes for other categories as needed
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected district
            string selectedDistrict = cmbDistrict.SelectedItem?.ToString();

            // Do something with the selected district
            MessageBox.Show("Selected District: " + selectedDistrict);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected year
            string selectedYear = cmbYear.SelectedItem?.ToString();

            // Do something with the selected year
            MessageBox.Show("Selected Year: " + selectedYear);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cmbWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void search_data_in_database_Load(object sender, EventArgs e)
        {

        }
    }
}
