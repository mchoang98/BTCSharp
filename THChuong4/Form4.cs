using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THChuong4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioRedCheck(object sender, EventArgs e)
        {
            // lblTen.BackColor = ;
            lblTen.ForeColor = Color.Red;
            lblNull.ForeColor = Color.Red;
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblNull.Text = txtNhapten.Text;
        }

        private void radioGreenCheck(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Green;
            lblNull.ForeColor = Color.Green;
        }

        private void radioBlueCheck(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Blue;
            lblNull.ForeColor = Color.Blue;
        }

        private void radioBlackCheck(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Black;
            lblNull.ForeColor = Color.Black;
        }

        private void BoldChecked(object sender, EventArgs e)
        {
            if (checkBold.Checked == true)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Bold);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Bold);

            }
            if (checkBold.Checked == false)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Regular);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Regular);

            }

        }

        private void italicCheck(object sender, EventArgs e)
        {
            if(checkItalic.Checked==true)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Italic);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Italic);

            }
            if (checkItalic.Checked == false)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Regular);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Regular);

            }

        }

        private void UnderChecked(object sender, EventArgs e)
        {
            if (checkUnder.Checked == true)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Underline);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Underline);

            }
            if (checkUnder.Checked == false)
            {
                lblTen.Font = new Font(lblTen.Font, FontStyle.Regular);
                lblNull.Font = new Font(lblNull.Font, FontStyle.Regular);

            }
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
