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
    public partial class personalBelongingsManagementPortal : Form
    {
        public personalBelongingsManagementPortal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("condition", "select  condition, count(*) as count from prisonerBelongings group by condition", pieChart1);
            m.load_pie_chart("itemName", "select  itemName, count(*) as count from prisonerBelongings group by itemName", pieChart2);
            m.load_pie_chart("status", "select  status, count(*) as count from prisonerBelongings group by status", pieChart3);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            create_new_belonging g = new create_new_belonging();
            g.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_prisoner_belongings b = new view_prisoner_belongings();
            b.Show();
        }

        private void personalBelongingsManagementPortal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_new_belonging g = new create_new_belonging();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_prisoner_belongings b = new view_prisoner_belongings();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            view_complete_bellongings c = new view_complete_bellongings();
            c.Show();        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prison_management_system_module m = new prison_management_system_module();
            m.Show();
        }
    }
}
