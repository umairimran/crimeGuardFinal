namespace Crime_App
{
    partial class new_prisoner_form
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
            this.selectMeetTime = new System.Windows.Forms.ComboBox();
            this.selectGender = new System.Windows.Forms.ComboBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.enterName = new System.Windows.Forms.RichTextBox();
            this.selectPrisonId = new System.Windows.Forms.ComboBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.punishDuration = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectPrisonerDob = new System.Windows.Forms.DateTimePicker();
            this.selectAdmitDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectMeetTime
            // 
            this.selectMeetTime.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMeetTime.ForeColor = System.Drawing.Color.Blue;
            this.selectMeetTime.FormattingEnabled = true;
            this.selectMeetTime.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.selectMeetTime.Location = new System.Drawing.Point(235, 314);
            this.selectMeetTime.Name = "selectMeetTime";
            this.selectMeetTime.Size = new System.Drawing.Size(421, 38);
            this.selectMeetTime.TabIndex = 15;
            // 
            // selectGender
            // 
            this.selectGender.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGender.ForeColor = System.Drawing.Color.Blue;
            this.selectGender.FormattingEnabled = true;
            this.selectGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.selectGender.Location = new System.Drawing.Point(235, 375);
            this.selectGender.Name = "selectGender";
            this.selectGender.Size = new System.Drawing.Size(421, 38);
            this.selectGender.TabIndex = 9;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(12, 314);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(175, 30);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "SelectMeetTime";
            // 
            // enterName
            // 
            this.enterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterName.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enterName.Location = new System.Drawing.Point(235, 178);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(421, 30);
            this.enterName.TabIndex = 3;
            this.enterName.Text = "";
            // 
            // selectPrisonId
            // 
            this.selectPrisonId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrisonId.ForeColor = System.Drawing.Color.Blue;
            this.selectPrisonId.FormattingEnabled = true;
            this.selectPrisonId.Location = new System.Drawing.Point(235, 130);
            this.selectPrisonId.Name = "selectPrisonId";
            this.selectPrisonId.Size = new System.Drawing.Size(234, 38);
            this.selectPrisonId.TabIndex = 1;
            this.selectPrisonId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonId_SelectedIndexChanged);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 26.75F, System.Drawing.FontStyle.Bold);
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(315, 12);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(605, 66);
            this.richTextBox6.TabIndex = 17;
            this.richTextBox6.Text = "Register New Prisoner Form";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.White;
            this.richTextBox7.Location = new System.Drawing.Point(12, 126);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(175, 30);
            this.richTextBox7.TabIndex = 18;
            this.richTextBox7.Text = "SelectPrisonerId";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(222, 33);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "Enter Prisoner Name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(12, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(175, 30);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "Select DOB";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(12, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1300, 89);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(12, 375);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(175, 30);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "Select Gender";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(12, 420);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(175, 30);
            this.richTextBox5.TabIndex = 24;
            this.richTextBox5.Text = "Select Admit Date";
            // 
            // punishDuration
            // 
            this.punishDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.punishDuration.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punishDuration.ForeColor = System.Drawing.Color.Blue;
            this.punishDuration.Location = new System.Drawing.Point(235, 488);
            this.punishDuration.Name = "punishDuration";
            this.punishDuration.Size = new System.Drawing.Size(421, 37);
            this.punishDuration.TabIndex = 25;
            this.punishDuration.Text = "";
            this.punishDuration.TextChanged += new System.EventHandler(this.punishDuration_TextChanged);
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(12, 488);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(217, 30);
            this.richTextBox8.TabIndex = 26;
            this.richTextBox8.Text = "Enter Punish Duration";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(209, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
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
            // selectPrisonerDob
            // 
            this.selectPrisonerDob.Location = new System.Drawing.Point(235, 251);
            this.selectPrisonerDob.Name = "selectPrisonerDob";
            this.selectPrisonerDob.Size = new System.Drawing.Size(421, 20);
            this.selectPrisonerDob.TabIndex = 29;
            // 
            // selectAdmitDate
            // 
            this.selectAdmitDate.Location = new System.Drawing.Point(235, 430);
            this.selectAdmitDate.Name = "selectAdmitDate";
            this.selectAdmitDate.Size = new System.Drawing.Size(421, 20);
            this.selectAdmitDate.TabIndex = 30;
            // 
            // new_prisoner_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.selectAdmitDate);
            this.Controls.Add(this.selectPrisonerDob);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.punishDuration);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectMeetTime);
            this.Controls.Add(this.selectPrisonId);
            this.Controls.Add(this.selectGender);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.richTextBox4);
            this.Name = "new_prisoner_form";
            this.Text = "new_prisoner_form";
            this.Load += new System.EventHandler(this.new_prisoner_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox selectGender;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox enterName;
        private System.Windows.Forms.ComboBox selectPrisonId;
        private System.Windows.Forms.ComboBox selectMeetTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox punishDuration;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker selectPrisonerDob;
        private System.Windows.Forms.DateTimePicker selectAdmitDate;
    }
}