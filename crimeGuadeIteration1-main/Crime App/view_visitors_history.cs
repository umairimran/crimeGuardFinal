using Deedle.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class view_visitors_history : Form
    {
        public view_visitors_history()
        {
            InitializeComponent();
            fillIdComboBox(selectVisitorId, "select visitorId  as id from visitor_history");
            fillIdComboBox(selectPrisonerId, "select prisonerId  as id from visitor_history ");
            fillIdComboBox2(selectPrisonerName, "select prisonerName as id  from visitor_history ");
            fillIdComboBox2(selectVisitorName, "select distinct visitorName  as id from visitor_history");
            fillIdComboBox2(selectPurposeOfVisit, "select  DISTINCT purposeOfVisit as id from visitor_history");
            fillIdComboBox2(selectDurationOfVisit, "select  DISTINCT durationOfVisit as id from visitor_history");
            prison_management_system_module m = new prison_management_system_module();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new System.Drawing.Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void view_visitors_history_Load(object sender, EventArgs e)
        {

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
                int id = System.Convert.ToInt32(reader["id"]);
                distinctIDs.Add(id);

            }
            foreach (int id in distinctIDs)
            {
                c.Items.Add(id);
            }
      
        
        
        }

        public void fillIdComboBox2(ComboBox c, string query)
        {
            List<string> distinctIDs = new List<string>();
            new_prisoner_form n = new new_prisoner_form();

            SQLiteDataReader reader = n.Db_Read(query);
            while (reader.Read())
            {
                string id = (reader["id"].ToString());
                distinctIDs.Add(id);

            }
            foreach (string id in distinctIDs)
            {
                c.Items.Add(id);
            }
        }



        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=fir_db.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                try
                {
                    string district = selectPrisonerId.SelectedItem?.ToString();
                    string division = selectVisitorId.SelectedItem?.ToString();
                    string crimeType = selectPrisonerName.SelectedItem?.ToString();
                    string weapon = selectVisitorName.SelectedItem?.ToString();
                    string year = selectPurposeOfVisit.SelectedItem?.ToString();
                    string selectedTime = selectDurationOfVisit.SelectedItem?.ToString();

                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1"; // Start with a true condition to allow easy appending

                    // Add conditions for each selected value, excluding nulls (not selected)
                    if (!string.IsNullOrEmpty(district))
                        whereClause += $" AND prisonerid = '{district}'";

                    if (!string.IsNullOrEmpty(division))
                        whereClause += $" AND visitorId = '{division}'";

                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND prisonerName = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND visitorName = '{weapon}'";

                    if (!string.IsNullOrEmpty(year))
                        whereClause += $" AND purposeOfVisit = '{year}'";


                    if (!string.IsNullOrEmpty(selectedTime))
                        whereClause += $" AND durationOfVisit = '{selectedTime}'";


                    // Final SQL query
                    string query = "SELECT * FROM visitor_history " + whereClause;

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Columns.Add("prisonerId", typeof(int));
                            table.Columns.Add("visitorId", typeof(int));
                            table.Columns.Add("prisonerName", typeof(string));
                            table.Columns.Add("visitorName", typeof(string));
                            table.Columns.Add("purposeOfVisit", typeof(string));
                            table.Columns.Add("durationOfVisit", typeof(string));
                            // Assuming this is also a string

                            while (reader.Read())
                            {
                                int prisonerId = reader.GetInt32(reader.GetOrdinal("prisonerId"));
                                int visitorId = reader.GetInt32(reader.GetOrdinal("visitorId"));
                                string purposeOfVisit = reader["purposeOfVisit"].ToString();
                                string durationOfVisit = reader["durationOfVisit"].ToString();
                                string prisoner_name = reader["prisonerName"].ToString();
                                string visitor_name = reader["visitorName"].ToString();

                                table.Rows.Add(prisonerId, visitorId,prisoner_name,visitor_name, purposeOfVisit, durationOfVisit);
                            }

                            dataGridView1.DataSource = table;
                        }


                    }
                }
                catch (Exception ex)
                {
                    // Log or display the exception
                    System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            staff_management_module s = new staff_management_module();
            s.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectPurposeOfVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectDurationOfVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
