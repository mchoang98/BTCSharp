namespace THChuong4
{
    partial class Form11
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
            this.redValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redValue
            // 
            this.redValue.AutoSize = true;
            this.redValue.BackColor = System.Drawing.Color.White;
            this.redValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redValue.ForeColor = System.Drawing.Color.Red;
            this.redValue.Location = new System.Drawing.Point(119, 1);
            this.redValue.Name = "redValue";
            this.redValue.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.redValue.Size = new System.Drawing.Size(41, 28);
            this.redValue.TabIndex = 3;
            this.redValue.Text = "R=0";
            // 
            // greenValue
            // 
            this.greenValue.AutoSize = true;
            this.greenValue.BackColor = System.Drawing.Color.White;
            this.greenValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenValue.ForeColor = System.Drawing.Color.Lime;
            this.greenValue.Location = new System.Drawing.Point(119, 40);
            this.greenValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.greenValue.Name = "greenValue";
            this.greenValue.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.greenValue.Size = new System.Drawing.Size(41, 28);
            this.greenValue.TabIndex = 4;
            this.greenValue.Text = "G=0";
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.BackColor = System.Drawing.Color.White;
            this.blueValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueValue.ForeColor = System.Drawing.Color.Blue;
            this.blueValue.Location = new System.Drawing.Point(119, 76);
            this.blueValue.Name = "blueValue";
            this.blueValue.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.blueValue.Size = new System.Drawing.Size(40, 28);
            this.blueValue.TabIndex = 5;
            this.blueValue.Text = "B=0";
            this.blueValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BlueBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RedBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GreenBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.greenValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.blueValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.redValue, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 109);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // BlueBar
            // 
            this.BlueBar.BackColor = System.Drawing.Color.Gray;
            this.BlueBar.Location = new System.Drawing.Point(4, 79);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(108, 26);
            this.BlueBar.TabIndex = 3;
            this.BlueBar.Scroll += new System.EventHandler(this.onChangeColor);
            // 
            // RedBar
            // 
            this.RedBar.BackColor = System.Drawing.Color.Gray;
            this.RedBar.Location = new System.Drawing.Point(4, 4);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(108, 29);
            this.RedBar.TabIndex = 1;
            this.RedBar.Scroll += new System.EventHandler(this.onChangeColor);
            // 
            // GreenBar
            // 
            this.GreenBar.BackColor = System.Drawing.Color.Gray;
            this.GreenBar.Location = new System.Drawing.Point(4, 40);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(108, 32);
            this.GreenBar.TabIndex = 2;
            this.GreenBar.Scroll += new System.EventHandler(this.onChangeColor);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(360, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 109);
            this.panel1.TabIndex = 8;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form11";
            this.Text = "Đổi màu Panel";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label redValue;
        private System.Windows.Forms.Label greenValue;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.Panel panel1;
    }
}