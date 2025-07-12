using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap7
    {
        public static void bt7Run()
        {
            Console.Write("Nhập vào một số nguyên n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2) { Console.WriteLine($"{n} không phải là một số nguyên tố.");}
            else if (n == 2) { Console.WriteLine($"{n} là một số nguyên tố."); }
            else
            {
                if (n % 2 == 0) { Console.WriteLine($"{n} không phải là một số nguyên tố."); }
                else { Console.WriteLine($"{n} là một số nguyên tố."); }
            }

        }
    }
}
