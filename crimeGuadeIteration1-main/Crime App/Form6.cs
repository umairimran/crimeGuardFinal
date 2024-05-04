using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Crime_App
{
    /*richTextBox1
     * richTextBox7
     * richTextBox4
     * richTextBox8
     * richTextBox14
     * richTextBox22
     * comboBox1
     * richTextBox16
     * comboBox2
     * comboBox3
     * comboBox4
     * comboBox8
     * richTextBox20
     */
    public partial class Form6 : Form
    {
        string id;
        public Form6()
        {
            InitializeComponent();
        }
        private void setid(string id)
        {
            this.id=id;
        }
        private string getid()
        {
            return this.id;
        }
        public Form6(string id)
        {
            InitializeComponent();
            setid(id);
            RetrieveComplaintDetails(getid());
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void RetrieveComplaintDetails(string id)
        {
            GlobalDatabaseConnection.Initialize();
            SQLiteConnection conn = GlobalDatabaseConnection.GetConnection();

            try
            {
                string query = "SELECT * FROM complaint_details WHERE id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Using parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // If there's data in the reader
                        {
                            
                            richTextBox1.Text = reader["phoneNumber"].ToString();
                            richTextBox7.Text = reader["name"].ToString();
                            richTextBox4.Text = reader["fathername"].ToString();
                            richTextBox8.Text = reader["cnic"].ToString();
                            richTextBox14.Text = reader["userEmail"].ToString();
                            richTextBox22.Text = reader["LANDLINE"].ToString();
                            comboBox1.Text = reader["gender"].ToString();
                            richTextBox16.Text = reader["age"].ToString();
                            comboBox2.Text = "Pakistan";
                            comboBox3.Text = reader["province"].ToString();
                            comboBox4.Text = reader["homeDistrict"].ToString();
                            comboBox8.Text = reader["homePoliceStation"].ToString();
                            richTextBox20.Text = reader["address"].ToString();
                          
                        }
                        else
                        {
                            MessageBox.Show("No record found with ID: " + id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


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



        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
