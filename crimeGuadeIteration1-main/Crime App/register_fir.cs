using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.RightsManagement;
using System.Data.SQLite;
using static Deedle.Addressing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


namespace Crime_App
{

   
    public partial class register_fir : Form
    {
        

        public static class GlobalDatabaseConnection
        {
            private static SQLiteConnection connection;
            private static string connectionString = @"Data Source=fir_db.db;Version=3;";

            public static void Initialize()
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }

            public static SQLiteConnection GetConnection()
            {
                if (connection == null)
                {
                    throw new Exception("Database connection has not been initialized.");
                }

                return connection;
            }

            public static void CloseConnection()
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
        public register_fir()
        {
            InitializeComponent();
            GenderComboBoxFill();
            CountryComboBoxFill();
            ProvinceComboBoxFill();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            HomeDistrictComboBoxFill();
            PoliceStationComboBoxFill();
            // Create a Panel control
            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Fill;
            panel1.BackColor = Color.Transparent; // Set the Panel's BackColor to Transparent

            // Create a RichTextBox control
            RichTextBox richTextBox17 = new RichTextBox();
            richTextBox17.Dock = DockStyle.Fill;

            // Add the RichTextBox control to the Panel
            panel1.Controls.Add(richTextBox17);

            // Add the Panel control to your form or another container
            this.Controls.Add(panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox1_Leave(object sender, EventArgs e)
        {

        }


        private void richTextBox1_(object sender, EventArgs e)
        {



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox30_TextChanged(object sender, EventArgs e)
        {

        }


        private bool CheckPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length <= 11/* || !phoneNumber.StartsWith("03")*/)
            {
                return false;
            }
            return true;
        }

        private bool CheckCnic(string cnic)
        {
            // Checking length
            if (cnic.Length <=13)
                return false;

            return true;

        }


        private void GenderComboBoxFill() {

            string[] options = { "Male", "Female", "Other" };
            comboBox1.Items.AddRange(options);


        }
        private void CountryComboBoxFill()
        {

            string[] options = { "Pakistan" };
            comboBox2.Items.AddRange(options);


        }

        private void PoliceStationComboBoxFill()
        {
            GlobalDatabaseConnection.Initialize();
            try
            {
                string sql = "SELECT DISTINCT homePoliceStation FROM complaint_details;";
                using (SQLiteCommand command = new SQLiteCommand(sql, GlobalDatabaseConnection.GetConnection()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string PolicStations = reader.GetString(0);
                            comboBox8.Items.Add(PolicStations);
                        }
                    }
                }

                comboBox3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            GlobalDatabaseConnection.CloseConnection();
        }
        private void HomeDistrictComboBoxFill()
        {
            GlobalDatabaseConnection.Initialize();
            try
            {
                string sql = "SELECT DISTINCT homeDistrict FROM complaint_details;";
                using (SQLiteCommand command = new SQLiteCommand(sql, GlobalDatabaseConnection.GetConnection()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string homeDistrict = reader.GetString(0);
                            comboBox4.Items.Add(homeDistrict);
                        }
                    }
                }

                //comboBox4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            GlobalDatabaseConnection.CloseConnection();
        }
        private void ProvinceComboBoxFill()
        {

            GlobalDatabaseConnection.Initialize();
            try
            {
                string sql = "SELECT DISTINCT province FROM complaint_details;";
                using (SQLiteCommand command = new SQLiteCommand(sql, GlobalDatabaseConnection.GetConnection()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string province = reader.GetString(0);
                            comboBox3.Items.Add(province);
                        }
                    }
                }

                comboBox3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            GlobalDatabaseConnection.CloseConnection();
        }
        private void InsertData(string phoneNumber, string name, string fatherName, string cnic, string email, string landline, string gender, int age, string province, string homeDistrict, string homePoliceStation, string address)
        {
            try
            {
                // Initialize the SQLite database connection
                GlobalDatabaseConnection.Initialize();

                // Define the SQL query with parameters
                string sql =
                    "INSERT INTO complaint_details " +
                    "(phoneNumber, name, fatherName, cnic, userEmail, age, gender, province, homeDistrict, homePoliceStation, address, LANDLINE) " +
                    "VALUES (@PhoneNumber, @Name, @FatherName, @Cnic, @UserEmail, @Age, @Gender, @Province, @HomeDistrict, @HomePoliceStation, @Address, @Landline)";

                // Create a new SQLite command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(sql, GlobalDatabaseConnection.GetConnection()))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@FatherName", fatherName);
                    command.Parameters.AddWithValue("@Cnic", cnic);
                    command.Parameters.AddWithValue("@UserEmail", email);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Province", province);
                    command.Parameters.AddWithValue("@HomeDistrict", homeDistrict);
                    command.Parameters.AddWithValue("@HomePoliceStation", homePoliceStation);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Landline", landline);

                    // Execute the SQLite command
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Inserted Data Successful");
            }
            catch (Exception ex)
            {
                // Handle exceptions, log errors, or display error messages as needed
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                // Close the SQLite database connection
                GlobalDatabaseConnection.CloseConnection();
            }
        }

        private bool CheckEmail(string email)
        {
            //string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            //// Create Regex object
            //Regex regex = new Regex(pattern);

            //// Check if email matches the format
            //if (!regex.IsMatch(email))
            //{
            //    return false;
            //}

            // Email is valid
            return true;
        }
        public static bool IsPakistaniLandline(string phoneNumber)
        {
            // Regular expression pattern for Pakistani landline number
            //string pattern = @"^\d{3} \d{7}$";

            //// Check if the input matches the pattern
            //return Regex.IsMatch(phoneNumber, pattern);
            return true;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StringBuilder validationErrors = new StringBuilder();

            string phoneNumber = richTextBox1.Text.ToString().Trim();
            if (!CheckPhoneNumber(phoneNumber))
            {
                validationErrors.AppendLine("Invalid phone number: " + phoneNumber);
            }

            string name = richTextBox7.Text.ToString().Trim();
            if (string.IsNullOrEmpty(name))
            {
                validationErrors.AppendLine("Invalid Name");
            }


            string fatherName = richTextBox4.Text.Trim();
            if (string.IsNullOrEmpty(fatherName))
            {
                validationErrors.AppendLine("Invalid fatherName");
            }
            string cnic = richTextBox8.Text.ToString().Trim();
            if (!CheckCnic(cnic))
            {
                validationErrors.AppendLine("Invalid CNIC (XXXXXXXXXXXXX): " + cnic);
            }

            string email = richTextBox14.Text.ToString().Trim();
            if (!CheckEmail(email))
            {
                validationErrors.AppendLine("Invalid Email " + email);
            }


            string landline= richTextBox22.Text.ToString().Trim();
            if (!IsPakistaniLandline(landline) && !string.IsNullOrEmpty(landline))
            {
                validationErrors.AppendLine("Invalid landline " + email);
            }


            string Gender = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(Gender))
            {
                validationErrors.AppendLine("Enter a Gender");
            }

            string ageString = richTextBox16.Text.Trim();
            int age;

            if (!int.TryParse(ageString, out age) || age <= 0)
            {
                validationErrors.AppendLine("Invalid Age: " + ageString);
            }


            string country =comboBox2.Text.Trim();
            if (string.IsNullOrEmpty(country))
            {
                validationErrors.AppendLine("Invalid Country");
            }

            //string Province= comboBox3.SelectedItem?.ToString();
            string Province= comboBox3.Text.Trim();
            if (string.IsNullOrEmpty(Province))
            {
                validationErrors.AppendLine("Invalid Province");
            }

            string HomeDistrict= comboBox4.Text.Trim();
            if (string.IsNullOrEmpty(HomeDistrict))
            {
                validationErrors.AppendLine("Invalid Home District");
            }

            string HomePoliceStation= comboBox8.Text.Trim();
            if (string.IsNullOrEmpty(HomePoliceStation))
            {
                validationErrors.AppendLine("Invalid Home Police Station");
            }

            string Address = richTextBox20.Text.Trim();
            if (string.IsNullOrEmpty(Address))
            {
                validationErrors.AppendLine("Invalid Address");
            }






            if (validationErrors.Length > 0)
            {
                MessageBox.Show(validationErrors.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertData(phoneNumber, name, fatherName, cnic, email, landline, Gender, age, Province, HomeDistrict, HomePoliceStation, Address);
                Info_Report Report = new Info_Report();
                Report.Show();
            }
        }

        private void richTextBox22_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox21_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox20_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox18_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void register_fir_Load(object sender, EventArgs e)
        {

        }
    }
}
