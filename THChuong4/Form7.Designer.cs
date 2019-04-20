namespace THChuong4
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDaNhap = new System.Windows.Forms.ComboBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnDemChan = new System.Windows.Forms.Button();
            this.btnDemNgto = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listUoc = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboDaNhap);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(68, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // comboDaNhap
            // 
            this.comboDaNhap.FormattingEnabled = true;
            this.comboDaNhap.Location = new System.Drawing.Point(18, 69);
            this.comboDaNhap.Name = "comboDaNhap";
            this.comboDaNhap.Size = new System.Drawing.Size(194, 21);
            this.comboDaNhap.TabIndex = 2;
            this.comboDaNhap.SelectedIndexChanged += new System.EventHandler(this.comboDaNhap_SelectedIndexChanged);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(137, 30);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "&Cập Nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(18, 30);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(106, 20);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Location = new System.Drawing.Point(372, 191);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(190, 23);
            this.btnTongUoc.TabIndex = 4;
            this.btnTongUoc.Text = "Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnDemChan
            // 
            this.btnDemChan.Location = new System.Drawing.Point(372, 233);
            this.btnDemChan.Name = "btnDemChan";
            this.btnDemChan.Size = new System.Drawing.Size(190, 23);
            this.btnDemChan.TabIndex = 5;
            this.btnDemChan.Text = "Số lượng các ước số chẵn";
            this.btnDemChan.UseVisualStyleBackColor = true;
            this.btnDemChan.Click += new System.EventHandler(this.btnDemChan_Click);
            // 
            // btnDemNgto
            // 
            this.btnDemNgto.Location = new System.Drawing.Point(372, 272);
            this.btnDemNgto.Name = "btnDemNgto";
            this.btnDemNgto.Size = new System.Drawing.Size(190, 23);
            this.btnDemNgto.TabIndex = 6;
            this.btnDemNgto.Text = "Số lượng các ước số nguyên tố";
            this.btnDemNgto.UseVisualStyleBackColor = true;
            this.btnDemNgto.Click += new System.EventHandler(this.btnDemNgto_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(225, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 31);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listUoc
            // 
            this.listUoc.FormattingEnabled = true;
            this.listUoc.Location = new System.Drawing.Point(28, 30);
            this.listUoc.Name = "listUoc";
            this.listUoc.Size = new System.Drawing.Size(141, 95);
            this.listUoc.TabIndex = 3;
            this.listUoc.SelectedIndexChanged += new System.EventHandler(this.listUoc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUoc);
            this.groupBox2.Location = new System.Drawing.Point(372, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDemNgto);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.btnDemChan);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ComboBox comboDaNhap;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnDemChan;
        private System.Windows.Forms.Button btnDemNgto;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox listUoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}