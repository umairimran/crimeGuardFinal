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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void setCity(string city)
        {
             district.Clear();
            district.Text = city;
        }
        public void setDayNight(string date)
        {
            day_night.Clear();
            day_night.Text = date;

        }

        public void  setGender(string gender)
        {
            day_night.Clear();
            day_night.Text = gender;


        }
        public void setCrimeType(string  crimeType)
        {
            this.crimeType.Clear();
            this.crimeType.Text = crimeType;
        }
        public void setWeapon(string weapon)
        {
            this.weapon.Clear();
            this.weapon.Text = weapon;
        }

        private void crimeType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
