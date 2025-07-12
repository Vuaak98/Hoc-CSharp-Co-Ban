using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai6_SwitchCase
    {
        public static void Run()
        {
            Console.WriteLine("---Menu đồ uống---");
            Console.WriteLine("1. Cà phê");
            Console.WriteLine("2. Trà sữa");
            Console.WriteLine("3. Nước ép");
            Console.WriteLine("Mời bạn nhập lựa chọn (1-3): ");

            int luaChon = int.Parse(Console.ReadLine()!);

            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("Bạn đã chọn Cà phê.");
                    break;
                case 2:
                    Console.WriteLine("Bạn đã chọn Trà sữa.");
                    break;
                case 3:
                    Console.WriteLine("Bạn đã chọn Nước ép.");
                    break;
                default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
            }
        }   
    }
}
