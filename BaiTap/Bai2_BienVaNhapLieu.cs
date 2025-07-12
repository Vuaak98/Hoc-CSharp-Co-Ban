using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai2_BienVaNhapLieu
    {
        public static void Run()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Yêu cầu người dùng nhập trên
            Console.Write("Vui lòng nhập tên của bạn: ");
            string ten = Console.ReadLine()!;

            //Yêu cầu người dùng nhập tuổi của bạn
            Console.Write("Vui lòng nhập tuổi của bạn: ");
            int tuoi = int.Parse(Console.ReadLine()!);

            // In ra kết quả
            Console.WriteLine("\n --- Kết quả ---");
            Console.WriteLine("Chào bạn " + ten + ", bạn " + tuoi + " tuổi");

        } 
    }
}
