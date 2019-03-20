using System;

namespace TamPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            TamPhan();
        }
        static void TamPhan()
        {
            Console.WriteLine("Nhap so nguyen can kiem tra");
            int songuyen;
            songuyen = Int32.Parse(Console.ReadLine());
            string ketqua;
            ketqua = (songuyen % 2 == 0) ? "so chan" : "so le";
            Console.WriteLine("{0} la {1}", songuyen, ketqua);
            Console.ReadKey();
        }
    }
}
