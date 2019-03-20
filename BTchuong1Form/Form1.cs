using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTchuong1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btchuong1 btc1 = new Btchuong1();
            btc1.displayName();
            TextBox textbox = new TextBox();
            textbox.Show(btc1.displayName())
         }
    }
}
