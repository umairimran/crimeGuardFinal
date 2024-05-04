using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace Crime_App
{
    public partial class geoMap : Form
    {
        public geoMap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            ApplyLinearGradient();
            InitializeMap();
            LoadData();
            this.Load += Form_Load;

        }
        private void geomap_load(object sender, EventArgs e)
        {

        }
        private void ApplyLinearGradient()
        {
            // Create a linear gradient brush
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(0, 7, 61, 81),  // Start color (red)
                Color.FromArgb(45, 35, 46),  // End color (blue)
                LinearGradientMode.Horizontal); // Gradient mode (horizontal)

            // Set the form's background to the gradient brush
            this.BackColor = Color.White; // Set default background color
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            };
        }

        private void InitializeMap()
        {
            gMapControl1 = new GMapControl();
            gMapControl1.Dock = DockStyle.Fill; // Fill the entire panel
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(40.7128, -74.0060); // New York
            //gMapControl1.Zoom = GetZoomLevel(panel3.ClientSize.Width, panel3.ClientSize.Height, new PointLatLng(40.7128, -74.0060)); // Adjust initial zoom level
            gMapControl1.MinZoom = 1;
            gMapControl1.Zoom = 500;
            gMapControl1.MaxZoom = 1000;
            gMapControl1.DragButton = MouseButtons.Left; // Allow dragging with left mouse button
            panel3.Controls.Add(gMapControl1); // Add the GMapControl to the panel's controls
        }

        private int GetZoomLevel(int panelWidth, int panelHeight, PointLatLng center)
        {
            int zoomMax = gMapControl1.MaxZoom;
            int zoomMin = gMapControl1.MinZoom;

            // Calculate zoom level to fit the entire panel
            for (int i = zoomMax; i >= zoomMin; i--)
            {
                double resolutionX = gMapControl1.MapProvider.Projection.GetGroundResolution(i, center.Lat);
                double resolutionY = gMapControl1.MapProvider.Projection.GetGroundResolution(i, center.Lat);

                if (resolutionX * gMapControl1.Width <= panelWidth && resolutionY * gMapControl1.Height <= panelHeight)
                {
                    return i;
                }
            }
            return zoomMin;
        }



        private void LoadData()
        {
            // Example data

        }

        private void geoMap_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=crime_db.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                try
                {

                    string crimeType = cmbCrimeType.SelectedItem?.ToString();
                    string weapon = cmbWeapon.SelectedItem?.ToString();
                    string year = cmbYear.SelectedItem?.ToString();
                    string selectedTime = cmbTime.SelectedItem?.ToString();
                    string age_group = cmbAgeGroup.SelectedItem?.ToString();
                    string victim_sex = cmbGender.SelectedItem?.ToString();

                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1"; // Start with a true condition to allow easy appending

                    // Add conditions for each selected value, excluding nulls (not selected)


                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND CrimeType = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND Weapon = '{weapon}'";

                    if (!string.IsNullOrEmpty(year))
                        whereClause += $" AND Year = '{year}'";


                    if (!string.IsNullOrEmpty(selectedTime))
                        whereClause += $" AND [day/night] = '{selectedTime}'";

                    if (!string.IsNullOrEmpty(age_group))
                        whereClause += $" AND Age_Group = '{age_group}'";

                    if (!string.IsNullOrEmpty(victim_sex))
                        whereClause += $" AND victim_sex = '{victim_sex}'";

                    // Final SQL query to select only Latitude and Longitude
                    string query = $"SELECT  Latitude, Longitude FROM crime_data {whereClause} AND Longitude IS NOT NULL AND Latitude IS NOT NULL";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            // Extract latitude and longitude values from the query result
                            List<PointLatLng> crimeLocations = new List<PointLatLng>();
                            while (reader.Read())
                            {
                                double latitude = Convert.ToDouble(reader["Latitude"]);
                                double longitude = Convert.ToDouble(reader["Longitude"]);
                                crimeLocations.Add(new PointLatLng(latitude, longitude));
                            }

                            // Display crime locations on the map
                            DisplayCrimeLocations(crimeLocations);

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




        private List<PointLatLng> GetConvexHull(List<PointLatLng> points)
        {
            // Sort points by x-coordinate (and by y-coordinate if x-coordinates are equal)
            points.Sort((p1, p2) =>
            {
                int result = p1.Lng.CompareTo(p2.Lng);
                return result == 0 ? p1.Lat.CompareTo(p2.Lat) : result;
            });

            // Initialize stack to hold points on the convex hull
            Stack<PointLatLng> stack = new Stack<PointLatLng>();

            // Build lower hull
            foreach (var point in points)
            {
                while (stack.Count >= 2 && Orientation(stack.ElementAt(1), stack.Peek(), point) >= 0)
                {
                    stack.Pop();
                }
                stack.Push(point);
            }

            // Build upper hull
            points.Reverse(); // Reverse the order of points
            for (int i = 1; i < points.Count; i++)
            {
                while (stack.Count >= 2 && Orientation(stack.ElementAt(1), stack.Peek(), points[i]) >= 0)
                {
                    stack.Pop();
                }
                stack.Push(points[i]);
            }

            return stack.ToList();
        }

        // Function to determine orientation of ordered triplet (p, q, r)
        // Returns:
        //   -1 if counterclockwise
        //    0 if collinear
        //    1 if clockwise
        private int Orientation(PointLatLng p, PointLatLng q, PointLatLng r)
        {
            double val = (q.Lat - p.Lat) * (r.Lng - q.Lng) - (q.Lng - p.Lng) * (r.Lat - q.Lat);
            if (Math.Abs(val) < double.Epsilon)
                return 0;
            return (val > 0) ? 1 : -1;
        }

        private void DisplayCrimeLocations(List<PointLatLng> points)
        {
            gMapControl1.Overlays.Clear();
            // Display crime locations on the map


            GMapOverlay markersOverlay = new GMapOverlay("CrimeLocations");
            foreach (PointLatLng point in points)
            {
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
            }
            gMapControl1.Overlays.Add(markersOverlay);
        }
        private List<string> GetDistinctValues(string category)
        {
            List<string> values = new List<string>();

            // Your database connection string
            string connectionString = "Data Source=C:\\Users\\LENOVO\\source\\repos\\WindowsFormsApp2\\crime_db.db;Version=3";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Execute a query to retrieve distinct values for the specified category
                string sqlQuery = $"SELECT DISTINCT \"{category}\"  FROM crime_data";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            values.Add(reader[category].ToString());
                        }
                    }
                }
            }

            return values;
        }
        private void PopulateComboBox(ComboBox comboBox, string category)
        {
            // Retrieve distinct values for the specified category from the database
            List<string> values = GetDistinctValues(category);

            // Clear existing items and add new items to the ComboBox
            comboBox.Items.Clear();
            comboBox.Items.AddRange(values.ToArray());
        }
        private void Form_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes for different categories
            PopulateComboBox(cmbGender, "victim_sex");
            PopulateComboBox(cmbCrimeType, "crimeType");
            PopulateComboBox(cmbYear, "Year"); PopulateComboBox(cmbAgeGroup, "age_group");
            PopulateComboBox(cmbWeapon, "Weapon");
            PopulateComboBox(cmbTime, "day/night");



            // Add more ComboBoxes for other categories as needed
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard m = new Dashboard();
;
            m.Show();
        }
    }
}
