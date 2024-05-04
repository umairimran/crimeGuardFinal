namespace Crime_App
{
    partial class view_visitors_history
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
            this.selectVisitorId = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.selectPurposeOfVisit = new System.Windows.Forms.ComboBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.selectDurationOfVisit = new System.Windows.Forms.ComboBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.selectPrisonerName = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.selectVisitorName = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(26, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(237, 40);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Select Visitor ID";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // selectVisitorId
            // 
            this.selectVisitorId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVisitorId.ForeColor = System.Drawing.Color.Blue;
            this.selectVisitorId.FormattingEnabled = true;
            this.selectVisitorId.Location = new System.Drawing.Point(273, 156);
            this.selectVisitorId.Name = "selectVisitorId";
            this.selectVisitorId.Size = new System.Drawing.Size(212, 38);
            this.selectVisitorId.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(751, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 385);
            this.dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 164);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.Color.White;
            this.richTextBox7.Location = new System.Drawing.Point(338, 12);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(628, 72);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "View Visitors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(26, 218);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(237, 40);
            this.richTextBox8.TabIndex = 19;
            this.richTextBox8.Text = "Select Prisoner ID";
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrisonerId.ForeColor = System.Drawing.Color.Blue;
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(273, 218);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(212, 38);
            this.selectPrisonerId.TabIndex = 20;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(26, 282);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(227, 75);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "Select Purpose Of Visit";
            // 
            // selectPurposeOfVisit
            // 
            this.selectPurposeOfVisit.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPurposeOfVisit.ForeColor = System.Drawing.Color.Blue;
            this.selectPurposeOfVisit.FormattingEnabled = true;
            this.selectPurposeOfVisit.Location = new System.Drawing.Point(273, 295);
            this.selectPurposeOfVisit.Name = "selectPurposeOfVisit";
            this.selectPurposeOfVisit.Size = new System.Drawing.Size(212, 38);
            this.selectPurposeOfVisit.TabIndex = 22;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(26, 361);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(227, 75);
            this.richTextBox6.TabIndex = 23;
            this.richTextBox6.Text = "Select Duration OF Visit";
            // 
            // selectDurationOfVisit
            // 
            this.selectDurationOfVisit.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDurationOfVisit.ForeColor = System.Drawing.Color.Blue;
            this.selectDurationOfVisit.FormattingEnabled = true;
            this.selectDurationOfVisit.Location = new System.Drawing.Point(273, 361);
            this.selectDurationOfVisit.Name = "selectDurationOfVisit";
            this.selectDurationOfVisit.Size = new System.Drawing.Size(212, 38);
            this.selectDurationOfVisit.TabIndex = 24;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(519, 136);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(237, 58);
            this.richTextBox5.TabIndex = 25;
            this.richTextBox5.Text = "Select Prisoner Name";
            // 
            // selectPrisonerName
            // 
            this.selectPrisonerName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrisonerName.ForeColor = System.Drawing.Color.Blue;
            this.selectPrisonerName.FormattingEnabled = true;
            this.selectPrisonerName.Location = new System.Drawing.Point(754, 136);
            this.selectPrisonerName.Name = "selectPrisonerName";
            this.selectPrisonerName.Size = new System.Drawing.Size(558, 38);
            this.selectPrisonerName.TabIndex = 26;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(519, 200);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(221, 62);
            this.richTextBox3.TabIndex = 27;
            this.richTextBox3.Text = "Select Visitor Name";
            // 
            // selectVisitorName
            // 
            this.selectVisitorName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVisitorName.ForeColor = System.Drawing.Color.Blue;
            this.selectVisitorName.FormattingEnabled = true;
            this.selectVisitorName.Location = new System.Drawing.Point(754, 200);
            this.selectVisitorName.Name = "selectVisitorName";
            this.selectVisitorName.Size = new System.Drawing.Size(558, 38);
            this.selectVisitorName.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.d;
            this.pictureBox2.Location = new System.Drawing.Point(196, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // view_visitors_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.selectVisitorName);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.selectPrisonerName);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.selectDurationOfVisit);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.selectPurposeOfVisit);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectVisitorId);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_visitors_history";
            this.Text = "view_visitors_history";
            this.Load += new System.EventHandler(this.view_visitors_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox selectVisitorId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox selectPurposeOfVisit;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.ComboBox selectDurationOfVisit;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.ComboBox selectPrisonerName;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ComboBox selectVisitorName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}