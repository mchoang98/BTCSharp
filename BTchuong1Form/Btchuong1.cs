using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTchuong1Form
{
    class Btchuong1
    {
         public void displayName()
        {
            string name;
            Console.Write("Nhap ten cua ban: ");
            name = Console.ReadLine();
            Console.Write("ho ten: {0}", name);
            Console.ReadLine();
        }
        //Tong hieu tich thuong
         public void MathProject()
        {
            Console.Write("Input 1st Number: ");
            int nNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd Number: ");
            int nNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong la: {0}", nNumber1 + nNumber2);
            Console.WriteLine("The number {0} - {1} = {2} ", nNumber1, nNumber2, nNumber1 - nNumber2);
            Console.WriteLine("The {0} * {1} = {2}", nNumber1, nNumber2, nNumber1 * nNumber2);
            Console.WriteLine("The {0} / {1} = {2}", nNumber1, nNumber2, (float)nNumber1 / nNumber2);
            Console.ReadLine();

        }
        //Quy may  trong nam
         public void quarterOfYear()
        {
            Console.WriteLine("=======================Bai toan nhap thang tim quy trong nam==============================================");
            int nMonth = 0;
            while (nMonth < 1 || nMonth > 12)
            {

                try
                {
                    Console.Write("Input number of month");
                    nMonth = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter Integer Number!");
                }
                switch (nMonth)
                {
                    case 1:
                    case 2:
                    case 3: Console.WriteLine("Thang {0} thuoc quy 1", nMonth); break;
                    case 4:
                    case 5:
                    case 6: Console.WriteLine("Thang {0} thuoc quy 2", nMonth); break;
                    case 7:
                    case 8:
                    case 9: Console.WriteLine("Thang {0} thuoc quy 3", nMonth); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("Thang {0} thuoc quy 4", nMonth); break;



                }
            }
            Console.ReadLine();

        }
        //Nhap diem thi sinh, phan loai hoc tap
         public void StudyResult()
        {
            Console.WriteLine("=======================Bai toan nhap phan loai hoc tap =====================================");
            float fScore = -1;
            while (fScore < 0 || fScore > 10)
            {
                Console.WriteLine("The Score Require >=0 and <=10 ");
                Console.Write("Input the scored: ");
                try
                {
                    fScore = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter the Correct Format of Score");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Score is too Large please try again");
                }
            }
            if (fScore < 5)
            {
                Console.WriteLine("Hoc sinh yeu");
            }
            else if (fScore > 8)
            {
                Console.WriteLine("Hoc sinh gioi");
            }
            else if (fScore > 6.5)
            {
                Console.WriteLine("Hoc sinh kha");
            }
            else
            {
                Console.WriteLine("Hoc sinh trung binh");
            }
            Console.ReadLine();
        }
        // Tinh tong binh phuong 1+2+..+n
         public void SumQuare()
        {
            Console.WriteLine("Input Destination Value: ");
            uint unDesValue = 0;
            do
            {
                try
                {
                    unDesValue = Convert.ToUInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui long nhap dung dinh dang so nguyen duong");
                }

            } while (unDesValue < 1);

            uint unSum = 0;
            for (uint i = 1; i <= unDesValue; i++)
            {
                unSum += i * i;
            }
            Console.WriteLine("Final Total 1+2+...+{0} = {1}", unDesValue, unSum);
            Console.ReadLine();
        }
        // Tinh tong phan so 
         public void SumPS()
        {
            Console.WriteLine("Input the n value (2n+1)/(2n+2) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            double sum = 0.0;
            for (int i = 0; i <= n; i++)
            {
                a += 2 * i + 1;
                b += 2 * i + 2;
                sum += (float)a / b;
            }

            Console.WriteLine("KEt qua la: {0}", sum);
            Console.ReadLine();
        }
        //Tin tong 1.1+1.2+1.2.3+..+1.2.3...n
         public void sumN()
        {
            int n = 0;
            Console.WriteLine("Tin tong 1.1+1.2+1.2.3+..+1.2.3...n");
            int p = 1;

            do
            {
                try
                {

                    Console.WriteLine("Input destination value N: ");

                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sai dinh dang, moi nhap lai:   ");
                }
            }
            while (n < 0);
            int i = 1;
            double sum = 0;

            while (i <= n)
            {
                p = p * i;
                sum += p;
                i++;
            }

            Console.WriteLine("REsult is {0}", sum);
            Console.ReadLine();


        }
        //tinh tong 1+ 1/(1+2)+ 1/(1+2+3)+ ... + 1/(1+2+3+...+n);
         int tinhtong(int n)
        {
            if (n < 1)
                return 0;
            else return n + tinhtong(n - 1);
        }


         public void tinhtongPS()
        {
            int n;

            do
            {
                Console.Clear();
                Console.WriteLine("Nhap vao phan tu N: ");
                n = Int32.Parse(Console.ReadLine());
            } while (n < 1);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (tinhtong(i));
            }
            Console.WriteLine("KEt qua phep tinh: {0} ", sum);
            Console.ReadLine();
        }
        // Viet ct nhap so nguyen n  in tong cac so(n>1000)
         public void tongcacso()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen lon hon 1000: ");
                n = Int32.Parse(Console.ReadLine());
            }
            while (n < 1000);
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n = n / 10;
            }

            Console.WriteLine("Tong cac so :{0}", tong);
            Console.ReadKey();


        }
    }
}
