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
    public partial class cell_management : Form
    {
        public cell_management()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
            prison_management_system_module m = new prison_management_system_module();
            m.load_pie_chart("capacity", "select  capacity, count(*) as count from cell group by capacity", capacity);
            m.load_pie_chart("securityLevel", "select  securityLevel, count(*) as count from cell group by securityLevel", securityLevel);
            m.load_pie_chart("cleanliness", "select  cleanliness, count(*) as count from cell group by cleanliness", cleanliness);

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            newCell n = new newCell();
            n.Show();

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            addPrisonerToCell c= new addPrisonerToCell();
            c.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            viewParticularCell v = new viewParticularCell();
            v.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            assign_cell_staff s = new assign_cell_staff();
            s.Show();
;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            view_table_cell_staff_prisoner_combine c = new view_table_cell_staff_prisoner_combine();
            c.Show();


        }

        private void cell_management_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            assign_cell_staff s = new assign_cell_staff();
            s.Show();
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPrisonerToCell c = new addPrisonerToCell();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newCell n = new newCell();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewParticularCell v = new viewParticularCell();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_table_cell_staff_prisoner_combine c = new view_table_cell_staff_prisoner_combine();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prison_management_system_module p = new prison_management_system_module();
            p.Show();
        }
    }
}
