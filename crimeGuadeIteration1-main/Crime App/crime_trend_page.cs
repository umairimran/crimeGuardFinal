using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Definitions.Charts;
using System.Windows.Markup;
using System.Globalization;
using LiveCharts.Wpf.Charts.Base;
using System.Drawing;

namespace Crime_App
{
    public partial class crime_trend_page : Form
    {

        public crime_trend_page()
        {
              InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            load_pie_chart("Weapon","all",pieChart1);
            //chart1.Size = new System.Drawing.Size(800, 600);
            //chart1.Location = new System.Drawing.Point(50, 50);
          
            LoadChartDataFromDatabase();
            Dictionary<int, int> data = GetCrimeCountsByTimeFromDatabase();

            // Load data into the chart
            LoadChartData(cartesianChart5, data);
            data = GetYearlyCrimeCountsFromDatabase("All");
            PlotCrimeTrend(data,cartesianChart1, System.Windows.Media.Colors.Blue,"Yearly Crime Trend");
            PlotCrimeTrendByWeapon("all",cartesianChart2);
            PlotCrimeTrendByDistrict("all", cartesianChart4);

            PlotCrimeTrendByGender("all", cartesianChart3);

            data = GetYearlyCrimeCountsFromDatabase("All");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Blue, "Yearly Crime Trend");

            load_pie_chart("day_night", "All", pieChart3);
            load_pie_chart("victim_sex", "All", pieChart2);
            load_pie_chart("age_group", "All", pieChart4);
            PlotCrimeTrendByAgeGrp("all", cartesianChart6);


            populateNewsFeed();




        }
        public void populateNewsFeed()
        {
            int count = GetCountsFromDataBaseNewsFeed();
            richTextBox7.Clear();
            richTextBox7.AppendText(count.ToString());
            generateDynamicUserControls();


        }
        public void PlotCrimeTrendByWeapon(string filter,LiveCharts.WinForms.CartesianChart chart)
        {
            chart.Series.Clear();
            string where = "Weapon";
            Dictionary<int, int> pistol = GetYearlyCrimeCountsByWeaponFromDatabase("Pistol",where,filter);
            PlotCrimeTrend(pistol, chart, System.Windows.Media.Colors.Blue,"Pistol Trend");
            Dictionary<int, int> sniper = GetYearlyCrimeCountsByWeaponFromDatabase("Sniper Rifle",where, filter);
            PlotCrimeTrend(sniper, chart, System.Windows.Media.Colors.Red,"Sniper Rifle Trend");
            Dictionary<int, int> knife = GetYearlyCrimeCountsByWeaponFromDatabase("Knife",where, filter);
            PlotCrimeTrend(knife, chart, System.Windows.Media.Colors.Green, "Knife Trend");
            Dictionary<int, int> shotgun = GetYearlyCrimeCountsByWeaponFromDatabase("Shotgun",where, filter);
            PlotCrimeTrend(shotgun, chart, System.Windows.Media.Colors.Orange, "Shotgun Trend");

            Dictionary<int, int> grenade = GetYearlyCrimeCountsByWeaponFromDatabase("Grenade",where, filter);
            PlotCrimeTrend(grenade, chart, System.Windows.Media.Colors.Yellow, "Grenade Trend");

            Dictionary<int, int> rifle = GetYearlyCrimeCountsByWeaponFromDatabase("Rifle",where, filter);
            PlotCrimeTrend(rifle, chart, System.Windows.Media.Colors.Purple, "Rifle Trend");




        }

        public void PlotCrimeTrendByGender(string filter, LiveCharts.WinForms.CartesianChart chart)
        {
            chart.Series.Clear();
            string where = "Victim_Sex";
            Dictionary<int, int> pistol = GetYearlyCrimeCountsByWeaponFromDatabase("Male", where, filter);
            PlotCrimeTrend(pistol, chart, System.Windows.Media.Colors.Blue, "Male Trend");
            Dictionary<int, int> sniper = GetYearlyCrimeCountsByWeaponFromDatabase("Female", where, filter);
            PlotCrimeTrend(sniper, chart, System.Windows.Media.Colors.Red, "Female Trend");
            

        }


