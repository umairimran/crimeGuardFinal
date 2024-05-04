using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class staff_management_module : Form
    {
        public staff_management_module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("durationOfVisit", "SELECT durationOfVisit, COUNT(*) AS count FROM visitor_history GROUP BY durationOfVisit", pieChart1);
            m.load_pie_chart("trainingCertifications", "select trainingCertifications, count(*) as count from  staff group by trainingCertifications", pieChart2);
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            assign_cell_staff s = new assign_cell_staff();
            s.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            create_new_staff c = new create_new_staff();
            c.Show();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            view_staff v = new view_staff();
            v.Show();

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_visitors_history v = new view_visitors_history();
            v.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void staff_management_module_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_new_staff c = new create_new_staff();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_staff v = new view_staff();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_visitors_history v = new view_visitors_history();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            assign_cell_staff s = new assign_cell_staff();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prison_management_system_module m = new prison_management_system_module();
            m.Show();
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
