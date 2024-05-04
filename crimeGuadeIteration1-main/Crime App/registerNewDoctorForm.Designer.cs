namespace Crime_App
{
    partial class registerNewDoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.doctorName = new System.Windows.Forms.RichTextBox();
            this.selectDoctorSpecialization = new System.Windows.Forms.ComboBox();
            this.selectDoctorGender = new System.Windows.Forms.ComboBox();
            this.doctorDob = new System.Windows.Forms.DateTimePicker();
            this.selectAvailabilityStart = new System.Windows.Forms.ComboBox();
            this.selectAvailabilityEnd = new System.Windows.Forms.ComboBox();
            this.doctorLanguage = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(77, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(187, 37);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Doctor Name";
            // 
            // doctorName
            // 
            this.doctorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorName.ForeColor = System.Drawing.Color.Blue;
            this.doctorName.Location = new System.Drawing.Point(380, 172);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(339, 39);
            this.doctorName.TabIndex = 5;
            this.doctorName.Text = "";
            // 
            // selectDoctorSpecialization
            // 
            this.selectDoctorSpecialization.BackColor = System.Drawing.SystemColors.Window;
            this.selectDoctorSpecialization.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDoctorSpecialization.ForeColor = System.Drawing.Color.Blue;
            this.selectDoctorSpecialization.FormattingEnabled = true;
            this.selectDoctorSpecialization.Items.AddRange(new object[] {
            "Cardiology",
            "Pediatrics",
            "Orthopedics",
            "Dermatology",
            "Ophthalmology",
            "Psychiatry",
            "Neurology",
            "Gynecology",
            "Urology",
            "Endocrinology",
            "Oncology",
            "Rheumatology",
            "Gastroenterology",
            "Pulmonology",
            "Nephrology",
            "Hematology",
            "Allergy and Immunology",
            "Infectious Diseases",
            "Emergency Medicine",
            "Geriatrics"});
            this.selectDoctorSpecialization.Location = new System.Drawing.Point(380, 289);
            this.selectDoctorSpecialization.Name = "selectDoctorSpecialization";
            this.selectDoctorSpecialization.Size = new System.Drawing.Size(339, 38);
            this.selectDoctorSpecialization.TabIndex = 6;
            // 
            // selectDoctorGender
            // 
            this.selectDoctorGender.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDoctorGender.ForeColor = System.Drawing.Color.Blue;
            this.selectDoctorGender.FormattingEnabled = true;
            this.selectDoctorGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.selectDoctorGender.Location = new System.Drawing.Point(380, 389);
            this.selectDoctorGender.Name = "selectDoctorGender";
            this.selectDoctorGender.Size = new System.Drawing.Size(339, 38);
            this.selectDoctorGender.TabIndex = 7;
            // 
            // doctorDob
            // 
            this.doctorDob.Location = new System.Drawing.Point(380, 493);
            this.doctorDob.Name = "doctorDob";
            this.doctorDob.Size = new System.Drawing.Size(275, 20);
            this.doctorDob.TabIndex = 8;
            // 
            // selectAvailabilityStart
            // 
            this.selectAvailabilityStart.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAvailabilityStart.ForeColor = System.Drawing.Color.Blue;
            this.selectAvailabilityStart.FormattingEnabled = true;
            this.selectAvailabilityStart.Items.AddRange(new object[] {
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "08:30:00",
            "09:30:00",
            "10:30:00",
            "11:30:00",
            "12:30:00",
            "13:30:00",
            "14:30:00",
            "15:30:00"});
            this.selectAvailabilityStart.Location = new System.Drawing.Point(1064, 181);
            this.selectAvailabilityStart.Name = "selectAvailabilityStart";
            this.selectAvailabilityStart.Size = new System.Drawing.Size(248, 38);
            this.selectAvailabilityStart.TabIndex = 9;
            // 
            // selectAvailabilityEnd
            // 
            this.selectAvailabilityEnd.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAvailabilityEnd.ForeColor = System.Drawing.Color.Blue;
            this.selectAvailabilityEnd.FormattingEnabled = true;
            this.selectAvailabilityEnd.Items.AddRange(new object[] {
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00",
            "16:30:00",
            "17:30:00",
            "18:30:00",
            "19:30:00",
            "20:30:00",
            "21:30:00",
            "22:30:00",
            "23:30:00"});
            this.selectAvailabilityEnd.Location = new System.Drawing.Point(1064, 296);
            this.selectAvailabilityEnd.Name = "selectAvailabilityEnd";
            this.selectAvailabilityEnd.Size = new System.Drawing.Size(248, 38);
            this.selectAvailabilityEnd.TabIndex = 10;
            // 
            // doctorLanguage
            // 
            this.doctorLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doctorLanguage.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLanguage.ForeColor = System.Drawing.Color.Blue;
            this.doctorLanguage.Location = new System.Drawing.Point(1064, 381);
            this.doctorLanguage.Name = "doctorLanguage";
            this.doctorLanguage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.doctorLanguage.Size = new System.Drawing.Size(248, 40);
            this.doctorLanguage.TabIndex = 13;
            this.doctorLanguage.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1300, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.White;
            this.richTextBox7.Location = new System.Drawing.Point(380, 12);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(538, 87);
            this.richTextBox7.TabIndex = 15;
            this.richTextBox7.Text = "Register New Doctor";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(77, 280);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox8.Size = new System.Drawing.Size(250, 37);
            this.richTextBox8.TabIndex = 17;
            this.richTextBox8.Text = "Doctor Specialization";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.ForeColor = System.Drawing.Color.White;
            this.richTextBox9.Location = new System.Drawing.Point(77, 389);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox9.Size = new System.Drawing.Size(250, 37);
            this.richTextBox9.TabIndex = 18;
            this.richTextBox9.Text = "Doctor Gender";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(77, 487);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(250, 37);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "Select DOB";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(835, 147);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(207, 97);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "Select Availability Start Time";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(835, 265);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(207, 97);
            this.richTextBox5.TabIndex = 21;
            this.richTextBox5.Text = "Select Availability End Time";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(835, 389);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(207, 32);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "Enter Language";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.doctor;
            this.pictureBox2.Location = new System.Drawing.Point(208, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // registerNewDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doctorLanguage);
            this.Controls.Add(this.selectAvailabilityEnd);
            this.Controls.Add(this.selectAvailabilityStart);
            this.Controls.Add(this.doctorDob);
            this.Controls.Add(this.selectDoctorGender);
            this.Controls.Add(this.selectDoctorSpecialization);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.richTextBox1);
            this.Name = "registerNewDoctorForm";
            this.Text = "registerNewDoctorForm";
            this.Load += new System.EventHandler(this.registerNewDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox doctorName;
        private System.Windows.Forms.ComboBox selectDoctorSpecialization;
        private System.Windows.Forms.ComboBox selectDoctorGender;
        private System.Windows.Forms.DateTimePicker doctorDob;
        private System.Windows.Forms.ComboBox selectAvailabilityStart;
        private System.Windows.Forms.ComboBox selectAvailabilityEnd;
        private System.Windows.Forms.RichTextBox doctorLanguage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}