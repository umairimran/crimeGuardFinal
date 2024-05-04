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
    public partial class assign_cell_staff : Form
    {
        public assign_cell_staff()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;

            fillIdComboBox(cellId, "select cellid  as id from cell where  cellid not in(select cellid from staff_cell)");
            fillIdComboBox(staffId, "select staffId as id from Staff where staffid not in(select staffid from staff_cell ) ");

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
        private void assign_cell_staff_Load(object sender, EventArgs e)
        {

        }
        private bool IsCellNumberExists(int cellNumber, int staff_id)
        {
            // Check if the cell number already exists in the database
            string query = "SELECT COUNT(*) FROM staff_cell WHERE cellid = @cellNumber and staffId=@staff_id";
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cellNumber", cellNumber);

                    command.Parameters.AddWithValue("@staff_id", staff_id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cell_number;
            int staff_number;

            if (int.TryParse(cellId.SelectedItem?.ToString(), out cell_number) &&
                int.TryParse(staffId.SelectedItem?.ToString(), out staff_number))
            {
                // Parsing succeeded, 'cell_number' and 'staff_number' now contain the parsed integer values
            }
            else
            {
                // Parsing failed, 'cell_number' and/or 'staff_number' will be 0
                // Display an error message to the user or handle the error appropriately
                MessageBox.Show("Please select valid integer values for the cell and staff IDs.", "Invalid Input");
                return;
            }
            if (IsCellNumberExists(cell_number, staff_number))
            {
                MessageBox.Show("Cell number already exists. Please enter a different cell number.");
                return;
            }

            string query = @"insert into staff_cell (cellId,staffId) values(@cell_number,@staffId)";
            string connectionString = "Data Source=fir_db.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@cell_number", cell_number);
                    command.Parameters.AddWithValue("@staffId", staff_number);


                    command.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Staff Assigned successfully !!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_staff v = new view_staff();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }
    }
}
