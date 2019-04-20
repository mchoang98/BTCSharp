namespace THChuong4
{
    partial class Form8
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTongList = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnThayBphuong = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(166, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 147);
            this.listBox1.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(24, 54);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(119, 33);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTongList
            // 
            this.btnTongList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongList.Location = new System.Drawing.Point(20, 27);
            this.btnTongList.Name = "btnTongList";
            this.btnTongList.Size = new System.Drawing.Size(230, 36);
            this.btnTongList.TabIndex = 5;
            this.btnTongList.Text = "Tổng các phần tử trong List";
            this.btnTongList.UseVisualStyleBackColor = true;
            this.btnTongList.Click += new System.EventHandler(this.btnTongList_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(20, 69);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(230, 30);
            this.btnXoaDauCuoi.TabIndex = 6;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChon.Location = new System.Drawing.Point(20, 105);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(230, 29);
            this.btnXoaChon.TabIndex = 7;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang2.Location = new System.Drawing.Point(20, 140);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(230, 30);
            this.btnTang2.TabIndex = 8;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnThayBphuong
            // 
            this.btnThayBphuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayBphuong.Location = new System.Drawing.Point(20, 176);
            this.btnThayBphuong.Name = "btnThayBphuong";
            this.btnThayBphuong.Size = new System.Drawing.Size(230, 30);
            this.btnThayBphuong.TabIndex = 9;
            this.btnThayBphuong.Text = "Thay bằng bình phương";
            this.btnThayBphuong.UseVisualStyleBackColor = true;
            this.btnThayBphuong.Click += new System.EventHandler(this.btnThayBphuong_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonChan.Location = new System.Drawing.Point(20, 212);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(230, 30);
            this.btnChonChan.TabIndex = 10;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // btnChonLe
            // 
            this.btnChonLe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonLe.Location = new System.Drawing.Point(20, 248);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(230, 30);
            this.btnChonLe.TabIndex = 11;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(54, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(506, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "KẾT THÚC";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(22, 15);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(121, 20);
            this.txtNhap.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNhap);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(54, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 262);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listbox";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChonLe);
            this.groupBox3.Controls.Add(this.btnChonChan);
            this.groupBox3.Controls.Add(this.btnThayBphuong);
            this.groupBox3.Controls.Add(this.btnTang2);
            this.groupBox3.Controls.Add(this.btnXoaChon);
            this.groupBox3.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox3.Controls.Add(this.btnTongList);
            this.groupBox3.Location = new System.Drawing.Point(310, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 292);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý Listbox";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(40, 70);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTongList;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnThayBphuong;
        private System.Windows.Forms.Button btnChonChan;
        private System.Windows.Forms.Button btnChonLe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}