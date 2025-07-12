using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.BaiTap
{
    public static class Bai3_PhepToanVaEpKieu
    {
        public static void Run()
        {
            int soA = 10;
            int soB = 4;

            Console.WriteLine($"--- Các phép toán cơ bản với {soA} và {soB} ---");
            Console.WriteLine($"Tổng: {soA +soB}");
            Console.WriteLine($"Hiệu: {soA - soB}");
            Console.WriteLine($"Tích: {soA * soB}");
            Console.WriteLine($"Phần dư: {soA % soB}");

            Console.WriteLine("\n---Vấn đề với phép chia số nguyên---");
            Console.WriteLine($"Thương: {soA / soB}");

            Console.WriteLine("\n--- Giải pháp: Ép kiểu ---");
            float ketQuaDung = (float)soA / soB;
            Console.WriteLine($"Kết quả sau khi ép kiểu: {ketQuaDung}");
        }
    }
}
