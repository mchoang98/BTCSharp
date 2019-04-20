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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void listUoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            comboDaNhap.Items.Add(txtNhap.Text);
            comboDaNhap.Text = txtNhap.Text;
            txtNhap.Clear();
            txtNhap.Select(); //Hiện con trỏ ngay tại ô nhập
        }
        private int InputedValue;
        private void comboDaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            listUoc.Items.Clear();
            do
            {
                try
                {
                    InputedValue = int.Parse((comboDaNhap.SelectedItem.ToString())); //chuyển string ở trên thành integer
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } while (false);
           
            for (int number = 1; number < InputedValue; number++)
            {
                if (InputedValue % number == 0)
                    //number la uoc cua InputedValue
                    //show number lên listbox;
                    listUoc.Items.Add(number);
            }

            //Để nội dung không bị đè lên nhau
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            Decimal sum = 0;
            for (int i = 0; i < listUoc.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listUoc.Items[i]);
            }
            MessageBox.Show("Tong = " + sum);
        }

        private void btnDemChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 1; i <= listUoc.Items.Count; i++)
            {
                if (i % 2 == 0)
                    dem++;
            }
            MessageBox.Show("So luong " + dem);

        }

        bool laSoNguyenTo1(int n)
        {
            // Neu n < 2 thi khong phai la SNT
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < (n - 1); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnDemNgto_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < listUoc.Items.Count; i++)
            {
                try
                {
                    if (laSoNguyenTo1(Convert.ToInt32(listUoc.Items[i].ToString())))
                    {
                        dem++;
                    }
                }
                catch (Exception ex)
                {

                }

            }
            MessageBox.Show("So luong nguyen to: " + dem);
        }
        // sự kiện nhấn Enter
        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapnhat_Click(this, new EventArgs());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text,
 ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtNhap, "This is not invalid             number");
 else

                this.errorProvider1.Clear();
        }

        //int UocSo(int N)
        //{
        //    int []cacUoc= new int[100];
        //    for (int i = 0; i < N; i++)
        //    {   
        //        if (N % i == 0)
        //            cacUoc[i] = i+1;
        //    }

        //    return dem;
        //}
    }
}
