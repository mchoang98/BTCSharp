namespace THChuong4
{
    partial class Form5
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
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radioTimesFont = new System.Windows.Forms.RadioButton();
            this.radioArialFont = new System.Windows.Forms.RadioButton();
            this.radioCourierFont = new System.Windows.Forms.RadioButton();
            this.radioTahomaFont = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Văn bản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtText.ForeColor = System.Drawing.Color.Blue;
            this.txtText.Location = new System.Drawing.Point(179, 112);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(221, 179);
            this.txtText.TabIndex = 5;
            this.txtText.Text = "WHAT FONT IS THIS ?";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(341, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radioTimesFont
            // 
            this.radioTimesFont.AutoSize = true;
            this.radioTimesFont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTimesFont.Location = new System.Drawing.Point(437, 123);
            this.radioTimesFont.Name = "radioTimesFont";
            this.radioTimesFont.Size = new System.Drawing.Size(149, 23);
            this.radioTimesFont.TabIndex = 8;
            this.radioTimesFont.TabStop = true;
            this.radioTimesFont.Text = "Times News Roman";
            this.radioTimesFont.UseVisualStyleBackColor = true;
            this.radioTimesFont.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioArialFont
            // 
            this.radioArialFont.AutoSize = true;
            this.radioArialFont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArialFont.Location = new System.Drawing.Point(437, 164);
            this.radioArialFont.Name = "radioArialFont";
            this.radioArialFont.Size = new System.Drawing.Size(56, 23);
            this.radioArialFont.TabIndex = 9;
            this.radioArialFont.TabStop = true;
            this.radioArialFont.Text = "Arial";
            this.radioArialFont.UseVisualStyleBackColor = true;
            this.radioArialFont.CheckedChanged += new System.EventHandler(this.radioArialFont_CheckedChanged);
            // 
            // radioCourierFont
            // 
            this.radioCourierFont.AutoSize = true;
            this.radioCourierFont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCourierFont.Location = new System.Drawing.Point(437, 240);
            this.radioCourierFont.Name = "radioCourierFont";
            this.radioCourierFont.Size = new System.Drawing.Size(107, 23);
            this.radioCourierFont.TabIndex = 11;
            this.radioCourierFont.TabStop = true;
            this.radioCourierFont.Text = "Courier New";
            this.radioCourierFont.UseVisualStyleBackColor = true;
            this.radioCourierFont.CheckedChanged += new System.EventHandler(this.radioCourierFont_CheckedChanged);
            // 
            // radioTahomaFont
            // 
            this.radioTahomaFont.AutoSize = true;
            this.radioTahomaFont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTahomaFont.Location = new System.Drawing.Point(437, 202);
            this.radioTahomaFont.Name = "radioTahomaFont";
            this.radioTahomaFont.Size = new System.Drawing.Size(75, 23);
            this.radioTahomaFont.TabIndex = 10;
            this.radioTahomaFont.TabStop = true;
            this.radioTahomaFont.Text = "Tahoma";
            this.radioTahomaFont.UseVisualStyleBackColor = true;
            this.radioTahomaFont.CheckedChanged += new System.EventHandler(this.radioTahomaFont_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.radioTimesFont);
            this.Controls.Add(this.radioArialFont);
            this.Controls.Add(this.radioCourierFont);
            this.Controls.Add(this.radioTahomaFont);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "frmFont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radioTimesFont;
        private System.Windows.Forms.RadioButton radioArialFont;
        private System.Windows.Forms.RadioButton radioCourierFont;
        private System.Windows.Forms.RadioButton radioTahomaFont;
    }
}