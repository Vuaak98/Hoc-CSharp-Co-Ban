using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai7_BaiTapTongHopBMI
    {
        public static void Run()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("CHƯƠNG TRÌNH TÍNH CHỈ SỐ BMI");

            Console.Write("Nhập cân nặng của bạn (kg): ");
            float canNang = float.Parse(Console.ReadLine()!);

            Console.Write("Nhập chiều cao của bạn (m): ");
            float chieuCao = float.Parse(Console.ReadLine()!);

            //Tính BMI
            float bmi =  canNang / (float) Math.Pow(chieuCao, 2);

            // in ra kết quả BMI làm tròn đến 2 chữ số thập phân
Console.WriteLine($"Chỉ số BMI của bạn là: {Math.Round(bmi, 2)}");

            // Phân loại

            if (bmi < 18.5f)
            {
                Console.WriteLine("Gầy");

            }
            else if (bmi < 23f)
            {
                Console.WriteLine("Bình thường");
            }
            else if (bmi < 25f)
            {
                  Console.WriteLine("Thừa cân");
            }
            else
            {
                Console.WriteLine("Béo phì");
            }
        }
    }
}
