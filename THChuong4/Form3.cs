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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            txtKetqua.Text = "" + (a * b);
        }

        private void txtNum1_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(txtNum1.Text, @"[0-9.]").Success)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNum1, "Only float type!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNum1, null);
            }
        }

        private void txtNum2_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(txtNum2.Text, @"[0-9.]").Success)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNum2, "Only float type!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNum2, null);
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            //    this.errorProvider1.SetError(txtNum1, "This is not invalid number");
            //else this.errorProvider1.Clear();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            //    this.errorProvider1.SetError(txtNum2, "This is not invalid number");
            //else this.errorProvider1.Clear();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            txtKetqua.Text =""+(a + b);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            txtKetqua.Text = "" + (a - b);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            txtKetqua.Text = "" + ((float)a / b);
        }
    }
}
