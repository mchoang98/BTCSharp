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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void onChangeColor(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
            redValue.Text = RedBar.Value.ToString();
            greenValue.Text =   GreenBar.Value.ToString();
            blueValue.Text =  BlueBar.Value.ToString();
        }
    }
}
