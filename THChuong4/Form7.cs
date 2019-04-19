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
        }
                
        private void comboDaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            listUoc.Items.Clear();
            
            int InputedValue = int.Parse((comboDaNhap.SelectedItem.ToString())); //chuyển string ở trên thành integer
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
            decimal sum = 0;
            for(int i =1; i<=listUoc.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listUoc.Items[i]);
            }
            MessageBox.Show("Tong = "+sum);
        }

        private void btnDemChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 1; i <=listUoc.Items.Count; i++)
            {
                if(i%2==0)
                dem++;
            }
            MessageBox.Show("So luong " + dem);

        }

        private void btnDemNgto_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= listUoc.Items.Count; i++)
            {
                
            }
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
