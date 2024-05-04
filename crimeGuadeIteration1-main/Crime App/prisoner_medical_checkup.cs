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
    public partial class prisoner_medical_checkup : Form
    {
        public prisoner_medical_checkup()
        {
            InitializeComponent();

            fillIdComboBox(selectPrisonerId, "select distinct p_id as id from prisoners");

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
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();

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
        private void selectPrisonerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
