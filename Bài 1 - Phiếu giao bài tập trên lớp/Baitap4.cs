using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap4
    {
        public static void bt4Run()
        {
            Console.WriteLine("Nhập Bậc lương: ");
            float BacLuong = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhập Ngày công: ");
            float NgayCong = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhập Phụ cấp: ");
            float PhuCap = float.Parse(Console.ReadLine()!);

            float NCTL;
            if (NgayCong < 25)
            {
                NCTL = NgayCong;
            }
            else
            {
                NCTL=25 +(NgayCong-25)*2;
            }

            float TienLinh = BacLuong * 1490000 * NCTL + PhuCap;
            Console.WriteLine($"Tiền thực lĩnh là: {TienLinh}");


        }
    }
}
