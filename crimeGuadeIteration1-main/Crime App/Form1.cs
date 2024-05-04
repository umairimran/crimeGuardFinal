using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            panel2.Controls.Clear();
            Dashboard frmFb = new Dashboard()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFb.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frmFb);
            frmFb.Show();




        }






        public void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