        public void PlotCrimeTrendByDistrict(string filter, LiveCharts.WinForms.CartesianChart chart)
        {
            chart.Series.Clear();
            string where = "District";
            // Plot crime trend for Bahawalpur
            Dictionary<int, int> bahawalpurData = GetYearlyCrimeCountsByWeaponFromDatabase("Bahawalpur",where, filter);
            PlotCrimeTrend(bahawalpurData, chart, System.Windows.Media.Colors.Blue, "Bahawalpur Trend");

            // Plot crime trend for Bahawalnagar
            Dictionary<int, int> bahawalnagarData = GetYearlyCrimeCountsByWeaponFromDatabase("Bahawalnagar",where, filter);
            PlotCrimeTrend(bahawalnagarData, chart, System.Windows.Media.Colors.Red, "Bahawalnagar Trend");

            // Plot crime trend for Rahim Yar Khan
            Dictionary<int, int> rahimYarKhanData = GetYearlyCrimeCountsByWeaponFromDatabase("R.Y.Khan", where, filter);
            PlotCrimeTrend(rahimYarKhanData, chart, System.Windows.Media.Colors.Green, "R.Y.Khan Trend");

            // Plot crime trend for Dera Ghazi Khan
            Dictionary<int, int> deraGhaziKhanData = GetYearlyCrimeCountsByWeaponFromDatabase("D.G.Khan", where, filter);
            PlotCrimeTrend(deraGhaziKhanData, chart, System.Windows.Media.Colors.Orange, "D.G.Khan Trend");

            // Plot crime trend for Layyah
            Dictionary<int, int> layyahData = GetYearlyCrimeCountsByWeaponFromDatabase("Layyah",where, filter);
            PlotCrimeTrend(layyahData, chart, System.Windows.Media.Colors.Yellow, "Layyah Trend");

            // Plot crime trend for Muzaffargarh
            Dictionary<int, int> muzaffargarhData = GetYearlyCrimeCountsByWeaponFromDatabase("Muzaffargarh", where, filter);
            PlotCrimeTrend(muzaffargarhData, chart, System.Windows.Media.Colors.Purple, "Muzaffargarh Trend");

            // Plot crime trend for Rajanpur
            Dictionary<int, int> rajanpurData = GetYearlyCrimeCountsByWeaponFromDatabase("Rajanpur", where, filter);
            PlotCrimeTrend(rajanpurData, chart, System.Windows.Media.Colors.Cyan, "Rajanpur Trend");

            // Plot crime trend for Faisalabad
            Dictionary<int, int> faisalabadData = GetYearlyCrimeCountsByWeaponFromDatabase("Faisalabad", where, filter);
            PlotCrimeTrend(faisalabadData, chart, System.Windows.Media.Colors.Magenta, "Faisalabad Trend");

            // Plot crime trend for Jhang
            Dictionary<int, int> jhangData = GetYearlyCrimeCountsByWeaponFromDatabase("Jhang", where, filter);
            PlotCrimeTrend(jhangData, chart, System.Windows.Media.Colors.Brown, "Jhang Trend");

            // Plot crime trend for Toba Tek Singh
            Dictionary<int, int> tobaTekSinghData = GetYearlyCrimeCountsByWeaponFromDatabase("T.T.Singh",where, filter);
            PlotCrimeTrend(tobaTekSinghData, chart, System.Windows.Media.Colors.Gray, "T.T.Singh Trend");

            // Add more districts as needed
        }


        public void PlotCrimeTrendByAgeGrp(string filter, LiveCharts.WinForms.CartesianChart chart)
        {
            chart.Series.Clear();
            string where = "age_group"; // Update this variable to match the column name for age group

            // Plot crime trend for Teenager
            Dictionary<int, int> teenagerData = GetYearlyCrimeCountsByWeaponFromDatabase("teenager", where, filter);
            PlotCrimeTrend(teenagerData, chart, System.Windows.Media.Colors.Blue, "Teenager Trend");

            // Plot crime trend for Adult
            Dictionary<int, int> adultData = GetYearlyCrimeCountsByWeaponFromDatabase("adult", where, filter);
            PlotCrimeTrend(adultData, chart, System.Windows.Media.Colors.Red, "Adult Trend");

            // Plot crime trend for Senior Citizen
            Dictionary<int, int> seniorCitizenData = GetYearlyCrimeCountsByWeaponFromDatabase("Senior Citizen", where, filter);
            PlotCrimeTrend(seniorCitizenData, chart, System.Windows.Media.Colors.Green, "Senior Citizen Trend");

            // Add more age group categories as needed

            // Add more districts as needed
        }


