using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;


namespace Crime_App
{
    public partial class Dashboard : Form
    {  
        public Dashboard()
        {
          
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            Crime_Data_Processing obj1 = new Crime_Data_Processing();
            double val = obj1.CalculateAverage();
            double val2 = obj1.Calculate_Total();
            double val3 = obj1.Total_Casualties();
            val = Convert.ToInt32(val);
            val2 = Convert.ToInt32(val2);
            val3 = Convert.ToInt64(val3);
            label4.Text = val.ToString();
            label5.Text = val2.ToString();
            label7.Text = val3.ToString();
            var data = obj1.Get_Data();
            chart1.Series[0].Points.Clear();
            foreach (var item in data)
            {
                chart1.Series[0].Points.AddXY(item.Item1, item.Item2);
            }
            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Crime Count";
            var data1 = obj1.Get_Data_For_Pie_Chart();
            foreach (var item in data1)
            {
                pieChart1.Series.Add(new PieSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 }
                });
            }
            foreach (var item in data1)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 },
                });
               
            }
            double val4 = obj1.Average_Casualties();
            label9.Text = val4.ToString();
       

        }
        private LinearGradientBrush brush;

        private void ApplyLinearGradient()
        {
            brush = new LinearGradientBrush(
                this.ClientRectangle, // Using the form's dimensions directly
                Color.FromArgb(71, 68, 73),
                Color.FromArgb(45, 35, 46),
                LinearGradientMode.Horizontal);

            this.BackColor = Color.White;

            // Attach the Resize event handler
            this.Resize += Form1_Resize;

            // Force the form to repaint itself to apply the gradient
            this.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           // Update the brush with the new form dimensions
           brush = new LinearGradientBrush(
               this.ClientRectangle, // Using the updated form's dimensions
               Color.FromArgb(71, 68, 73),
               Color.FromArgb(45, 35, 46),
               LinearGradientMode.Horizontal);

            // Force the form to repaint itself to apply the gradient
            this.Invalidate();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);
            Color startColor = ColorTranslator.FromHtml("#474449");
            Color endColor = ColorTranslator.FromHtml("#2D232E");
            LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, panel2.Width, panel2.Height);
            Color startColor = ColorTranslator.FromHtml("#474449");
            Color endColor = ColorTranslator.FromHtml("#2D232E");
            LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Crime_Data_Processing obj = new Crime_Data_Processing();
            cartesianChart1.Series.Clear();
            var data1 = obj.Get_Data_For_Pie_Chart();
            foreach (var item in data1)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 },
                });

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Crime_Data_Processing obj = new Crime_Data_Processing();
            cartesianChart1.Series.Clear();
            var data1 = obj.Get_Data_For_Cartesian_Chart_1();
            foreach (var item in data1)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 },
                });

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Crime_Data_Processing obj = new Crime_Data_Processing();
            cartesianChart1.Series.Clear();
            var data1 = obj.Get_Data_For_Cartesian_Chart_2();
            foreach (var item in data1)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 },
                });

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Crime_Data_Processing obj = new Crime_Data_Processing();
            cartesianChart1.Series.Clear();
            var data1 = obj.Get_Data_For_Cartesian_Chart_3();
            foreach (var item in data1)
            {
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = item.Item1,
                    Values = new ChartValues<int> { item.Item2 },
                });

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard obj1 = new Dashboard();
            obj1.Show();
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            crime_input_page c = new crime_input_page();
            c.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            search_data_in_database s = new search_data_in_database();
            s.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crime_trend_page c = new crime_trend_page();
            c.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            prison_management_system_module n = new prison_management_system_module();
            n.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            prison_management_system_module f = new prison_management_system_module();
            f.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            geoMap g = new geoMap();
            g.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            register_fir Report = new register_fir();
            Report.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fir_Module f = new Fir_Module();
            f.Show();
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            Fir_Module f = new Fir_Module();
            f.Show();
        }
    }
}
