namespace Bai_2
{
    partial class FrmBai2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVietNam = new System.Windows.Forms.RadioButton();
            this.radPhilippin = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radItalian);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Controls.Add(this.radPhilippin);
            this.groupBox1.Controls.Add(this.radVietNam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radVietNam
            // 
            this.radVietNam.AutoSize = true;
            this.radVietNam.Location = new System.Drawing.Point(7, 44);
            this.radVietNam.Name = "radVietNam";
            this.radVietNam.Size = new System.Drawing.Size(181, 46);
            this.radVietNam.TabIndex = 0;
            this.radVietNam.TabStop = true;
            this.radVietNam.Text = "VietNam";
            this.radVietNam.UseVisualStyleBackColor = true;
            this.radVietNam.CheckedChanged += new System.EventHandler(this.radVietNam_CheckedChanged);
            // 
            // radPhilippin
            // 
            this.radPhilippin.AutoSize = true;
            this.radPhilippin.Location = new System.Drawing.Point(7, 161);
            this.radPhilippin.Name = "radPhilippin";
            this.radPhilippin.Size = new System.Drawing.Size(196, 46);
            this.radPhilippin.TabIndex = 0;
            this.radPhilippin.TabStop = true;
            this.radPhilippin.Text = "Philippine";
            this.radPhilippin.UseVisualStyleBackColor = true;
            this.radPhilippin.CheckedChanged += new System.EventHandler(this.radPhilippin_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(7, 81);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(121, 46);
            this.radUSA.TabIndex = 0;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Location = new System.Drawing.Point(7, 115);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(139, 46);
            this.radItalian.TabIndex = 0;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "Italian";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.radItalian_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Bai_2.Properties.Resources.Italian;
            this.pictureBox1.Location = new System.Drawing.Point(374, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBai2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBai2_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuocGia";
            this.Load += new System.EventHandler(this.FrmBai2_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radPhilippin;
        private System.Windows.Forms.RadioButton radVietNam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

