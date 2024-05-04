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
    public partial class viewParticularCell : Form
    {
        public viewParticularCell()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            fillIdComboBox(selectCellId, "select distinct cellid  as id from cell");
        }
        public SQLiteDataReader Db_Read(string query, int prisonerId)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            selectCommand.Parameters.AddWithValue("@prisonerId", prisonerId); // Add the parameter
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        public SQLiteDataReader Db_Read(string query)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
           
            SQLiteDataReader reader = selectCommand.ExecuteReader();
           
            return reader;
        }
        public void fillIdComboBox(ComboBox c, string query)
        {
            List<int> distinctIDs = new List<int>();
            new_prisoner_form n = new new_prisoner_form();

            SQLiteDataReader reader = Db_Read(query);
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

        private void selectCellId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectCellId.SelectedItem == null)
            {
                MessageBox.Show("Please select a Cell ID.");
                return;
            }
            cellNumber.Clear();
            cellCapacity.Clear();
            cellOccupancy.Clear();
            status.Clear();
            desctiption.Clear();
            securityLevel.Clear();
            maintainanceNotes.Clear();
            lastInspectionDate.Clear();
            nextInspectionDate.Clear();
            cleanliness.Clear();
            accessibility.Clear();
            int cell_id =Convert.ToInt32(selectCellId.SelectedItem);
            SQLiteDataReader reader = Db_Read("select cellNumber, capacity, occupancy, status, description, securityLevel, maintenanceNotes, lastInspectionDate, nextInspectionDate, cleanliness, accessibility  from cell where cellId = @prisonerId", cell_id);
            if (reader !=null && reader.Read())
            {
                cellNumber.AppendText(cell_id.ToString());
                cellNumber.Text = cell_id.ToString();
                cellCapacity.AppendText(reader["capacity"].ToString());
                cellOccupancy.AppendText(reader["occupancy"].ToString());
                status.AppendText(reader["status"].ToString());
                desctiption.AppendText(reader["description"].ToString());
                securityLevel.AppendText(reader["securityLevel"].ToString());
                maintainanceNotes.AppendText(reader["maintenanceNotes"].ToString());
                lastInspectionDate.AppendText(reader["lastInspectionDate"].ToString());
                nextInspectionDate.AppendText(reader["nextInspectionDate"].ToString());
                cleanliness.AppendText(reader["cleanliness"].ToString());
                accessibility.AppendText(reader["accessibility"].ToString());


            }
        }

        private void viewParticularCell_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cellNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
