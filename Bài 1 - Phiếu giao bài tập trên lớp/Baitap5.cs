using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap5
    {
        public static void bt5Run()
        {
            Console.WriteLine("Nhập số nguyên (1,7) là: ");
            int x = int.Parse(Console.ReadLine()!);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ 2");
                    break;
                case 3:
                    Console.WriteLine("Thứ 3");
                    break;
                case 4:
                    Console.WriteLine("Thứ 4");
                    break;
                case 5:
                    Console.WriteLine("Thứ 5");
                    break;
                case 6:
                    Console.WriteLine("Thứ 6");
                    break;
                case 7:
                    Console.WriteLine("Thứ 7");
                    break;
                default:
                    Console.WriteLine("Bạn nhập giá trị không hợp lệ!");
                    break;
            }
        }
    }
}
