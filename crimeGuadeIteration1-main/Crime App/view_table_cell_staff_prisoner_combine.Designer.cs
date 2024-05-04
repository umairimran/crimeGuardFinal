namespace Crime_App
{
    partial class view_table_cell_staff_prisoner_combine
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
            this.selectCellid = new System.Windows.Forms.ComboBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.selectStaffId = new System.Windows.Forms.ComboBox();
            this.selectCellId2 = new System.Windows.Forms.ComboBox();
            this.staff_cell_table = new System.Windows.Forms.DataGridView();
            this.prisoner_cell_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staff_cell_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisoner_cell_table)).BeginInit();
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
            this.richTextBox1.Location = new System.Drawing.Point(71, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(190, 33);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Select Cell Id";
            // 
            // selectCellid
            // 
            this.selectCellid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectCellid.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCellid.ForeColor = System.Drawing.Color.Blue;
            this.selectCellid.FormattingEnabled = true;
            this.selectCellid.Location = new System.Drawing.Point(71, 143);
            this.selectCellid.Name = "selectCellid";
            this.selectCellid.Size = new System.Drawing.Size(179, 38);
            this.selectCellid.TabIndex = 2;
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectPrisonerId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrisonerId.ForeColor = System.Drawing.Color.Blue;
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(374, 140);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(178, 38);
            this.selectPrisonerId.TabIndex = 3;
            this.selectPrisonerId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonerId_SelectedIndexChanged);
            // 
            // selectStaffId
            // 
            this.selectStaffId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectStaffId.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStaffId.ForeColor = System.Drawing.Color.Blue;
            this.selectStaffId.FormattingEnabled = true;
            this.selectStaffId.Location = new System.Drawing.Point(1122, 140);
            this.selectStaffId.Name = "selectStaffId";
            this.selectStaffId.Size = new System.Drawing.Size(168, 38);
            this.selectStaffId.TabIndex = 7;
            // 
            // selectCellId2
            // 
            this.selectCellId2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectCellId2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCellId2.ForeColor = System.Drawing.Color.Blue;
            this.selectCellId2.FormattingEnabled = true;
            this.selectCellId2.Location = new System.Drawing.Point(794, 140);
            this.selectCellId2.Name = "selectCellId2";
            this.selectCellId2.Size = new System.Drawing.Size(170, 38);
            this.selectCellId2.TabIndex = 6;
            // 
            // staff_cell_table
            // 
            this.staff_cell_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_cell_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_cell_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.staff_cell_table.Location = new System.Drawing.Point(794, 184);
            this.staff_cell_table.Name = "staff_cell_table";
            this.staff_cell_table.Size = new System.Drawing.Size(518, 386);
            this.staff_cell_table.TabIndex = 8;
            // 
            // prisoner_cell_table
            // 
            this.prisoner_cell_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prisoner_cell_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prisoner_cell_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.prisoner_cell_table.Location = new System.Drawing.Point(46, 184);
            this.prisoner_cell_table.Name = "prisoner_cell_table";
            this.prisoner_cell_table.Size = new System.Drawing.Size(506, 386);
            this.prisoner_cell_table.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1300, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(276, 12);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(568, 66);
            this.richTextBox5.TabIndex = 11;
            this.richTextBox5.Text = "Cell Staff DataBase View";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.White;
            this.richTextBox6.Location = new System.Drawing.Point(374, 101);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(242, 33);
            this.richTextBox6.TabIndex = 13;
            this.richTextBox6.Text = "Select Prisoner Id";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(794, 101);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(190, 33);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "Select Cell Id";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(1122, 101);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(190, 33);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "Select Staff Id";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(817, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "View Cells";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(970, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "View Prisoners";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1167, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 39);
            this.button4.TabIndex = 18;
            this.button4.Text = "View Staff";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crime_App.Properties.Resources.download__5_;
            this.pictureBox2.Location = new System.Drawing.Point(161, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crime_App.Properties.Resources.backwards;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // view_table_cell_staff_prisoner_combine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prisoner_cell_table);
            this.Controls.Add(this.staff_cell_table);
            this.Controls.Add(this.selectStaffId);
            this.Controls.Add(this.selectCellId2);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.selectCellid);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_table_cell_staff_prisoner_combine";
            this.Text = "view_table_cell_staff_prisoner_combine";
            this.Load += new System.EventHandler(this.view_table_cell_staff_prisoner_combine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_cell_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisoner_cell_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox selectCellid;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.ComboBox selectStaffId;
        private System.Windows.Forms.ComboBox selectCellId2;
        private System.Windows.Forms.DataGridView staff_cell_table;
        private System.Windows.Forms.DataGridView prisoner_cell_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}