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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Form5 = new Form5();
            Form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Form6 = new Form6();
            Form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Form7 = new Form7();
            Form7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Form8 = new Form8();
            Form8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form Form9 = new Form9();
            Form9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form Form10 = new Form10();
            Form10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form Form11 = new Form11();
            Form11.Show();
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Made by Hoàng Thiên Phú ! ĐHCN3A");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
