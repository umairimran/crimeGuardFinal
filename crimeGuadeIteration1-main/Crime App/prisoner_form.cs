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
    public partial class prisoner_form : Form
    {
        public prisoner_form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("prisonerid", "select prisonerid , count(*) as count from prisoner_activity_register group by prisonerid", activity);
            m.load_pie_chart("gender", "select gender , count(*) as count from prisoners group by gender", gender);
            m.load_pie_chart("prisonDuration", "select prisonDuration , count(*) as count from prisoners group by prisonDuration", prisonerDuration);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            new_prisoner_form n = new new_prisoner_form();
            n.Show();
        }

        private void viewMedicalReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form f = new view_medical_report_form();
            f.Show();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_prisoner_belongings p = new view_prisoner_belongings();
            p.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            register_prisoner_to_activity r = new register_prisoner_to_activity();
            r.Show();
        }

        private void orderMeal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            create_medical_report c = new create_medical_report();
            c.Show();
        }

        private void prisoner_form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new_prisoner_form n = new new_prisoner_form();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register_prisoner_to_activity r = new register_prisoner_to_activity();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_prisoner_belongings p = new view_prisoner_belongings();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            create_medical_report c = new create_medical_report();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_medical_report_form f = new view_medical_report_form();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            prison_management_system_module m = new prison_management_system_module();
            m.Show();
        }
    }
}
