using BaiTap1.BaiTap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap3
    {
        public static void Run()
        {
            // a) Giải pt bậc nhất
            Console.WriteLine("\n--- Giải phương trình bậc 1 ---");
            Console.Write("Nhập hệ số b: ");
            float b = float.Parse(Console.ReadLine()!);
            Console.Write("Nhập hệ số c: ");
            float c = float.Parse(Console.ReadLine()!);

            if (b == 0) 
            {
                if (c != 0) { Console.WriteLine("Phương trinh vô"); }
                else { Console.WriteLine("Phương trình có vô số nghiệm"); }
            }
            else { Console.WriteLine($"Phương trình có nghiệm x ={-c/b}"); }

        }
        public static void Run1()
        {
            // b) Giải phương trình bậc hai
            Console.WriteLine("\n--- Giải phương trình bậc 2 ---");
            Console.Write("Nhập hệ số a: ");
            float a = float.Parse(Console.ReadLine()!);

            if (a == 0) 
            { 
                Console.WriteLine("Hệ số a=0, Phương trình trở thành pt bậc 1");
                Run();
            }
            else
            {
                Console.Write("Nhập hệ số b: ");
                float b = float.Parse(Console.ReadLine()!);
                Console.Write("Nhập hệ số c: ");
                float c = float.Parse(Console.ReadLine()!);
                float denta = b * b - 4 * a * c;
                if (denta < 0) { Console.WriteLine("Phương trình vô nghiệm"); }
                else if (denta == 0) { Console.WriteLine($"Phương trình có nghiệm kép x1=x2= {-b / (2 * a)}"); }
                else { Console.WriteLine($"Phương trình bậc 2 có 2 nghiệm phân biệt x1 ={(-b+Math.Sqrt(denta)/(2*a))} và x2 ={(-b - Math.Sqrt(denta) / (2 * a))}"); }
            }


        }
    } 
}
