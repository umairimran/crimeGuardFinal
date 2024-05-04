using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Data.SQLite;

namespace Crime_App
{
    public partial class prison_management_system_module : Form
    {

        public prison_management_system_module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }
        private Dictionary<string, int> GetCountsFromDataBase(string word,string query)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // Establish connection to the SQLite database
            string connectionString = "Data Source=fir_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query dynamically based on the value of word and filter
                


                // Create a command to execute SQL query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the command and read the results
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = reader[word] != DBNull.Value ? reader[word].ToString() : "NULL";
                            int count = Convert.ToInt32(reader["count"]);
                            counts.Add(key, count);
                        }
                    }
                }
            }

            return counts;
        }

        public void load_pie_chart(string word, string query, LiveCharts.WinForms.PieChart chart)
        {
            Dictionary<string, int> weaponCounts = GetCountsFromDataBase(word,query);

            // Define a color palette for the slices
            List<System.Windows.Media.Color> colors = new List<System.Windows.Media.Color>
             {

            System.Windows.Media.Color.FromRgb(0, 122, 204),   // Blue
           System.Windows.Media.Color.FromRgb(0, 158, 115),   // Green
           System.Windows.Media. Color.FromRgb(255, 127, 14),  // Orange
         System.Windows.Media.   Color.FromRgb(255, 0, 0),     // Red
           System.Windows.Media. Color.FromRgb(128, 0, 128)    // Purple
        // Add more colors as needed
             };

            // Create a series collection for the pie chart
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            // Add pie series for each weapon count
            int colorIndex = 0;
            foreach (var kvp in weaponCounts)
            {
                // Create a pie series for the current weapon
                PieSeries pieSeries = new PieSeries
                {
                    Title = kvp.Key,
                    Values = new ChartValues<int> { kvp.Value },
                    DataLabels = true,
                    Fill = new SolidColorBrush(colors[colorIndex % colors.Count]), // Set slice color
                    LabelPoint = chartPoint => string.Format("{0} ({1})", chartPoint.SeriesView.Title, chartPoint.Y) // Custom label format
                };

                series.Add(pieSeries);

                colorIndex++;
            }

            // Configure the pie chart
            chart.Series = series;
            chart.DefaultLegend.FontFamily = new System.Windows.Media.FontFamily("Segoe UI"); // Set legend font
            chart.DefaultLegend.FontSize = 12; // Set legend font size
            

        }
        private void prisoner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }

        private void activityDepartment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            inventory_department_module v = new inventory_department_module();
            v.Show();

        }

        private void prison_management_system_module_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d = new Dashboard();
            d.Show();
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            prisoner_form p = new prisoner_form();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff_management_module s = new staff_management_module();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personalBelongingsManagementPortal p = new personalBelongingsManagementPortal();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctor_management_module d = new doctor_management_module();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visitor_form v = new visitor_form();

            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            activity_module v = new activity_module();
            v.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }

        private void staff_Paint(object sender, PaintEventArgs e)
        {

        }
     

        public void design(RichTextBox box, ComboBox cBox,string textBoxText,string comboBoxText)
    {
        // Set text properties
        box.Text = textBoxText;
        box.Font = new Font("Arial Black", 36, FontStyle.Bold);
        box.BackColor = System.Drawing.Color.FromArgb(67, 67, 67); // Dark gray
        box.ForeColor = System.Drawing.Color.White;
        box.BorderStyle = BorderStyle.None;
        box.ReadOnly = true;
        box.Size = new Size(237, 40);

        // Set ComboBox properties
        cBox.Text = comboBoxText;
        cBox.Font = new Font("Arial Black", 36, FontStyle.Bold);
        cBox.BackColor = System.Drawing.Color.FromArgb(67, 67, 67); // Dark gray
        cBox.ForeColor = System.Drawing.Color.White;
        cBox.DropDownStyle = ComboBoxStyle.DropDownList;
        cBox.Size = new Size(237, 40);
    }

    private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
