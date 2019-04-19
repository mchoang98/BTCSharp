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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTimesFont.Checked == true)
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font("Times New Roman", txtText.Font.Size, FontStyle.Regular);
            }
            else
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font(txtText.Font.FontFamily, txtText.Font.Size, FontStyle.Regular);
            }

        }

        private void radioArialFont_CheckedChanged(object sender, EventArgs e)
        {
            if (radioArialFont.Checked == true)
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font("Arial", txtText.Font.Size, FontStyle.Regular);
            }
            else
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font(txtText.Font.FontFamily, txtText.Font.Size, FontStyle.Regular);
            }
        }

        private void radioTahomaFont_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTahomaFont.Checked == true)
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font("Tahoma", txtText.Font.Size, FontStyle.Regular);
            }
            else
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font(txtText.Font.FontFamily, txtText.Font.Size, FontStyle.Regular);
            }
        }

        private void radioCourierFont_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCourierFont.Checked == true)
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font("Courier New", txtText.Font.Size, FontStyle.Regular);
            }
            else
            {
                txtText.SelectAll();
                txtText.SelectionFont = new Font(txtText.Font.FontFamily, txtText.Font.Size, FontStyle.Regular);
            }
        }
    }
}
