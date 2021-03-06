﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thuc_Hanh_BT
{
    class Program
    {
        //Ham Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BÀI TẬP THỰC HÀNH CHƯƠNG 1");
           
            int x = 0;
            LABEL:
            try
            {
                Console.WriteLine
               ("\n1. Nhập tên hiển thị ra màn hình" +
               "\n2. Nhập a, b thực hiện cộng trừ nhân chia" +
               "\n3. Nhập tháng hiển thị quý nào trong năm" +
               "\n4. Nhập điểm hiển thị kết quả học tập" +
               "\n5. Tính 1^2+2^2+...+n^2 với n>0 Nhập từ bàn phím" +
               "\n6. S(n)= 1/2+ 3/4 + 5/6 +...+ (2n+1)/(2n+2)" +
               "\n7. S(n)= 1 + 1.2 + 1.2.3 +...+ 1.2.3....n" +
               "\n8. S(n)= 1 + 1/(1+2) + 1/(1+2+3) +...+ 1/(1+2+3+....+n)" +
               "\n9. Nhập N in ra màn hình tổng các chữ số.");
                Console.Write("\n\nNhập lựa chọn:");

                x = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sai định dạng nhập lại!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Tràn bộ nhớ ! Nhập lại!");
            }
            switch (x)
            {
                case 1: Console.Clear(); displayName(); break;
                case 2: Console.Clear(); MathProject(); break;
                case 3: Console.Clear(); quarterOfYear(); break;
                case 4: Console.Clear(); StudyResult(); break;
                case 5: Console.Clear(); SumQuare(); break;
                case 6: Console.Clear(); SumPS(); break;
                case 7: Console.Clear(); sumN(); break;
                case 8: Console.Clear(); tinhtongPS(); break;
                case 9: Console.Clear(); tongcacso(); break;

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Không hợp lệ nhập lại !");
                        goto LABEL;


                    }
            }
            //displayName();
            //MathProject();
            //quarterOfYear();
            //StudyResult();
            //SumQuare();
            //SumPS();
            //sumN();
            //tinhtongPS();
            //tongcacso();

        }
        //Nhap ten hien thi 
        static void displayName()
        {
            string name;
            Console.Write("Nhập tên của bạn: ");
            name = Console.ReadLine();
            Console.Write("Họ tên: {0}", name);
            Console.ReadLine();
        }
        //Tong hieu tich thuong
        static void MathProject()
        {   
            Console.Write("Input 1st Number: ");
            int nNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd Number: ");
            int nNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tổng là: {0}", nNumber1 + nNumber2);
            Console.WriteLine("The number {0} - {1} = {2} ", nNumber1, nNumber2, nNumber1 - nNumber2);
            Console.WriteLine("The {0} * {1} = {2}", nNumber1, nNumber2, nNumber1 * nNumber2);
            Console.WriteLine("The {0} / {1} = {2}", nNumber1, nNumber2, (float)nNumber1 / nNumber2);
            Console.ReadLine();

        }
        //Quy may  trong nam
        static void quarterOfYear()
        {
            Console.WriteLine("=======================Bài toán nhập tháng tìm quý trong năm==============================================");
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
        static void StudyResult()
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
        static void SumQuare()
        {
           
            uint unDesValue = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Tính 1^2+2^2+...+n^2 với n>0 Nhập từ bàn phím");
                Console.WriteLine("Input Destination Value: ");
                try
                {
                    unDesValue = Convert.ToUInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Tran bo nho ! Vui long nhap so nguyen duong ");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui long nhap dung dinh dang so nguyen duong");
                    Console.ReadKey();
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
        static void SumPS()
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
        static void sumN()
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
        static int tinhtong(int n)
        {
            if (n < 1)
                return 0;
            else return n + tinhtong(n - 1);
        }


        static void tinhtongPS()
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
        static void tongcacso()
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