        private Dictionary<int, int> GetYearlyCrimeCountsFromDatabase(string crimeType)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            string connectionString = "Data Source=crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query;

                // Check if the crimeType is "All" to determine the query
                if (crimeType == "All")
                {
                    query = "SELECT Year, COUNT(*) AS TotalCount FROM crime_data GROUP BY Year";
                }
                else
                {
                    query = $"SELECT Year, COUNT(*) AS TotalCount FROM crime_data WHERE CrimeType = '{crimeType}' GROUP BY Year";
                }

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Year"] != DBNull.Value && reader["TotalCount"] != DBNull.Value)
                            {
                                int year = Convert.ToInt32(reader["Year"]);
                                int count = Convert.ToInt32(reader["TotalCount"]);
                                counts.Add(year, count);
                            }
                        }
                    }
                }
            }

            return counts;
        }

        private Dictionary<int, int> GetYearlyCrimeCountsByWeaponFromDatabase(string word,string where,string filter)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            string connectionString = "Data Source=crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query;
               
                if (filter.ToLower() == "all")
                {
                    query = $"SELECT Year, COUNT(*) AS count FROM crime_data WHERE {where} = '{word}'  GROUP BY Year";
                }
                else
                {
                    query = $"SELECT Year, COUNT(*) AS count FROM crime_data WHERE {where} = '{word}' AND CrimeType='{filter}' GROUP BY Year";
                }


                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Year"] != DBNull.Value && reader["count"] != DBNull.Value)
                            {
                                int year = Convert.ToInt32(reader["Year"]); Random random = new Random();

                                // Then you can use it to generate random numbers
                                int count = Convert.ToInt32(reader["count"]);// Add a random number between 1 and 10

                                counts.Add(year, count);
                            }
                        }
                    }
                }
            }

            return counts;
        }
        public void PlotCrimeTrend(Dictionary<int, int> yearlyCrimeCounts, LiveCharts.WinForms.CartesianChart chart, System.Windows.Media.Color lineColor,string title)
        {
         
            // Prepare data for plotting
            var years = yearlyCrimeCounts.Keys.OrderBy(year => year);
            var crimeCounts = years.Select(year => yearlyCrimeCounts[year]);

            // Create a LineSeries to plot the crime trend
            var lineSeries = new LiveCharts.Wpf.LineSeries
            {
                Title = title,
                Values = new LiveCharts.ChartValues<int>(crimeCounts),
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 15,
                Stroke = new System.Windows.Media.SolidColorBrush(lineColor) // Set line color
            };

            // Add the LineSeries to the chart
            chart.Series.Add(lineSeries);

            // Customize axis labels and formatting
            chart.AxisX.Clear();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Year",
                Labels = years.Select(year => year.ToString()).ToList(),
                FontSize = 12
            }) ;

            chart.AxisY.Clear();
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Crime Count"
            });
            chart.DataTooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };
        }



        private void LoadChartData(LiveCharts.WinForms.CartesianChart chart, Dictionary<int, int> data)
        {
            // Lists to store x-axis labels and y-axis values
            List<string> xAxisLabels = new List<string>();
            List<int> yAxisValues = new List<int>();

            // Mapping dictionary keys to x-axis labels and adding values to y-axis list
            foreach (var pair in data)
            {
                string label = GetXAxisLabel(pair.Key); // Function to get x-axis label based on dictionary key
                xAxisLabels.Add(label);
                yAxisValues.Add(pair.Value);
            }

            // Clear existing series from the chart
            chart.Series.Clear();

            // Define the bar color
            var barColor = System.Drawing.Color.White; // Change this color as needed

            // Add series to the chart
            chart.Series = new LiveCharts.SeriesCollection
    {
        new ColumnSeries
        {
            Title = "Crime Count",
            Values = new ChartValues<int>(yAxisValues),
            Fill = System.Windows.Media.Brushes.White // Setting bar color
        }
    };

            // Customize x-axis labels
            chart.AxisX.Clear();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time Interval",
                Labels = xAxisLabels.ToArray() // Convert xAxisLabels to an array if it's not already
            });

            // Customize other properties of the chart as needed
        }

        // Function to get x-axis label based on dictionary key (e.g., 0 -> "12am", 1 -> "3am", etc.)
        private string GetXAxisLabel(int key)
        {
            switch (key)
            {
                case 0: return "12am";
                case 1: return "3am";
                case 2: return "6am";
                case 3: return "9am";
                case 4: return "12pm";
                case 5: return "3pm";
                case 6: return "6pm";
                case 7: return "9pm";
                default: return ""; // Add more cases if needed
            }
        }

        private void LoadChartDataFromDatabase()
        {
            try
            {
                // Retrieve data from the database
                Dictionary<string, int> data = GetCountsFromDataBase("crimeType","all");
                string message = "Crime Types:\n";
                foreach (var pair in data)
                {
                    message += $"{pair.Key}: {pair.Value}\n";
                }
                MessageBox.Show(message, "Data from Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear existing series from the chart
                chart1.Series.Clear();

                // Add series to the chart
                foreach (var pair in data)
                {
                    // Create a new series for each pair
                    System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series(pair.Key);

                    // Add data points to the series
                    series.Points.AddXY(pair.Key, pair.Value);
                    series["PixelPointWidth"] = "200";


                    // Add the series to the chart's SeriesCollection
                    chart1.Series.Add(series);
                }

                // Customize other properties of the chart as needed
              
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void load_pie_chart(string word,string filter,LiveCharts.WinForms.PieChart chart)
        {
            Dictionary<string, int> weaponCounts = GetCountsFromDataBase(word,filter);

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
            chart.LegendLocation = LegendLocation.Right; // Position legend to the right
            chart.DefaultLegend.FontFamily = new System.Windows.Media.FontFamily("Segoe UI"); // Set legend font
            chart.DefaultLegend.FontSize = 12; // Set legend font size
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCrimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void murdersBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private int GetCountsFromDataBaseNewsFeed()
        {
            int count = 0;

            // Establish connection to the SQLite database
            string connectionString = "Data Source=crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query to count the records in the crime_data table
                string query = "SELECT COUNT(*) AS count FROM crime_data";

                // Create a command to execute the SQL query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the command and read the count
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return count;
        }



        private Dictionary<string, int> GetCountsFromDataBase(string word, string filter)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // Establish connection to the SQLite database
            string connectionString = "Data Source=crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query dynamically based on the value of word and filter
                string query = "";
                if (filter.ToLower() == "all")
                {
                    query = $"SELECT {word}, COUNT(*) AS count FROM crime_data GROUP BY {word}";
                }
                else
                {
                    query = $"SELECT {word}, COUNT(*) AS count FROM crime_data WHERE CrimeType='{filter}' GROUP BY {word}";

                }

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


        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<int, int> GetCrimeCountsByTimeFromDatabase()
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Establish connection to the SQLite database
            string connectionString = "Data Source=crime_db.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Construct the SQL query to retrieve time ranges and crime counts
                string query = @"
            SELECT
                CASE
                    WHEN TIME(time) >= '00:00:00' AND TIME(time) < '03:00:00' THEN 1
                    WHEN TIME(time) >= '03:00:00' AND TIME(time) < '06:00:00' THEN 2
                    WHEN TIME(time) >= '06:00:00' AND TIME(time) < '09:00:00' THEN 3
                    WHEN TIME(time) >= '09:00:00' AND TIME(time) < '11:00:00' THEN 4
                    WHEN TIME(time) >= '11:00:00' AND TIME(time) < '12:00:00' THEN 5
                    WHEN TIME(time) >= '12:00:00' AND TIME(time) < '15:00:00' THEN 6
                    WHEN TIME(time) >= '15:00:00' AND TIME(time) < '18:00:00' THEN 7
                    WHEN TIME(time) >= '18:00:00' AND TIME(time) < '21:00:00' THEN 8
                    WHEN TIME(time) >= '21:00:00' AND TIME(time) < '00:00:00' THEN 9
                    ELSE 0  -- Default value when no range matches
                END AS time_range,
                SUM(CrimeCount) AS total_crime_count
            FROM
                crime_data
            GROUP BY
                time_range;";

                // Create a command to execute SQL query
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the command and read the results
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int timeRange = Convert.ToInt32(reader["time_range"]);
                            int totalCrimeCount = Convert.ToInt32(reader["total_crime_count"]);
                            counts.Add(timeRange, totalCrimeCount);
                        }
                    }
                }
            }

            return counts;
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

 

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            makechart("Hurt");

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {
            makechart("Rioting");
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            makechart("Rape");
        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {
            makechart("Kidnapping");
        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {
            makechart("Robery");
        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {
            makechart("Motor vihicle theft");
        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {
            makechart("Burglary");
        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {
            makechart("Murder Attempted");
        }
        public void  makechart(string chartName)
        {

        }

        private void cartesianChart7_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Murder");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Red, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon","Murder",pieChart1);
            load_pie_chart("day_night", "Murder", pieChart3);


            PlotCrimeTrendByWeapon("Murder",cartesianChart2);
         
            PlotCrimeTrendByDistrict("Murder", cartesianChart4);
            PlotCrimeTrendByGender("Murder", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Blue, "Yearly Crime Trend");
            load_pie_chart("Victim_sex", "Murder", pieChart2);
            load_pie_chart("age_group", "Murder", pieChart4);
            PlotCrimeTrendByAgeGrp("Murder", cartesianChart6);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Hurt");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Yellow, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Hurt", pieChart1);
            load_pie_chart("day_night", "Hurt", pieChart3);
            PlotCrimeTrendByWeapon("Hurt",cartesianChart2);
            PlotCrimeTrendByDistrict("Hurt", cartesianChart4);

            PlotCrimeTrendByGender("Hurt", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Red, "Yearly Crime Trend");
            load_pie_chart("Victim_sex", "Hurt", pieChart2);
            load_pie_chart("age_group", "Hurt", pieChart4);

            PlotCrimeTrendByAgeGrp("Hurt", cartesianChart6);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Rioting");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Black, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Rioting", pieChart1);
            
            load_pie_chart("day_night", "Rioting", pieChart3);
            PlotCrimeTrendByWeapon("Rioting", cartesianChart2);
            PlotCrimeTrendByDistrict("Rioting", cartesianChart4);

            PlotCrimeTrendByGender("Rioting", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Black, "Yearly Crime Trend");

            load_pie_chart("Victim_sex", "Rioting", pieChart2);

            load_pie_chart("age_group", "Rioting", pieChart4);

            PlotCrimeTrendByAgeGrp("Rioting", cartesianChart6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Rape");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Pink, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Rape", pieChart1);
            
            load_pie_chart("District", "Rape", pieChart3);
            PlotCrimeTrendByWeapon("Rape", cartesianChart2);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Pink, "Yearly Crime Trend");

            PlotCrimeTrendByDistrict("Rape", cartesianChart4);

            PlotCrimeTrendByGender("Rape", cartesianChart3);
            load_pie_chart("Victim_sex", "Rape", pieChart2);
            load_pie_chart("age_group", "Rape", pieChart4);

            PlotCrimeTrendByAgeGrp("Rape", cartesianChart6);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Kidnapping/ Abduction");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.DeepSkyBlue, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Kidnapping", pieChart1);
            load_pie_chart("District", "Kidnapping", pieChart3); PlotCrimeTrendByWeapon("Kidnapping/ Abduction", cartesianChart2);
            PlotCrimeTrendByDistrict("Kidnapping", cartesianChart4);

            PlotCrimeTrendByGender("Kidnapping", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.DeepPink, "Yearly Crime Trend");
            load_pie_chart( "Victim_sex", "Kidnapping", pieChart2);
            load_pie_chart("age_group", "Kidnapping", pieChart4);

            PlotCrimeTrendByAgeGrp("Kidnapping", cartesianChart6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Robbery");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.Aqua, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Robbery", pieChart1);
            
            load_pie_chart("District", "Robbery", pieChart3);
            PlotCrimeTrendByWeapon("Robbery", cartesianChart2);

            PlotCrimeTrendByDistrict("Robbery", cartesianChart4);
            PlotCrimeTrendByGender("Robbery", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.DeepSkyBlue, "Yearly Crime Trend");
            load_pie_chart("Victim_sex", "Robbery", pieChart2);
            load_pie_chart("age_group", "Robbery", pieChart4);

            PlotCrimeTrendByAgeGrp("Robbery", cartesianChart6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Motor Vehicles Theft");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.DarkRed, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Motor Vehicles Theft", pieChart1);

            load_pie_chart("day_night", "Motor Vehicles Theft", pieChart3); PlotCrimeTrendByWeapon("Motor Vehicles Theft", cartesianChart2);

            PlotCrimeTrendByDistrict("Motor Vehicles Theft", cartesianChart4);

            PlotCrimeTrendByGender("Motor Vehicles Theft", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Aqua, "Yearly Crime Trend");

            load_pie_chart("Victim_sex", "Motor Vehicles Theft", pieChart2);
            load_pie_chart("age_group", "Motor Vehicles Theft", pieChart4);

            PlotCrimeTrendByAgeGrp("Motor Vehicles Theft", cartesianChart6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();

            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Burglary");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.DarkSalmon, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Burglary", pieChart1);
            load_pie_chart("day_night", "Burglary", pieChart3);
            PlotCrimeTrendByWeapon("Burglary", cartesianChart2);

            PlotCrimeTrendByDistrict("Burglary", cartesianChart4);

            PlotCrimeTrendByGender("Burglary", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Orange, "Yearly Crime Trend");
            load_pie_chart("Victim_sex", "Burglary", pieChart2);
            load_pie_chart("age_group", "Burglary", pieChart4);

            PlotCrimeTrendByAgeGrp("Burglary", cartesianChart6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cartesianChart7.Series.Clear();

            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("Attempted Murder");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.DarkSeaGreen, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "Attempted Murder", pieChart1);

            load_pie_chart("day_night", "Attempted Murder", pieChart3); PlotCrimeTrendByWeapon("Attempted Murder", cartesianChart2);

            PlotCrimeTrendByDistrict("Attempted Murder", cartesianChart4);

            PlotCrimeTrendByGender("Attempted Murder", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Purple, "Yearly Crime Trend");
            load_pie_chart("Victim_sex", "Attempted Murder", pieChart2);
            load_pie_chart("age_group", "Attempted Murder", pieChart4);

            PlotCrimeTrendByAgeGrp("Attempted Murder", cartesianChart6);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            cartesianChart7.Series.Clear();
            Dictionary<int, int> data = GetYearlyCrimeCountsFromDatabase("All");
            PlotCrimeTrend(data, cartesianChart7, System.Windows.Media.Colors.DarkSeaGreen, "Yearly Crime Trend");
            pieChart1.Series.Clear();
            load_pie_chart("Weapon", "All", pieChart1);
            pieChart3.Series.Clear();
            load_pie_chart("day_night", "All", pieChart3);
            PlotCrimeTrendByWeapon("All", cartesianChart2);

            PlotCrimeTrendByDistrict("All", cartesianChart4);
            load_pie_chart("Victim_sex", "all", pieChart2);
            load_pie_chart("age_group", "all", pieChart4);




            PlotCrimeTrendByGender("all", cartesianChart3);
            cartesianChart1.Series.Clear();
            PlotCrimeTrend(data, cartesianChart1, System.Windows.Media.Colors.Yellow, "Yearly Crime Trend");

            PlotCrimeTrendByAgeGrp("all", cartesianChart6);
        }

        private void cartesianChart6_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartesianChart5_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart4_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart4_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void generateDynamicUserControls()
        {
            flowLayoutPanel1.Controls.Clear();
            List<UserControl1> listItems = new List<UserControl1>(); 
            string connectionString = "Data Source=crime_db.db";
            string query = "select  District,Weapon,day_night,crimetype from crime_data  where  day_night not null and  District not null and weapon not null and crimetype not null  order by id desc limit 50";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using ( SQLiteCommand command = new SQLiteCommand(query,connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader=command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserControl1 temp = new UserControl1();

                                temp.setCity(reader.GetString(0));
                                temp.setWeapon(reader.GetString(1));
                                temp.setDayNight(reader.GetString(2));
                                temp.setCrimeType(reader.GetString(3));
                                listItems.Add(temp);
                            }
                        }
                    }


                    
                }
            }

            foreach (UserControl1 item in listItems)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(); 
            d.Show();
 
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void crime_trend_page_Load(object sender, EventArgs e)
        {

        }
    }
}
      