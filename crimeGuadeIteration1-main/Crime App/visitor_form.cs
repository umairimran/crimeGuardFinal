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
    public partial class visitor_form : Form
    {
        public visitor_form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("relationshipToInmate", "select  " +
                "relationshipToInmate, count(*) as count from " +
                "Visitor group by relationshipToInmate", relationship);
            m.load_pie_chart("gender", "select  gender, count(*) as count from Visitor group by gender", gender);
            m.load_pie_chart("identification", "select  identification, count(*) as count from Visitor group by identification", identification);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitor_register_form v = new visitor_register_form();
            v.Show();
;        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form x = new view_medical_report_form();
            x.Show();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            create_new_belonging c= new create_new_belonging();
            c.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            schedule_visit s = new schedule_visit()
;   s.Show();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            view_visitors_history v = new view_visitors_history();
            v.Show();
        }

        private void visitor_form_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            visitor_register_form v = new visitor_register_form();
            v.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            view_medical_report_form x = new view_medical_report_form();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedule_visit s = new schedule_visit()
; s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            create_new_belonging c = new create_new_belonging();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prison_management_system_module p = new prison_management_system_module();
            p.Show()
;        }
    }
}
