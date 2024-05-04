using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class Form7 : Form
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
        private void LoadData()
        {
            GlobalDatabaseConnection.Initialize();

            string query = @"
                           SELECT *
                           FROM complaint_details
                           JOIN fir_report ON complaint_details.complaintNo = fir_report.id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, GlobalDatabaseConnection.GetConnection()))
            {
                

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            // Close the connection after use
            GlobalDatabaseConnection.CloseConnection();
        }
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            LoadData();
        }
       

       


        private List<string> GetDistinctValues(string category)
        {
            List<string> values = new List<string>();

            // Your database connection string
            string connectionString = @"Data Source=C:\Users\Akhyar\OneDrive\Desktop\Crime Guard\crimeGuadeIteration1\Crime App\fir_db.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Execute a query to retrieve distinct values for the specified category
                string sqlQuery = $"SELECT DISTINCT \"{category}\"  FROM complaint_details JOIN fir_report ON complaint_details.complaintNo = fir_report.id";

                          

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Dashboard d = new Dashboard();
            d.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {


        }
    }
}
