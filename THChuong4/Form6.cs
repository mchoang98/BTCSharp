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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void radioVietnam_CheckedChanged(object sender, EventArgs e)
        {
            picturebox1.Image = Properties.Resources.vietnam;
        }

        private void radioUsa_CheckedChanged(object sender, EventArgs e)
        {
            picturebox1.Image = Properties.Resources.usa;
        }

        private void radioItaly_CheckedChanged(object sender, EventArgs e)
        {
            picturebox1.Image = Properties.Resources.italy;
        }

        private void radioPhilip_CheckedChanged(object sender, EventArgs e)
        {
            picturebox1.Image = Properties.Resources.philip;

        }
    }
}
