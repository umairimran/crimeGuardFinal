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
    public partial class view_staff : Form
    {
        public view_staff()
        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            view_activity_in_data_view v = new view_activity_in_data_view();
            v.fillIdComboBox2(staffPosition, "select DISTINCT position as id from staff");
            v.fillIdComboBox2(staffDepartment, "select DISTINCT department as id from staff");
            v.fillIdComboBox2(staffTrainingCertification, "select DISTINCT trainingCertifications as id  from staff");;
            v.fillIdComboBox2(staffAccessRights, "select DISTINCT accessRights  as id from staff");
        }

        private void view_staff_Load(object sender, EventArgs e)
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
                    string district = staffGender.SelectedItem?.ToString();
                    string division = staffPosition.SelectedItem?.ToString();
                    string crimeType = staffDepartment.SelectedItem?.ToString();
                    string weapon = staffTrainingCertification.SelectedItem?.ToString();
                    string accessRights = staffAccessRights.SelectedItem?.ToString();
                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1 "; // Start with a true condition to allow easy appending
                    string whereClause2 = "WHere 1=1 ";
                    // Add conditions for each selected value, excluding nulls (not selected)
                    if (!string.IsNullOrEmpty(district))
                        whereClause += $" AND gender = '{district}'";

                    if (!string.IsNullOrEmpty(division))
                        whereClause += $" AND position = '{division}'";

                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND department = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND trainingCertifications = '{weapon}'";

                    if (!string.IsNullOrEmpty(accessRights))
                        whereClause += $" AND accessRights = '{accessRights}'";


                    // Final SQL query
                    string query = "SELECT * FROM staff " + whereClause;
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();


                            table.Columns.Add("gender", typeof(string));
                            table.Columns.Add("position", typeof(string));
                            table.Columns.Add("department", typeof(string));
                            table.Columns.Add("trainingCertifications", typeof(string));
                            table.Columns.Add("accessRights", typeof(string));
                            while (reader.Read())
                            {
                                string activityName = reader["gender"].ToString();
                                string duration = reader["position"].ToString();
                                string department = reader["department"].ToString();
                                string trainingCertificaiton = reader["trainingCertifications"].ToString();
                                string accessRightss = reader["accessRights"].ToString();

                                table.Rows.Add(activityName, duration, department, trainingCertificaiton, accessRightss);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            staff_management_module s = new staff_management_module();
            s.Show();
        }
    }
}
