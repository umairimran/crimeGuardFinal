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
    public partial class doctor_reports_database_view : Form
    {
        public doctor_reports_database_view()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            fillIdComboBox(selectDoctorId, "select doctorId  as id from  medicalreport");
            fillIdComboBox(selectPrisonerId, "select prisonerid  as id from medicalreport");
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
        public SQLiteDataReader Db_Read(string query)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            // Add the parameter
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        private void selectDoctorId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=fir_db.db;Version=3;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string doctor_id = selectDoctorId.SelectedItem?.ToString();
                    string prisoner_id = selectPrisonerId.SelectedItem?.ToString();
                    string whereClause = "Where 1=1 ";
                    string whereClause2 = "Where 1=1 ";
                    if (!string.IsNullOrEmpty(doctor_id))
                    {
                        whereClause += $"and doctorId='{doctor_id}'";
                    }
                    if (!string.IsNullOrEmpty(prisoner_id))
                    {
                        whereClause += $"and prisonerid='{prisoner_id}'";



                    }
                    string query_toGet_prisoner_cell = "select * from medicalReport " + whereClause;

                    using (SQLiteCommand cmd = new SQLiteCommand(query_toGet_prisoner_cell, connection))
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

        private void doctor_reports_database_view_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            doctor_management_module d = new doctor_management_module();
            d.Show();
        }
    }
}
