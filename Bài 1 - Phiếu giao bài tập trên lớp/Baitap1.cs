using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap1
    {
        public static void Run()
        {
            Console.Write("Nhập vào một số nguyên n = ");
            int n = int.Parse(Console.ReadLine()!);

            // a) n là số chẵn hay số lẻ
            if (n % 2 == 0)

            {
                Console.WriteLine($"{n} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ");
            }

            // b) n là số âm hay số không âm

            if (n < 0) { Console.WriteLine($"{n} là số âm"); }
            else { Console.WriteLine($"{n} là số không âm"); }
        }
    }   

}
