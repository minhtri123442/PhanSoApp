using PhanSoApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PhanSoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhanSo ps1 = new PhanSo(1, 2);  // 1/2
            //PhanSo ps2 = new PhanSo(1, 3);  // 1/3

            //Console.WriteLine($"ps1 = {ps1}");
            //Console.WriteLine($"ps2 = {ps2}");
            //Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");  // Ket qua: 5/6
            //Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");  // Ket qua: 1/6
            //Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");  // Ket qua: 1/6
            //Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");  // Ket qua: 3/2



            //yeu cau nang cao
            //PhanSo ps1 = new PhanSo(1, 2); // 1/2
            //int n = 2;

            //PhanSo ketQua1 = ps1 + n; // Kết quả: 5/2
            //PhanSo ketQua2 = n + ps1; // Kết quả: 5/2

            //Console.WriteLine($"{ps1} + {n} = {ketQua1}");
            //Console.WriteLine($"{n} + {ps1} = {ketQua2}");


            //bai tap 3
            PhanSo ps1 = new PhanSo(1, 2);  // 1/2
            PhanSo ps2 = new PhanSo(2, 4);  // 2/4 (= 1/2 sau khi rut gon)
            PhanSo ps3 = new PhanSo(1, 3);  // 1/3

            Console.WriteLine(ps1 == ps2);  // True  (1/2 == 2/4)
            Console.WriteLine(ps1 != ps3);  // True  (1/2 != 1/3)
            Console.WriteLine(ps3 < ps1);   // True  (1/3 < 1/2)
            Console.WriteLine(ps1 > ps3);


        }
    }
}