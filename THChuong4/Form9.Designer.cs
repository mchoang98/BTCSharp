namespace THChuong4
{
    partial class Form9
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnOneA2B = new System.Windows.Forms.Button();
            this.btnAllA2B = new System.Windows.Forms.Button();
            this.btnOneB2A = new System.Windows.Forms.Button();
            this.btnAllB2A = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(250, 5, 250, 5);
            this.label1.Size = new System.Drawing.Size(784, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 173);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 186);
            this.listBox2.TabIndex = 4;
            // 
            // btnOneA2B
            // 
            this.btnOneA2B.Location = new System.Drawing.Point(359, 163);
            this.btnOneA2B.Name = "btnOneA2B";
            this.btnOneA2B.Size = new System.Drawing.Size(75, 23);
            this.btnOneA2B.TabIndex = 5;
            this.btnOneA2B.Text = ">";
            this.btnOneA2B.UseVisualStyleBackColor = true;
            this.btnOneA2B.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllA2B
            // 
            this.btnAllA2B.Location = new System.Drawing.Point(359, 204);
            this.btnAllA2B.Name = "btnAllA2B";
            this.btnAllA2B.Size = new System.Drawing.Size(75, 23);
            this.btnAllA2B.TabIndex = 6;
            this.btnAllA2B.Text = ">>";
            this.btnAllA2B.UseVisualStyleBackColor = true;
            this.btnAllA2B.Click += new System.EventHandler(this.btnAllA2B_Click);
            // 
            // btnOneB2A
            // 
            this.btnOneB2A.Location = new System.Drawing.Point(359, 251);
            this.btnOneB2A.Name = "btnOneB2A";
            this.btnOneB2A.Size = new System.Drawing.Size(75, 23);
            this.btnOneB2A.TabIndex = 7;
            this.btnOneB2A.Text = "<";
            this.btnOneB2A.UseVisualStyleBackColor = true;
            this.btnOneB2A.Click += new System.EventHandler(this.btnOneB2A_Click);
            // 
            // btnAllB2A
            // 
            this.btnAllB2A.Location = new System.Drawing.Point(359, 291);
            this.btnAllB2A.Name = "btnAllB2A";
            this.btnAllB2A.Size = new System.Drawing.Size(75, 23);
            this.btnAllB2A.TabIndex = 8;
            this.btnAllB2A.Text = "<<";
            this.btnAllB2A.UseVisualStyleBackColor = true;
            this.btnAllB2A.Click += new System.EventHandler(this.btnAllB2A_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(192, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(528, 376);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "&Kết thúc";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(125, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(465, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 229);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(231, 66);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(243, 23);
            this.txtNhap.TabIndex = 13;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(527, 66);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(122, 23);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAllB2A);
            this.Controls.Add(this.btnOneB2A);
            this.Controls.Add(this.btnAllA2B);
            this.Controls.Add(this.btnOneA2B);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnOneA2B;
        private System.Windows.Forms.Button btnAllA2B;
        private System.Windows.Forms.Button btnOneB2A;
        private System.Windows.Forms.Button btnAllB2A;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnCapNhat;
    }
}