using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class create_new_staff : Form
    {
        public create_new_staff()
        {
      
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_new_staff_Load(object sender, EventArgs e)
        {

        }

        private void staffEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void InsertStaffInfo(string name, string gender, string dob, string phoneNumber, string email, string address, string position, string department, string shiftSchedule, decimal salary, string dateOfHire, string trainingCertifications, string emergencyContact, string accessRights)
        {
            string query = "INSERT INTO Staff (name, gender, dateOfBirth, phoneNumber, email, address, position, department, shiftSchedule, salary, dateOfHire, trainingCertifications, emergencyContact, accessRights) " +
                           "VALUES (@name, @gender, @dob, @phoneNumber, @email, @address, @position, @department, @shiftSchedule, @salary, @dateOfHire, @trainingCertifications, @emergencyContact, @accessRights)";
            new_prisoner_form n = new new_prisoner_form();
            using (SQLiteConnection connection = new SQLiteConnection(n.Db_Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", gender);
                    DateTime dateAcquired = staffDob.Value.Date;
                    command.Parameters.AddWithValue("@dob", dateAcquired);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@shiftSchedule", shiftSchedule);
                    command.Parameters.AddWithValue("@salary", salary);
                     dateAcquired = staffDateOfHire.Value.Date;
                    command.Parameters.AddWithValue("@dateOfHire", dateAcquired);
                    command.Parameters.AddWithValue("@trainingCertifications", trainingCertifications);
                    command.Parameters.AddWithValue("@emergencyContact", emergencyContact);
                    command.Parameters.AddWithValue("@accessRights", accessRights);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Staff information inserted successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrEmpty(staffName.Text) ||
                staffGender.SelectedItem == null ||
                string.IsNullOrEmpty(staffDob.Text) ||
                string.IsNullOrEmpty(staffPhoneNumber.Text) ||
                string.IsNullOrEmpty(staffEmail.Text) ||
                string.IsNullOrEmpty(staffAddress.Text) ||
                string.IsNullOrEmpty(staffPosition.Text) ||
                string.IsNullOrEmpty(staffDepartment.Text) ||
                string.IsNullOrEmpty(staffShiftSchedule.Text) ||
                string.IsNullOrEmpty(staffSalary.Text) ||
                string.IsNullOrEmpty(staffDateOfHire.Text) ||
                string.IsNullOrEmpty(staffEmergencyContact.Text) ||
                staffAccessRights.SelectedItem == null ||
                string.IsNullOrEmpty(staffTrainingCertifications.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Convert salary to decimal
            decimal salary = 0;
            if (!decimal.TryParse(staffSalary.Text, out salary))
            {
                MessageBox.Show("Invalid salary format. Please enter a valid decimal value.");
                return;
            }

            // Call the function to insert staff information
            InsertStaffInfo(
                staffName.Text,
                staffGender.SelectedItem.ToString(),
                staffDob.Text,
                staffPhoneNumber.Text,
                staffEmail.Text,
                staffAddress.Text,
                staffPosition.Text,
                staffDepartment.Text,
                staffShiftSchedule.Text,
                salary,
                staffDateOfHire.Text,
                staffTrainingCertifications.Text,
                staffEmergencyContact.Text,
                staffAccessRights.SelectedItem.ToString()
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            staff_management_module S = new staff_management_module();
            S.Show();
        }

        private void staffPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void staffPosition_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
