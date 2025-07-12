using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap6
    {
        public static void bt6Run()
        {
            int x;
            do
            {
                Console.WriteLine("Nhập vào một số nguyên dương: ");
                x = int.Parse(Console.ReadLine()!);
                if (x <= 0) { Console.WriteLine("Số bạn nhập vào không phải số nguyên dương!"); }

            } while (x <= 0);
            { Console.WriteLine("Bạn nhập đã chính xác!");
            }
        } 
    }
}
