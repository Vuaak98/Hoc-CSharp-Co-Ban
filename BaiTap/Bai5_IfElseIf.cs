using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai5_IfElseIf
    {
        public static void Run()
        {
            Console.WriteLine("Vui lòng nhập điểm trung bình của bạn: ");
            float diemTB = float.Parse(Console.ReadLine()!);

            if (diemTB >= 8.0f)
            {
                Console.WriteLine("Xếp loại: Giỏi");
            }
            else if (diemTB >= 6.5f)
            {
                Console.WriteLine("Xếp loại: Khá");
            }
            else if (diemTB >= 5.0f)
            {
                Console.WriteLine("Xếp loại: Trung bình");
            }
            else {
                Console.WriteLine("Xếp loại: Yếu");
            }
        }
     }
}
