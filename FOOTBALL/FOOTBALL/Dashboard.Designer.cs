namespace FOOTBALL
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnPitchs = new System.Windows.Forms.Button();
            this.btnrezerv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPitch = new System.Windows.Forms.Panel();
            this.dtgViewPitchs = new System.Windows.Forms.DataGridView();
            this.btnPitchEdit = new System.Windows.Forms.Button();
            this.btnPitchDelete = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pitchnumber = new System.Windows.Forms.TextBox();
            this.pitchname = new System.Windows.Forms.TextBox();
            this.numprice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddPitch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewPitchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alizade Stadium";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.btnPitchs);
            this.panel1.Controls.Add(this.btnrezerv);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 622);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 197);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.DarkGreen;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(32, 276);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(240, 55);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // btnPitchs
            // 
            this.btnPitchs.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPitchs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPitchs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPitchs.Location = new System.Drawing.Point(32, 400);
            this.btnPitchs.Name = "btnPitchs";
            this.btnPitchs.Size = new System.Drawing.Size(240, 55);
            this.btnPitchs.TabIndex = 2;
            this.btnPitchs.Text = "Pitchs";
            this.btnPitchs.UseVisualStyleBackColor = false;
            this.btnPitchs.Click += new System.EventHandler(this.BtnPitchs_Click_1);
            // 
            // btnrezerv
            // 
            this.btnrezerv.BackColor = System.Drawing.Color.DarkGreen;
            this.btnrezerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrezerv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrezerv.Location = new System.Drawing.Point(32, 339);
            this.btnrezerv.Name = "btnrezerv";
            this.btnrezerv.Size = new System.Drawing.Size(240, 55);
            this.btnrezerv.TabIndex = 1;
            this.btnrezerv.Text = "Reservation";
            this.btnrezerv.UseVisualStyleBackColor = false;
            this.btnrezerv.Click += new System.EventHandler(this.Btnrezerv_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(292, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 200);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(308, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 416);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panelPitch
            // 
            this.panelPitch.BackColor = System.Drawing.Color.DarkGreen;
            this.panelPitch.Controls.Add(this.dtgViewPitchs);
            this.panelPitch.Controls.Add(this.btnPitchEdit);
            this.panelPitch.Controls.Add(this.btnPitchDelete);
            this.panelPitch.Controls.Add(this.lblError);
            this.panelPitch.Controls.Add(this.pitchnumber);
            this.panelPitch.Controls.Add(this.pitchname);
            this.panelPitch.Controls.Add(this.numprice);
            this.panelPitch.Controls.Add(this.label7);
            this.panelPitch.Controls.Add(this.btnAddPitch);
            this.panelPitch.Controls.Add(this.label8);
            this.panelPitch.Controls.Add(this.label9);
            this.panelPitch.Controls.Add(this.label10);
            this.panelPitch.Location = new System.Drawing.Point(308, 206);
            this.panelPitch.Name = "panelPitch";
            this.panelPitch.Size = new System.Drawing.Size(923, 414);
            this.panelPitch.TabIndex = 19;
            this.panelPitch.Visible = false;
            // 
            // dtgViewPitchs
            // 
            this.dtgViewPitchs.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgViewPitchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewPitchs.Location = new System.Drawing.Point(23, 218);
            this.dtgViewPitchs.Name = "dtgViewPitchs";
            this.dtgViewPitchs.Size = new System.Drawing.Size(726, 182);
            this.dtgViewPitchs.TabIndex = 16;
            this.dtgViewPitchs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgViewPitchs_RowHeaderMouseDoubleClick);
            // 
            // btnPitchEdit
            // 
            this.btnPitchEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPitchEdit.FlatAppearance.BorderSize = 0;
            this.btnPitchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchEdit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPitchEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPitchEdit.Location = new System.Drawing.Point(200, 172);
            this.btnPitchEdit.Name = "btnPitchEdit";
            this.btnPitchEdit.Size = new System.Drawing.Size(151, 40);
            this.btnPitchEdit.TabIndex = 12;
            this.btnPitchEdit.Text = "Edit";
            this.btnPitchEdit.UseVisualStyleBackColor = false;
            this.btnPitchEdit.Visible = false;
            this.btnPitchEdit.Click += new System.EventHandler(this.BtnPitchEdit_Click);
            // 
            // btnPitchDelete
            // 
            this.btnPitchDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPitchDelete.FlatAppearance.BorderSize = 0;
            this.btnPitchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchDelete.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPitchDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPitchDelete.Location = new System.Drawing.Point(381, 172);
            this.btnPitchDelete.Name = "btnPitchDelete";
            this.btnPitchDelete.Size = new System.Drawing.Size(142, 40);
            this.btnPitchDelete.TabIndex = 11;
            this.btnPitchDelete.Text = "Delete";
            this.btnPitchDelete.UseVisualStyleBackColor = false;
            this.btnPitchDelete.Visible = false;
            this.btnPitchDelete.Click += new System.EventHandler(this.BtnPitchDelete_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(529, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(63, 27);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // pitchnumber
            // 
            this.pitchnumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchnumber.Location = new System.Drawing.Point(200, 129);
            this.pitchnumber.Multiline = true;
            this.pitchnumber.Name = "pitchnumber";
            this.pitchnumber.Size = new System.Drawing.Size(151, 35);
            this.pitchnumber.TabIndex = 2;
            // 
            // pitchname
            // 
            this.pitchname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchname.Location = new System.Drawing.Point(23, 131);
            this.pitchname.Multiline = true;
            this.pitchname.Name = "pitchname";
            this.pitchname.Size = new System.Drawing.Size(151, 34);
            this.pitchname.TabIndex = 1;
            // 
            // numprice
            // 
            this.numprice.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numprice.Location = new System.Drawing.Point(381, 130);
            this.numprice.Name = "numprice";
            this.numprice.Size = new System.Drawing.Size(158, 35);
            this.numprice.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(391, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pitch Price";
            // 
            // btnAddPitch
            // 
            this.btnAddPitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddPitch.FlatAppearance.BorderSize = 0;
            this.btnAddPitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPitch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPitch.Location = new System.Drawing.Point(23, 172);
            this.btnAddPitch.Name = "btnAddPitch";
            this.btnAddPitch.Size = new System.Drawing.Size(151, 40);
            this.btnAddPitch.TabIndex = 4;
            this.btnAddPitch.Text = "Add Pitch";
            this.btnAddPitch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(199, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pitch Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pitch Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGreen;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(395, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 73);
            this.label10.TabIndex = 15;
            this.label10.Text = "Pitch";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 611);
            this.Controls.Add(this.panelPitch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPitch.ResumeLayout(false);
            this.panelPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewPitchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnrezerv;
        private System.Windows.Forms.Button btnPitchs;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPitch;
        private System.Windows.Forms.DataGridView dtgViewPitchs;
        private System.Windows.Forms.Button btnPitchEdit;
        private System.Windows.Forms.Button btnPitchDelete;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox pitchnumber;
        private System.Windows.Forms.TextBox pitchname;
        private System.Windows.Forms.NumericUpDown numprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddPitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}