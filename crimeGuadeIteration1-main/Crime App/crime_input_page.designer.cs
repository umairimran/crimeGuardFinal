namespace Crime_App
{
    partial class crime_input_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crime_type_selction_box = new System.Windows.Forms.ComboBox();
            this.box = new System.Windows.Forms.RichTextBox();
            this.gender_selection_box = new System.Windows.Forms.ComboBox();
            this.time_selection_box = new System.Windows.Forms.ComboBox();
            this.age_selection_box = new System.Windows.Forms.ComboBox();
            this.weapon_selection_box = new System.Windows.Forms.ComboBox();
            this.division_selection_box = new System.Windows.Forms.ComboBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.district_selection_box = new System.Windows.Forms.ComboBox();
            this.date_selection_box = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.crime_type_selction_box);
            this.panel1.Controls.Add(this.box);
            this.panel1.Controls.Add(this.gender_selection_box);
            this.panel1.Controls.Add(this.time_selection_box);
            this.panel1.Controls.Add(this.age_selection_box);
            this.panel1.Controls.Add(this.weapon_selection_box);
            this.panel1.Controls.Add(this.division_selection_box);
            this.panel1.Controls.Add(this.richTextBox6);
            this.panel1.Controls.Add(this.richTextBox5);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox7);
            this.panel1.Controls.Add(this.richTextBox4);
            this.panel1.Controls.Add(this.richTextBox9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.district_selection_box);
            this.panel1.Controls.Add(this.date_selection_box);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // crime_type_selction_box
            // 
            this.crime_type_selction_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crime_type_selction_box.FormattingEnabled = true;
            this.crime_type_selction_box.Items.AddRange(new object[] {
            "All Reported",
            "Murder",
            "Attempted Murder",
            "Hurt",
            "Rioting",
            "Assault on Govt. Servants",
            "Rape",
            "Kidnapping/Abduction",
            "Dacoity",
            "Robbery",
            "Burglary",
            "Motor Vehicles Theft",
            "Cattle Theft",
            "Ordinary Thefts",
            "Misc"});
            this.crime_type_selction_box.Location = new System.Drawing.Point(963, 370);
            this.crime_type_selction_box.Name = "crime_type_selction_box";
            this.crime_type_selction_box.Size = new System.Drawing.Size(256, 26);
            this.crime_type_selction_box.TabIndex = 33;
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.ForeColor = System.Drawing.Color.White;
            this.box.Location = new System.Drawing.Point(960, 321);
            this.box.Name = "box";
            this.box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.box.Size = new System.Drawing.Size(273, 37);
            this.box.TabIndex = 32;
            this.box.Text = "Select Crime Type";
            // 
            // gender_selection_box
            // 
            this.gender_selection_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_selection_box.FormattingEnabled = true;
            this.gender_selection_box.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender_selection_box.Location = new System.Drawing.Point(40, 370);
            this.gender_selection_box.Name = "gender_selection_box";
            this.gender_selection_box.Size = new System.Drawing.Size(256, 26);
            this.gender_selection_box.TabIndex = 31;
            // 
            // time_selection_box
            // 
            this.time_selection_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_selection_box.FormattingEnabled = true;
            this.time_selection_box.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.time_selection_box.Location = new System.Drawing.Point(641, 370);
            this.time_selection_box.Name = "time_selection_box";
            this.time_selection_box.Size = new System.Drawing.Size(256, 26);
            this.time_selection_box.TabIndex = 30;
            this.time_selection_box.SelectedIndexChanged += new System.EventHandler(this.time_selection_box_SelectedIndexChanged);
            // 
            // age_selection_box
            // 
            this.age_selection_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_selection_box.FormattingEnabled = true;
            this.age_selection_box.Items.AddRange(new object[] {
            "Teenager",
            "Adult",
            "Senior Citizen"});
            this.age_selection_box.Location = new System.Drawing.Point(341, 370);
            this.age_selection_box.Name = "age_selection_box";
            this.age_selection_box.Size = new System.Drawing.Size(256, 26);
            this.age_selection_box.TabIndex = 29;
            // 
            // weapon_selection_box
            // 
            this.weapon_selection_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_selection_box.FormattingEnabled = true;
            this.weapon_selection_box.Items.AddRange(new object[] {
            "Pistol",
            "Sniper Rifle",
            "Knife",
            "Shotgun",
            "Grenade",
            "Rifle"});
            this.weapon_selection_box.Location = new System.Drawing.Point(963, 198);
            this.weapon_selection_box.Name = "weapon_selection_box";
            this.weapon_selection_box.Size = new System.Drawing.Size(256, 26);
            this.weapon_selection_box.TabIndex = 28;
            // 
            // division_selection_box
            // 
            this.division_selection_box.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_selection_box.FormattingEnabled = true;
            this.division_selection_box.Items.AddRange(new object[] {
            "Select Division",
            "Bahawalpur",
            "Dera Ghazi Khan",
            "Faisalabad",
            "Gujranwala",
            "Lahore",
            "Multan",
            "Rawalpindi",
            "Sargodha",
            "Sahiwal"});
            this.division_selection_box.Location = new System.Drawing.Point(40, 202);
            this.division_selection_box.Name = "division_selection_box";
            this.division_selection_box.Size = new System.Drawing.Size(256, 26);
            this.division_selection_box.TabIndex = 27;
            this.division_selection_box.SelectedIndexChanged += new System.EventHandler(this.division_selection_box_SelectedIndexChanged);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(341, 321);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox6.Size = new System.Drawing.Size(273, 28);
            this.richTextBox6.TabIndex = 26;
            this.richTextBox6.Text = "Select Age Group";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(641, 321);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(273, 43);
            this.richTextBox5.TabIndex = 25;
            this.richTextBox5.Text = "Select Time";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(963, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(273, 52);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "Select Weapon";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.White;
            this.richTextBox7.Location = new System.Drawing.Point(40, 321);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox7.Size = new System.Drawing.Size(273, 28);
            this.richTextBox7.TabIndex = 23;
            this.richTextBox7.Text = "Select Gender";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(641, 145);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(273, 52);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "Select Date";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged_1);
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.ForeColor = System.Drawing.Color.White;
            this.richTextBox9.Location = new System.Drawing.Point(341, 145);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox9.Size = new System.Drawing.Size(273, 52);
            this.richTextBox9.TabIndex = 19;
            this.richTextBox9.Text = "Select District";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(246, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(801, 75);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(40, 145);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(273, 52);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "Select Division";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(455, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(352, 61);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "New Crime Entry";
            this.richTextBox1.UseWaitCursor = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // district_selection_box
            // 
            this.district_selection_box.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.district_selection_box.FormattingEnabled = true;
            this.district_selection_box.Items.AddRange(new object[] {
            "",
            "Bahawalpur",
            "Bahawalnagar",
            "R.Y.Khan",
            "D.G.Khan",
            "Layyah",
            "Muzaffargarh",
            "Rajanpur",
            "Faisalabad",
            "Jhang",
            "T.T.Singh",
            "Gujranwala",
            "Gujrat",
            "Hafizabad",
            "Mandi Baha-ud-Din",
            "Narowal",
            "Sialkot",
            "Lahore",
            "Kasur",
            "Okara",
            "Sheikhupura",
            "Multan",
            "Khanewal",
            "Lodhran",
            "Vehari",
            "Sahiwal",
            "Pakpattan",
            "Rawalpindi",
            "Attock",
            "Chakwal",
            "Jhelum",
            "Sargodha",
            "Bhakkar",
            "Khushab",
            "Mianwali",
            "Nankana Sahib",
            "Chiniot"});
            this.district_selection_box.Location = new System.Drawing.Point(341, 202);
            this.district_selection_box.Name = "district_selection_box";
            this.district_selection_box.Size = new System.Drawing.Size(256, 26);
            this.district_selection_box.TabIndex = 3;
            this.district_selection_box.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // date_selection_box
            // 
            this.date_selection_box.Location = new System.Drawing.Point(641, 204);
            this.date_selection_box.Name = "date_selection_box";
            this.date_selection_box.Size = new System.Drawing.Size(256, 20);
            this.date_selection_box.TabIndex = 0;
            this.date_selection_box.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // crime_input_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "crime_input_page";
            this.Text = "crime_input_page";
            this.Load += new System.EventHandler(this.crime_input_page_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_selection_box;
        private System.Windows.Forms.ComboBox district_selection_box;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.ComboBox division_selection_box;
        private System.Windows.Forms.ComboBox weapon_selection_box;
        private System.Windows.Forms.ComboBox gender_selection_box;
        private System.Windows.Forms.ComboBox time_selection_box;
        private System.Windows.Forms.ComboBox age_selection_box;
        private System.Windows.Forms.ComboBox crime_type_selction_box;
        private System.Windows.Forms.RichTextBox box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}