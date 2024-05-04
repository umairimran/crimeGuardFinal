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
    public partial class activity_module : Form
    {
        public activity_module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("location", "select  location, count(*) as count from Activity group by location", location);
            m.load_pie_chart("duration", "select  duration, count(*) as count from Activity group by duration", duration);
            m.load_pie_chart("activityId", "select  activityId, count(*) as count from prisoner_activity_register group by activityId", prisoner);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            create_new_activity a = new create_new_activity();
            a.Show();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            register_prisoner_to_activity a = new register_prisoner_to_activity();
            a.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            view_activity_in_data_view v = new view_activity_in_data_view();
            v.Show();
        }

        private void activity_module_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_new_activity a = new create_new_activity();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_activity_in_data_view v = new view_activity_in_data_view();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register_prisoner_to_activity a = new register_prisoner_to_activity();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prison_management_system_module p = new prison_management_system_module();
            p.Show();
        }
    }
}
