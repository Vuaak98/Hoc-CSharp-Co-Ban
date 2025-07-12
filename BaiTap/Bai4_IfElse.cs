using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai4_IfElse
    {
        public static void Run()
        {
            Console.WriteLine("Vui lòng nhập một số nguyên để kiểm tra: ");
            int soKT = int.Parse(Console.ReadLine()!);

            // Dùng if-else để kiểm tra số chẵn lẻ
            if (soKT % 2 == 0) {
                Console.WriteLine($"Số {soKT} là số chẵn");
                    }
            else { Console.WriteLine($"Số {soKT} là số lẻ."); }
        }
    }
}
