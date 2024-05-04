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
    public partial class view_complete_bellongings : Form
    {
        public view_complete_bellongings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            view_activity_in_data_view v = new view_activity_in_data_view();
            v.fillIdComboBox(selectBellongingId, "select belongingid as id from prisonerBelongings");
            v.fillIdComboBox(selectPrisonerId, "select prisonerid as id from prisonerbelongings");
            v.fillIdComboBox2(selectItemName, "select  distinct itemname as id from prisonerbelongings");
            v.fillIdComboBox2(selectCondition, "select distinct condition as id from prisonerbelongings");
            v.fillIdComboBox2(selectStorageLocation, "select distinct storagelocation as id from prisonerbelongings");
            v.fillIdComboBox2(selectStatus, "select distinct status as id from prisonerbelongings");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=fir_db.db;Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                try
                {
                    string district = selectBellongingId.SelectedItem?.ToString();
                    string division = selectPrisonerId.SelectedItem?.ToString();
                    string crimeType = selectCondition.SelectedItem?.ToString();
                    string weapon = selectItemName.SelectedItem?.ToString();
                    string accessRights = selectStatus.SelectedItem?.ToString();
                    string storage_location = selectStorageLocation.SelectedItem?.ToString();

                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1 "; // Start with a true condition to allow easy appending
                    if (!string.IsNullOrEmpty(storage_location))
                    {
                        whereClause += $" and storagelocation = '{storage_location}' ";
                    }
                    // Add conditions for each selected value, excluding nulls (not selected)
                    if (!string.IsNullOrEmpty(district))
                        whereClause += $" AND belongingid = '{district}'";

                    if (!string.IsNullOrEmpty(division))
                        whereClause += $" AND prisonerid = '{division}'";

                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND condition = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND itemname = '{weapon}'";

                    if (!string.IsNullOrEmpty(accessRights))
                        whereClause += $" AND status = '{accessRights}'";


                    // Final SQL query
                    string query = "SELECT * FROM prisonerbelongings " + whereClause;
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();


                            table.Columns.Add("belongingid", typeof(string));
                            table.Columns.Add("prisonerid", typeof(string));
                            table.Columns.Add("itemname", typeof(string));
                            table.Columns.Add("condition", typeof(string));
                            table.Columns.Add("storagelocation", typeof(string));
                            table.Columns.Add("status", typeof(string));
                     
                            table.Columns.Add("notes", typeof(string));
                            while (reader.Read())
                            {
                                string belongingid = reader["belongingid"].ToString();
                                string prisonerid = reader["prisonerid"].ToString();
                                string itemname = reader["itemname"].ToString();
                                string condition = reader["condition"].ToString();
                                string storagelocation = reader["storagelocation"].ToString();
                                string status = reader["status"].ToString();
                              
                                string notes = reader["notes"].ToString();

                                table.Rows.Add(belongingid, prisonerid, itemname, condition, storagelocation, status, notes);
                            }

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

        private void view_complete_bellongings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personalBelongingsManagementPortal p = new personalBelongingsManagementPortal();
            p.Show();
        }
    }
}
