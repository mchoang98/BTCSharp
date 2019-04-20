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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string sRadio = "";
        private string itemIsChecked = "";
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string ten = txtName.Text;
            string year = cbLop.Text;

            if (hk1radio.Checked == true)
            {
                sRadio = "Học kỳ 1";
            }
            if (hk2radio.Checked == true)
            {
                sRadio = "Học kỳ 2";
            }
            if (hk3radio.Checked == true)
            {
                sRadio = "Học kỳ 3";
            }
            if (hk4radio.Checked == true)
            {
                sRadio = "Học kỳ 4";
            }
            //lấy item từ checked listbox
            int dem = 0;
            foreach(object itemChecked in checkedListBox1.CheckedItems)
            {
                dem++;
                itemIsChecked += "\n"+dem+". "+ itemChecked.ToString();
            }
            MessageBox.Show("Mã SV: " + masv + "\nTên SV: " + ten + "\nĐã đăng ký học: " + sRadio + " Các môn học sau: " + itemIsChecked);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaSV.Select();
            txtName.Clear();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
