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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    var value = int.Parse(txtNhap.Text);
                    listBox1.Items.Add(value);
                    txtNhap.Clear();
                    txtNhap.Select();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
            } while (false);
           
            //listBox1.Items.Add(value);
            //txtNhap.Clear();
            //txtNhap.Select();
        }

        private void btnTongList_Click(object sender, EventArgs e)
        {
            Decimal sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listBox1.Items[i]);
            }
            MessageBox.Show("Tong = " + sum);
        }

        private void btnThayBphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = Convert.ToInt32(listBox1.Items[i].ToString()); //chuyển đổi items trong list box thành kiểu int
                x = x *x; //bình phương
                listBox1.Items[i] = x;  //thay thế item trong list box thành giá trị mới
            }
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            for(int i=0; i<listBox1.Items.Count;i++)
            {
                if ( (i==0) || i==listBox1.Items.Count-1)
                listBox1.Items.RemoveAt(i);
                
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {

             listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == true) //Hàm chọn item trong listbox
                    listBox1.Items.RemoveAt(i);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for(int i=0; i<listBox1.Items.Count;i++)
            {
               int x= Convert.ToInt32(listBox1.Items[i].ToString()) ; //chuyển đổi items trong list box thành kiểu int
                x = x + 2; //tăng 2 đơn vị
                listBox1.Items[i] = x;  //thay thế item trong list box thành giá trị mới
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {

            listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               
                int x = Convert.ToInt32(listBox1.Items[i].ToString()); //chuyển đổi items trong list box thành kiểu int
                if (x % 2 == 0)
                {
                    listBox1.SetSelected(i, true);
                }
              
            }

        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                int x = Convert.ToInt32(listBox1.Items[i].ToString()); //chuyển đổi items trong list box thành kiểu int
                if (x % 2 != 0)
                {
                    listBox1.SetSelected(i, true);
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
