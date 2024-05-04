namespace Crime_App
{
    partial class prisoner_form
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.prisonerDuration = new LiveCharts.WinForms.PieChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewMedicalReport = new System.Windows.Forms.Panel();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.getToDoctor = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.registerInActivity = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.viewBelongings = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.newPrisoner = new System.Windows.Forms.Panel();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.activity = new LiveCharts.WinForms.PieChart();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.gender = new LiveCharts.WinForms.PieChart();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.viewMedicalReport.SuspendLayout();
            this.getToDoctor.SuspendLayout();
            this.registerInActivity.SuspendLayout();
            this.viewBelongings.SuspendLayout();
            this.newPrisoner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.richTextBox9);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.richTextBox8);
            this.panel1.Controls.Add(this.activity);
            this.panel1.Controls.Add(this.richTextBox7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.prisonerDuration);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.viewMedicalReport);
            this.panel1.Controls.Add(this.getToDoctor);
            this.panel1.Controls.Add(this.registerInActivity);
            this.panel1.Controls.Add(this.viewBelongings);
            this.panel1.Controls.Add(this.newPrisoner);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 659);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(227, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(397, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(914, 49);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Prisoner Cell";
            // 
            // prisonerDuration
            // 
            this.prisonerDuration.Location = new System.Drawing.Point(980, 98);
            this.prisonerDuration.Name = "prisonerDuration";
            this.prisonerDuration.Size = new System.Drawing.Size(321, 253);
            this.prisonerDuration.TabIndex = 7;
            this.prisonerDuration.Text = "pieChart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewMedicalReport
            // 
            this.viewMedicalReport.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.viewMedicalReport.Controls.Add(this.richTextBox6);
            this.viewMedicalReport.Controls.Add(this.button4);
            this.viewMedicalReport.Location = new System.Drawing.Point(324, 381);
            this.viewMedicalReport.Name = "viewMedicalReport";
            this.viewMedicalReport.Size = new System.Drawing.Size(307, 267);
            this.viewMedicalReport.TabIndex = 1;
            this.viewMedicalReport.Paint += new System.Windows.Forms.PaintEventHandler(this.viewMedicalReport_Paint);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(52, 24);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox6.Size = new System.Drawing.Size(220, 32);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = "View Medical Report";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.Location = new System.Drawing.Point(3, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(301, 137);
            this.button4.TabIndex = 5;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // getToDoctor
            // 
            this.getToDoctor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.getToDoctor.Controls.Add(this.richTextBox4);
            this.getToDoctor.Controls.Add(this.button3);
            this.getToDoctor.Location = new System.Drawing.Point(11, 381);
            this.getToDoctor.Name = "getToDoctor";
            this.getToDoctor.Size = new System.Drawing.Size(307, 267);
            this.getToDoctor.TabIndex = 4;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(55, 24);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(220, 32);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = "Prisoner Check Up";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.Location = new System.Drawing.Point(3, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 137);
            this.button3.TabIndex = 5;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // registerInActivity
            // 
            this.registerInActivity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.registerInActivity.Controls.Add(this.richTextBox1);
            this.registerInActivity.Controls.Add(this.button1);
            this.registerInActivity.Location = new System.Drawing.Point(324, 84);
            this.registerInActivity.Name = "registerInActivity";
            this.registerInActivity.Size = new System.Drawing.Size(307, 267);
            this.registerInActivity.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(52, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(220, 32);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Register In Activity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(3, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 137);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBelongings
            // 
            this.viewBelongings.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.viewBelongings.Controls.Add(this.richTextBox3);
            this.viewBelongings.Controls.Add(this.button2);
            this.viewBelongings.Location = new System.Drawing.Point(637, 84);
            this.viewBelongings.Name = "viewBelongings";
            this.viewBelongings.Size = new System.Drawing.Size(307, 267);
            this.viewBelongings.TabIndex = 2;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(67, 21);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(184, 32);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "View Belongings";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.Location = new System.Drawing.Point(3, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 137);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newPrisoner
            // 
            this.newPrisoner.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newPrisoner.Controls.Add(this.richTextBox5);
            this.newPrisoner.Controls.Add(this.button6);
            this.newPrisoner.Location = new System.Drawing.Point(11, 84);
            this.newPrisoner.Name = "newPrisoner";
            this.newPrisoner.Size = new System.Drawing.Size(307, 267);
            this.newPrisoner.TabIndex = 0;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(55, 19);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(220, 32);
            this.richTextBox5.TabIndex = 6;
            this.richTextBox5.Text = "Add New Prisoner";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.Location = new System.Drawing.Point(3, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(301, 137);
            this.button6.TabIndex = 5;
            this.button6.Text = "Enter";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.White;
            this.richTextBox7.Location = new System.Drawing.Point(950, 29);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox7.Size = new System.Drawing.Size(184, 63);
            this.richTextBox7.TabIndex = 9;
            this.richTextBox7.Text = "By Prisoner Duration";
            // 
            // activity
            // 
            this.activity.Location = new System.Drawing.Point(640, 381);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(321, 253);
            this.activity.TabIndex = 10;
            this.activity.Text = "pieChart1";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(890, 357);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox8.Size = new System.Drawing.Size(184, 56);
            this.richTextBox8.TabIndex = 11;
            this.richTextBox8.Text = "By Prisoner Activity";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(1061, 444);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(194, 119);
            this.gender.TabIndex = 12;
            this.gender.Text = "pieChart2";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.ForeColor = System.Drawing.Color.White;
            this.richTextBox9.Location = new System.Drawing.Point(1096, 393);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox9.Size = new System.Drawing.Size(184, 32);
            this.richTextBox9.TabIndex = 13;
            this.richTextBox9.Text = "By Gender";
            // 
            // prisoner_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "prisoner_form";
            this.Text = "prisoner_form";
            this.Load += new System.EventHandler(this.prisoner_form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.viewMedicalReport.ResumeLayout(false);
            this.getToDoctor.ResumeLayout(false);
            this.registerInActivity.ResumeLayout(false);
            this.viewBelongings.ResumeLayout(false);
            this.newPrisoner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel registerInActivity;
        private System.Windows.Forms.Panel viewBelongings;
        private System.Windows.Forms.Panel viewMedicalReport;
        private System.Windows.Forms.Panel newPrisoner;
        private System.Windows.Forms.Panel getToDoctor;
        private LiveCharts.WinForms.PieChart prisonerDuration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private LiveCharts.WinForms.PieChart gender;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private LiveCharts.WinForms.PieChart activity;
    }
}