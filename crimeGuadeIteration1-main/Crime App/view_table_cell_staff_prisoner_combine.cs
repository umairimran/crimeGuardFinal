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
    public partial class view_table_cell_staff_prisoner_combine : Form
    {

        public view_table_cell_staff_prisoner_combine()
        {
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            fillIdComboBox(selectCellid, "select cellid  as id from staff_cell");
            fillIdComboBox(selectPrisonerId, "select prisonerId as id from prisoners_cell");
            fillIdComboBox(selectCellId2, "select cellid  as id from staff_cell");
            fillIdComboBox(selectStaffId, "select staffId as id from staff_cell");



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

        private void view_table_cell_staff_prisoner_combine_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=fir_db.db;Version=3;";
            using (SQLiteConnection connection=new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string cell_id = selectCellid.SelectedItem?.ToString();
                    string cell_id2 = selectCellId2.SelectedItem?.ToString();
                    string prisoner_id=selectPrisonerId.SelectedItem?.ToString();
                    string staff_id=selectStaffId.SelectedItem?.ToString();
                    string whereClause = "Where 1=1 ";
                    string whereClause2 = "Where 1=1 ";
                    if (!string.IsNullOrEmpty(cell_id))
                    {
                        whereClause+=$"and cellid='{cell_id}'";
                    }
                    if (!string.IsNullOrEmpty(prisoner_id))
                    {
                        whereClause += $"and prisonerid='{prisoner_id}'";
                    }
                    if (!string.IsNullOrEmpty(cell_id2))
                    {
                        whereClause2 += $"and cellid='{cell_id2}'";

                    }
                    if (!string.IsNullOrEmpty(staff_id))
                    {
                        whereClause2 += $"and staffid='{staff_id}'";
                    }
                    string query_toGet_prisoner_cell = "select * from prisoners_cell " + whereClause;
                    string query_toGet_staff_prisoner = "select * from staff_cell " + whereClause2;

                    using (SQLiteCommand cmd = new SQLiteCommand(query_toGet_prisoner_cell, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            prisoner_cell_table.DataSource = table;
                        }
                    }
                    using (SQLiteCommand cmd2 = new SQLiteCommand(query_toGet_staff_prisoner, connection))
                    {
                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            DataTable table2 = new DataTable();
                            table2.Load(reader);
                            staff_cell_table.DataSource = table2;
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

        private void selectPrisonerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cell_management s = new cell_management();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
