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
    public partial class doctor_management_module : Form
    {
        public doctor_management_module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("specialization", "select  specialization, count(*) as count f" +
                "rom doctor group by specialization", specilization);
            m.load_pie_chart("gender", "select  gender, count(*) as count from doctor group by gender", gender);
            m.load_pie_chart("language", "select  language, count(*) as count from doctor group by language", language);


        }

        private void registerNewDoctor_TextChanged(object sender, EventArgs e)
        {
            registerNewDoctorForm d = new registerNewDoctorForm();
            d.Show();
        }

        private void viewReportOfSpecificPrisoner_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form v = new view_medical_report_form();
            v.Show();
        }

        private void viewReports_TextChanged(object sender, EventArgs e)
        {
            doctor_reports_database_view v = new doctor_reports_database_view();
            v.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            view_doctor_information d = new view_doctor_information();
            d.Show();

        }

        private void doctor_management_module_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerNewDoctorForm d = new registerNewDoctorForm();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_medical_report_form v = new view_medical_report_form();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctor_reports_database_view v = new doctor_reports_database_view();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_doctor_information d = new view_doctor_information();
            d.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prison_management_system_module m = new prison_management_system_module();
            m.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
