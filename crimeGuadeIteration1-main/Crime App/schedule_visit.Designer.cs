namespace Crime_App
{
    partial class schedule_visit
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
            this.purposeOfVisit = new System.Windows.Forms.RichTextBox();
            this.durationOfVisit = new System.Windows.Forms.RichTextBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.selectVisitorId = new System.Windows.Forms.ComboBox();
            this.entryDateTime = new System.Windows.Forms.DateTimePicker();
            this.exitDateTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.prisonerName = new System.Windows.Forms.RichTextBox();
            this.visitorName = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(79, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Select prisoner id";
            // 
            // purposeOfVisit
            // 
            this.purposeOfVisit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purposeOfVisit.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposeOfVisit.ForeColor = System.Drawing.Color.Blue;
            this.purposeOfVisit.Location = new System.Drawing.Point(352, 287);
            this.purposeOfVisit.Name = "purposeOfVisit";
            this.purposeOfVisit.Size = new System.Drawing.Size(319, 39);
            this.purposeOfVisit.TabIndex = 8;
            this.purposeOfVisit.Text = "";
            // 
            // durationOfVisit
            // 
            this.durationOfVisit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durationOfVisit.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationOfVisit.ForeColor = System.Drawing.Color.Blue;
            this.durationOfVisit.Location = new System.Drawing.Point(1023, 153);
            this.durationOfVisit.Name = "durationOfVisit";
            this.durationOfVisit.Size = new System.Drawing.Size(289, 39);
            this.durationOfVisit.TabIndex = 11;
            this.durationOfVisit.Text = "";
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrisonerId.ForeColor = System.Drawing.Color.Blue;
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(352, 154);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(319, 38);
            this.selectPrisonerId.TabIndex = 14;
            this.selectPrisonerId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonerId_SelectedIndexChanged);
            // 
            // selectVisitorId
            // 
            this.selectVisitorId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVisitorId.ForeColor = System.Drawing.Color.Blue;
            this.selectVisitorId.FormattingEnabled = true;
            this.selectVisitorId.Location = new System.Drawing.Point(352, 220);
            this.selectVisitorId.Name = "selectVisitorId";
            this.selectVisitorId.Size = new System.Drawing.Size(319, 38);
            this.selectVisitorId.TabIndex = 15;
            // 
            // entryDateTime
            // 
            this.entryDateTime.Location = new System.Drawing.Point(369, 352);
            this.entryDateTime.Name = "entryDateTime";
            this.entryDateTime.Size = new System.Drawing.Size(302, 20);
            this.entryDateTime.TabIndex = 16;
            // 
            // exitDateTime
            // 
            this.exitDateTime.Location = new System.Drawing.Point(369, 415);
            this.exitDateTime.Name = "exitDateTime";
            this.exitDateTime.Size = new System.Drawing.Size(302, 20);
            this.exitDateTime.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1300, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prisonerName
            // 
            this.prisonerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prisonerName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonerName.Location = new System.Drawing.Point(1023, 219);
            this.prisonerName.Name = "prisonerName";
            this.prisonerName.Size = new System.Drawing.Size(289, 39);
            this.prisonerName.TabIndex = 20;
            this.prisonerName.Text = "";
            // 
            // visitorName
            // 
            this.visitorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visitorName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorName.ForeColor = System.Drawing.Color.Blue;
            this.visitorName.Location = new System.Drawing.Point(1023, 281);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(289, 39);
            this.visitorName.TabIndex = 22;
            this.visitorName.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(322, 14);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(481, 48);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "Schedule Visit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox8
            // 
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.Location = new System.Drawing.Point(79, 223);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(231, 39);
            this.richTextBox8.TabIndex = 25;
            this.richTextBox8.Text = "Select Visitor Id";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(79, 287);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(231, 39);
            this.richTextBox6.TabIndex = 26;
            this.richTextBox6.Text = "Purpose Of Visit";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(79, 346);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(284, 39);
            this.richTextBox5.TabIndex = 27;
            this.richTextBox5.Text = "Select Enter Time Date";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(79, 409);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(284, 39);
            this.richTextBox3.TabIndex = 28;
            this.richTextBox3.Text = "Select Exit Time Date";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Black;
            this.richTextBox4.Location = new System.Drawing.Point(746, 153);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(247, 39);
            this.richTextBox4.TabIndex = 29;
            this.richTextBox4.Text = "Duration In Minutes";
            // 
            // richTextBox10
            // 
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox10.ForeColor = System.Drawing.Color.Black;
            this.richTextBox10.Location = new System.Drawing.Point(746, 223);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(247, 39);
            this.richTextBox10.TabIndex = 30;
            this.richTextBox10.Text = "Prisoner Name";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.Black;
            this.richTextBox7.Location = new System.Drawing.Point(746, 281);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(247, 39);
            this.richTextBox7.TabIndex = 31;
            this.richTextBox7.Text = "Visitor Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.d;
            this.pictureBox2.Location = new System.Drawing.Point(188, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // schedule_visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.visitorName);
            this.Controls.Add(this.prisonerName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitDateTime);
            this.Controls.Add(this.entryDateTime);
            this.Controls.Add(this.selectVisitorId);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.durationOfVisit);
            this.Controls.Add(this.purposeOfVisit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "schedule_visit";
            this.Text = "v";
            this.Load += new System.EventHandler(this.schedule_visit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox purposeOfVisit;
        private System.Windows.Forms.RichTextBox durationOfVisit;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.ComboBox selectVisitorId;
        private System.Windows.Forms.DateTimePicker entryDateTime;
        private System.Windows.Forms.DateTimePicker exitDateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox prisonerName;
        private System.Windows.Forms.RichTextBox visitorName;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}