using System;

namespace thucHanhChuong2
{   //Xay dung lop Nguoi , thuoc tinh ten , tuoi, 2 constructor co tham so va ko co tham so
    //Xay dung phuong thuc Xuat() de hien thi thong tin
    class nguoi
    {
        string ten;
        int tuoi;
        public nguoi()
        {
            ten = "Nguyen Van A";
            tuoi = 10;
        }
        public nguoi(string name, int age)
        {
            this.ten = name;
            this.tuoi = age;
        }
        public void xuat()
        {
            Console.WriteLine("Ho ten " + ten);
            Console.WriteLine("Tuoi " + tuoi);
        }
    }

    //Xay dung lop Phan so, co cac phuong thuc +,-,*, /  phan so (nap chong toan tu)
    class PhanSo
    {
        int tuSo;
        int mauSo;
        public PhanSo()
        {
            this.tuSo = 1;
            this.mauSo = 2;
        }
        public void nhapPhanSo()
        {   //nhap tuso 
            try
            {
                Console.WriteLine("Nhap Tu so: ");
                this.tuSo = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sai dinh dang moi nhap lai");

            }
            catch (OverflowException)
            {
                Console.WriteLine("So qua lon! Moi nhap lai!");
            }
            // Nhap mau so
                do
            {
                try
                {
                    Console.WriteLine("Nhap Mau so khac 0: ");
                    this.mauSo = Int32.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sai dinh dang moi nhap lai");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("So qua lon! Moi nhap lai!");

                }
            } while (this.mauSo <1);

        }
        public void xuatPhanSo()
        {
            Console.Write("{0}/{1}", tuSo, mauSo);

        }

        public PhanSo congPhanso(PhanSo a, PhanSo b)
        {
            PhanSo c= new PhanSo();
            c.tuSo = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            c.mauSo = a.mauSo + b.mauSo;
            return c;
        }

         
    }

    class Program
    {
        static void Main(string[] args)
        {
            nguoi a = new nguoi();
            a.xuat();
            nguoi b = new nguoi("abc", 18); // tu dong goi constructor co tham so
            b.xuat();
            Console.ReadKey();

        }
    }
}
