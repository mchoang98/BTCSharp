namespace THChuong4
{
    partial class Form6
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
            this.radioVietnam = new System.Windows.Forms.RadioButton();
            this.radioUsa = new System.Windows.Forms.RadioButton();
            this.radioItaly = new System.Windows.Forms.RadioButton();
            this.radioPhilip = new System.Windows.Forms.RadioButton();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(123, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPhilip);
            this.groupBox1.Controls.Add(this.radioItaly);
            this.groupBox1.Controls.Add(this.radioUsa);
            this.groupBox1.Controls.Add(this.radioVietnam);
            this.groupBox1.Location = new System.Drawing.Point(211, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radioVietnam
            // 
            this.radioVietnam.AutoSize = true;
            this.radioVietnam.Location = new System.Drawing.Point(52, 19);
            this.radioVietnam.Name = "radioVietnam";
            this.radioVietnam.Size = new System.Drawing.Size(63, 17);
            this.radioVietnam.TabIndex = 0;
            this.radioVietnam.TabStop = true;
            this.radioVietnam.Text = "Vietnam";
            this.radioVietnam.UseVisualStyleBackColor = true;
            this.radioVietnam.CheckedChanged += new System.EventHandler(this.radioVietnam_CheckedChanged);
            // 
            // radioUsa
            // 
            this.radioUsa.AutoSize = true;
            this.radioUsa.Location = new System.Drawing.Point(52, 42);
            this.radioUsa.Name = "radioUsa";
            this.radioUsa.Size = new System.Drawing.Size(47, 17);
            this.radioUsa.TabIndex = 1;
            this.radioUsa.TabStop = true;
            this.radioUsa.Text = "USA";
            this.radioUsa.UseVisualStyleBackColor = true;
            this.radioUsa.CheckedChanged += new System.EventHandler(this.radioUsa_CheckedChanged);
            // 
            // radioItaly
            // 
            this.radioItaly.AutoSize = true;
            this.radioItaly.Location = new System.Drawing.Point(52, 65);
            this.radioItaly.Name = "radioItaly";
            this.radioItaly.Size = new System.Drawing.Size(44, 17);
            this.radioItaly.TabIndex = 2;
            this.radioItaly.TabStop = true;
            this.radioItaly.Text = "Italy";
            this.radioItaly.UseVisualStyleBackColor = true;
            this.radioItaly.CheckedChanged += new System.EventHandler(this.radioItaly_CheckedChanged);
            // 
            // radioPhilip
            // 
            this.radioPhilip.AutoSize = true;
            this.radioPhilip.Location = new System.Drawing.Point(52, 88);
            this.radioPhilip.Name = "radioPhilip";
            this.radioPhilip.Size = new System.Drawing.Size(75, 17);
            this.radioPhilip.TabIndex = 3;
            this.radioPhilip.TabStop = true;
            this.radioPhilip.Text = "Philippines";
            this.radioPhilip.UseVisualStyleBackColor = true;
            this.radioPhilip.CheckedChanged += new System.EventHandler(this.radioPhilip_CheckedChanged);
            // 
            // picturebox1
            // 
            this.picturebox1.Image = global::THChuong4.Properties.Resources.vietnam;
            this.picturebox1.Location = new System.Drawing.Point(450, 193);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(187, 134);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox1.TabIndex = 4;
            this.picturebox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "frmQuocGia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPhilip;
        private System.Windows.Forms.RadioButton radioItaly;
        private System.Windows.Forms.RadioButton radioUsa;
        private System.Windows.Forms.RadioButton radioVietnam;
        private System.Windows.Forms.PictureBox picturebox1;
    }
}