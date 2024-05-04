using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class Info_Report : Form
    {
        string filepath;


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

        private void HomeDistrictComboBoxFill()
        {
            GlobalDatabaseConnection.Initialize();
            try
            {
                string sql = "SELECT DISTINCT  district FROM fir_report;";
                using (SQLiteCommand command = new SQLiteCommand(sql, GlobalDatabaseConnection.GetConnection()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string homeDistrict = reader.GetString(0);
                            comboBox1.Items.Add(homeDistrict);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            GlobalDatabaseConnection.CloseConnection();
        }
        public Info_Report()
        {
            InitializeComponent();
            HomeDistrictComboBoxFill();
            comboBox3.Items.AddRange(new string[] { "Yes", "No" });
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Info_Report_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder validationErrors = new StringBuilder();

            DateTime dateOfIncident = dateTimePicker1.Value.Date;
            if (dateOfIncident > DateTime.Now.Date)
            {
                validationErrors.AppendLine("Invalid Date: " + dateOfIncident.ToString("yyyy-MM-dd"));
            }
            string placeofIncident = richTextBox2.Text.ToString().Trim();
            if (string.IsNullOrEmpty(placeofIncident))
            {
                validationErrors.AppendLine("Invalid Place of Incident"+ placeofIncident);
            }

            string DistrictofIncident = comboBox1.Text.Trim();
            if (string.IsNullOrEmpty(DistrictofIncident))
            {
                validationErrors.AppendLine("Invalid District of Incident");
            }



            string PSJurisdiction = comboBox2.Text.Trim();//.Trim();

            if (string.IsNullOrEmpty(PSJurisdiction))
            {
                validationErrors.AppendLine("Invalid  Police Jurisdiction");
            }

            string DetailsofIncident = richTextBox14.Text.ToString();//.Trim();
            if (string.IsNullOrEmpty(DetailsofIncident))
            {
                validationErrors.AppendLine("Invalid Incident Details");
            }

            string VisitedorNot = comboBox3.Text.Trim();
            if (string.IsNullOrEmpty(VisitedorNot) || (VisitedorNot.ToLower() != "yes" && VisitedorNot.ToLower() != "no"))
            {
                validationErrors.AppendLine("Invalid Option Selected for visit");
            }


            string visitdetails = richTextBox13.Text.ToString();//.Trim();
            if (string.IsNullOrEmpty(visitdetails))
            {
                validationErrors.AppendLine("Invalid Visit Details");
            }

            DateTime visitdate= dateTimePicker2.Value.Date;
            if (visitdate > DateTime.Now.Date)
            {
                validationErrors.AppendLine("Invalid Date: " + visitdate.ToString("yyyy-MM-dd"));
            }

            


            if (validationErrors.Length > 0)
            {
                MessageBox.Show(validationErrors.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                GlobalDatabaseConnection.Initialize();
                // SQL query to insert data into fir_report
                string insertQuery = @"
    INSERT INTO fir_report (
        dateOfIncident,
        place,
        district,
        policeStation,
        alreadyVisitedStation,
        detailsOfIncident,
        Visit_Details,
        Visit_Date,
        File
    ) VALUES (
        @DateOfIncident,
        @Place,
        @District,
        @PoliceStation,
        @AlreadyVisitedStation,
        @DetailsOfIncident,
        @VisitDetails,
        @VisitDate,
        @File
    )";

                // Use the GlobalDatabaseConnection to get the SQLite connection
                using (SQLiteConnection conn = GlobalDatabaseConnection.GetConnection())
                {
                    // Create a new SQLite command
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        // Define parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@DateOfIncident", dateOfIncident);
                        cmd.Parameters.AddWithValue("@Place", placeofIncident);
                        cmd.Parameters.AddWithValue("@District", DistrictofIncident);
                        cmd.Parameters.AddWithValue("@PoliceStation", PSJurisdiction);
                        cmd.Parameters.AddWithValue("@AlreadyVisitedStation", VisitedorNot);
                        cmd.Parameters.AddWithValue("@DetailsOfIncident", DetailsofIncident);
                        cmd.Parameters.AddWithValue("@VisitDetails", visitdetails);
                        cmd.Parameters.AddWithValue("@VisitDate", visitdate);

                        // Assume you have a method to get the file data
                        byte[] fileData = GetFileData(); // Implement this method to fetch the file data
                        cmd.Parameters.AddWithValue("@File", fileData ?? (object)DBNull.Value); // Handle null file data

                        // Execute the command
                        try
                        {
                            int result = cmd.ExecuteNonQuery();

                            // Check the result
                            if (result > 0)
                            {
                                MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            //GlobalDatabaseConnection.CloseConnection(); 
            



        }
        // Example implementation to get file data (adapt as needed)
        private byte[] GetFileData()
        {
            // Check if the filepath is not null or empty
            if (string.IsNullOrEmpty(this.filepath))
            {
                MessageBox.Show("No file path specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Attempt to read the file data into a byte array
            try
            {
                // Read all bytes from the specified file
                byte[] fileData = File.ReadAllBytes(this.filepath);
                return fileData;
            }
            catch (Exception ex)
            {
                // If there is an error, display it and return null
                MessageBox.Show("Failed to read file data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        // Using FileStream to handle large files
                        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] fileData = new byte[fs.Length];
                            fs.Read(fileData, 0, fileData.Length);
                            //InsertFileIntoDatabase(fileData);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    string fileName = Path.GetFileName(filePath);
                    richTextBox16.AppendText("\t\t"+fileName);
                    setpath(filePath);

                }
                
            }
        }
        private void setpath(string path)
        {
            this.filepath = path;
        }

        private string getpath() {
           return  this.filepath;
        }
        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
           dashboard.Show();
        }
    }
}
