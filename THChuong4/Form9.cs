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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtNhap.Text);
            txtNhap.Clear();
            txtNhap.Select();
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(this, new EventArgs());
            }
        }

 

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == true) //Hàm chọn item trong listbox
                    listBox1.Items.RemoveAt(i);
               
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.GetSelected(i) == true)
                    listBox2.Items.RemoveAt(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }

        private void btnOneB2A_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                while (listBox2.SelectedItems.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }

        private void btnAllA2B_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            listBox1.BeginUpdate();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
                if (listBox1.GetSelected(i) == true)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            listBox1.EndUpdate();
        }

        private void btnAllB2A_Click(object sender, EventArgs e)
        {
            listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            listBox2.BeginUpdate();

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);
                if (listBox2.GetSelected(i) == true)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            listBox2.EndUpdate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
