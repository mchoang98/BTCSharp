using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THChuong4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            txtNghiem.Clear();
            Form2_Load(sender, e);
            txtNhapA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtNhapA, "This is not invalid number");
            else this.errorProvider1.Clear();
        }

        private void txtNhapA_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtNhapA, "You must enter A");
            else this.errorProvider1.Clear();
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtNhapB, "This is not invalid number");
            else this.errorProvider1.Clear();

        }
        private void giaiPtBacNhat()
        {

        }
       

        private void txtNghiem_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapA.Text);
            float b = float.Parse(txtNhapB.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    txtNghiem.Text = "Vô số nghiệm!";
                }
                else
                {
                    txtNghiem.Text = "Vô nghiệm!";
                }
            }
            else
            {
                txtNghiem.Text = "x = " + (a / b);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtNhapA_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(txtNhapA.Text, @"[0-9.]").Success)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNhapA, "Only float type!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNhapA, null);
                if (!String.IsNullOrEmpty(txtNhapB.Text))
                {
                    btnGiai.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    Form2_Load(sender, e);
                }
            }
        }

        private void txtNhapB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(txtNhapB.Text, @"[0-9.]").Success)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNhapB, "Only float type!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNhapB, null);
                if (!String.IsNullOrEmpty(txtNhapB.Text))
                {
                    btnGiai.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    Form2_Load(sender, e);
                }
            }
        }
    }
}
