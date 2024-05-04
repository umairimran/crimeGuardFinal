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
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Crime_App
{
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
            InitializeRichTextBox();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            InitializeRichTextBox2();
        }
        private void InitializeRichTextBox()
        {
            richTextBox1.Text = "CNIC";  // Placeholder text
           richTextBox1.ForeColor = Color.Gray;  // Placeholder text color

            // Event subscriptions
            richTextBox1.Enter += richTextBox1_Enter;
            richTextBox1.Leave += richTextBox1_Leave;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

       private void richTextBox1_Enter(object sender, EventArgs e)
{
    // Clear the placeholder text when the control is focused
    if (richTextBox1.Text == "CNIC")
    {
        richTextBox1.Text = "";
    }
}

private void richTextBox1_Leave(object sender, EventArgs e)
{
    // Restore placeholder text if nothing is entered
    if (string.IsNullOrEmpty(richTextBox1.Text))
    {
        richTextBox1.Text = "CNIC";
    }
}

private void richTextBox1_TextChanged(object sender, EventArgs e)
{
    // You might want to load data or filter a grid based on the text.
    if (!string.IsNullOrEmpty(richTextBox1.Text) && richTextBox1.Text != "CNIC")
    {
        LoadData(richTextBox1.Text);
    }
    else
    {
        dataGridView1.DataSource = null;  // Clear the data grid view if no valid text is entered.
    }
}

        private void LoadData(string searchText)
        {
            // Initialize and open the database connection using the GlobalDatabaseConnection class
            GlobalDatabaseConnection.Initialize();

            string query = @"
                           SELECT *
                           FROM complaint_details
                           JOIN fir_report ON complaint_details.complaintNo = fir_report.id
                           WHERE complaint_details.cnic LIKE @SearchText || '%'
                                                                                ";





            using (SQLiteCommand cmd = new SQLiteCommand(query, GlobalDatabaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@SearchText", searchText);

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






        private void InitializeRichTextBox2()
        {
            richTextBox2.Text = "ID NO";  // Placeholder text
                                         // richTextBox1.ForeColor = Color.Gray;  // Placeholder text color

            // Event subscriptions
            richTextBox2.Enter += richTextBox2_Enter;
            richTextBox2.Leave += richTextBox2_Leave;
            richTextBox2.TextChanged += richTextBox2_TextChanged;
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the control is focused
            if (richTextBox2.Text == "ID NO")
            {
                richTextBox2.Text = "";
            }
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if nothing is entered
            if (string.IsNullOrEmpty(richTextBox2.Text))
            {
                richTextBox2.Text = "ID NO";
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            string id=richTextBox2.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                return;
            }
            //if (!string.IsNullOrEmpty(id)) {
            //    GlobalDatabaseConnection.Initialize();
            //    string query1= @"
            //               DELETE 
            //               FROM fir_report
            //               WHERE fir_report.id =@id
            //                                                                    ";

            //    string query2 = @"
            //               DELETE 
            //               FROM complaint_details
            //               WHERE complaint_details.complaintNo =@id
            //                                                                    ";
            //}




            GlobalDatabaseConnection.Initialize();
            using (SQLiteConnection connection = GlobalDatabaseConnection.GetConnection())
            {
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Query 1: Delete from fir_report
                        string query1 = @"
                    DELETE 
                    FROM complaint_details
                    WHERE complaintNo = @id
                ";
                      

                        using (SQLiteCommand command1 = new SQLiteCommand(query1, connection))
                        {
                            command1.Parameters.AddWithValue("@id", id);
                            command1.ExecuteNonQuery();
                        }

                        // Query 2: Delete from complaint_details
                        string query2=@"
                    DELETE 
                    FROM fir_report
                    WHERE id = @id
                ";

                        using (SQLiteCommand command2 = new SQLiteCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@id", id);
                            command2.ExecuteNonQuery();
                        }

                        // Commit transaction if both commands execute successfully
                        transaction.Commit();
                        MessageBox.Show("Both records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Handle exception and rollback transaction
                        transaction.Rollback();
                        MessageBox.Show("Transaction rolled back due to an error: " + ex.Message);
                    }
                }



            }
            string query3 = @"
               SELECT *
               FROM complaint_details
               JOIN fir_report ON complaint_details.complaintNo = fir_report.id
               ";

            GlobalDatabaseConnection.Initialize();
            using (SQLiteConnection connection = GlobalDatabaseConnection.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query3, GlobalDatabaseConnection.GetConnection()))
                {
                    // Ensure that the parameter name matches the one used in your SQL query
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }



                GlobalDatabaseConnection.CloseConnection();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

    
}
