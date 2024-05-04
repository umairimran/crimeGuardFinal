namespace Crime_App
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.district = new System.Windows.Forms.RichTextBox();
            this.weapon = new System.Windows.Forms.RichTextBox();
            this.day_night = new System.Windows.Forms.RichTextBox();
            this.crimeType = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // district
            // 
            this.district.BackColor = System.Drawing.Color.CornflowerBlue;
            this.district.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.district.Cursor = System.Windows.Forms.Cursors.No;
            this.district.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.ForeColor = System.Drawing.Color.Yellow;
            this.district.Location = new System.Drawing.Point(4, 4);
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.district.Size = new System.Drawing.Size(100, 18);
            this.district.TabIndex = 0;
            this.district.Text = "district";
            // 
            // weapon
            // 
            this.weapon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weapon.Cursor = System.Windows.Forms.Cursors.No;
            this.weapon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon.ForeColor = System.Drawing.Color.White;
            this.weapon.Location = new System.Drawing.Point(-1, 40);
            this.weapon.Name = "weapon";
            this.weapon.ReadOnly = true;
            this.weapon.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.weapon.Size = new System.Drawing.Size(57, 18);
            this.weapon.TabIndex = 1;
            this.weapon.Text = "weapon";
            // 
            // day_night
            // 
            this.day_night.BackColor = System.Drawing.Color.CornflowerBlue;
            this.day_night.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.day_night.Cursor = System.Windows.Forms.Cursors.No;
            this.day_night.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_night.ForeColor = System.Drawing.Color.White;
            this.day_night.Location = new System.Drawing.Point(108, 40);
            this.day_night.Name = "day_night";
            this.day_night.ReadOnly = true;
            this.day_night.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.day_night.Size = new System.Drawing.Size(67, 18);
            this.day_night.TabIndex = 2;
            this.day_night.Text = "day_night";
            // 
            // crimeType
            // 
            this.crimeType.BackColor = System.Drawing.Color.CornflowerBlue;
            this.crimeType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crimeType.Cursor = System.Windows.Forms.Cursors.No;
            this.crimeType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeType.ForeColor = System.Drawing.Color.White;
            this.crimeType.Location = new System.Drawing.Point(78, 3);
            this.crimeType.Name = "crimeType";
            this.crimeType.ReadOnly = true;
            this.crimeType.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.crimeType.Size = new System.Drawing.Size(97, 31);
            this.crimeType.TabIndex = 3;
            this.crimeType.Text = "crime_type";
            this.crimeType.TextChanged += new System.EventHandler(this.crimeType_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.crimeType);
            this.Controls.Add(this.day_night);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.district);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(178, 78);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox district;
        private System.Windows.Forms.RichTextBox weapon;
        private System.Windows.Forms.RichTextBox day_night;
        private System.Windows.Forms.RichTextBox crimeType;
    }
}
