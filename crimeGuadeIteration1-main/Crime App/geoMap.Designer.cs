using System;
using System.Windows.Forms;

namespace Crime_App
{
    partial class geoMap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.cmbCrimeType = new System.Windows.Forms.ComboBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.cmbAgeGroup = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.richTextBox4);
            this.panel2.Controls.Add(this.cmbCrimeType);
            this.panel2.Controls.Add(this.richTextBox7);
            this.panel2.Controls.Add(this.cmbAgeGroup);
            this.panel2.Controls.Add(this.cmbYear);
            this.panel2.Controls.Add(this.richTextBox6);
            this.panel2.Controls.Add(this.cmbTime);
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.cmbWeapon);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(13, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 582);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.White;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(23, 352);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(100, 26);
            this.richTextBox4.TabIndex = 16;
            this.richTextBox4.Text = "CrimeType";
            // 
            // cmbCrimeType
            // 
            this.cmbCrimeType.FormattingEnabled = true;
            this.cmbCrimeType.Location = new System.Drawing.Point(23, 384);
            this.cmbCrimeType.Name = "cmbCrimeType";
            this.cmbCrimeType.Size = new System.Drawing.Size(121, 21);
            this.cmbCrimeType.TabIndex = 15;
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.White;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.Location = new System.Drawing.Point(23, 279);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox7.Size = new System.Drawing.Size(100, 26);
            this.richTextBox7.TabIndex = 7;
            this.richTextBox7.Text = "Age Group";
            // 
            // cmbAgeGroup
            // 
            this.cmbAgeGroup.FormattingEnabled = true;
            this.cmbAgeGroup.Location = new System.Drawing.Point(23, 311);
            this.cmbAgeGroup.Name = "cmbAgeGroup";
            this.cmbAgeGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbAgeGroup.TabIndex = 14;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(23, 46);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 8;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.White;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(23, 201);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox6.Size = new System.Drawing.Size(100, 26);
            this.richTextBox6.TabIndex = 6;
            this.richTextBox6.Text = "Time";
            this.richTextBox6.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(23, 234);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 13;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(23, 86);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(100, 23);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "Weapon";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(23, 174);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 12;
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Location = new System.Drawing.Point(23, 115);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(121, 21);
            this.cmbWeapon.TabIndex = 11;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(23, 142);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(100, 26);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Gender";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(100, 26);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Year";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Map";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.gMapControl1);
            this.panel3.Location = new System.Drawing.Point(187, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 582);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(1184, 569);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(10, 10);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.richTextBox5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 48);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(223, 0);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(478, 42);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "Geo Map View ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // geoMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "geoMap";
            this.Text = "geomap";
            this.Load += new System.EventHandler(this.geoMap_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }



        private void GMapControl1_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox6_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbAgeGroup;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCrimeType;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox5;
    }
}