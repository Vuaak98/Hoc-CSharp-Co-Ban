using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap8
    {
        public static void bt8Run()
        {
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n = ");
                n = int.Parse(Console.ReadLine()!);
                if (n == 0) { Console.WriteLine("Nhập lại số nguyên dương n = "); }
                else
                {
                    for (int i = 1; i < n; i++)
                    {
                        if (i % 5 != 0) { Console.WriteLine(i); }

                    }
                }
            } while (n <= 0);
            //for (int i = 1; i < n; i++)
            //{
            //    if (i % 5 != 0) { Console.WriteLine(i); }
                
            //}
        }
    }
}
