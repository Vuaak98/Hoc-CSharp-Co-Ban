using System.Text;

namespace BaiTap1.BaiTap
{
    public static class Bai8_BaiTapTongHopPTBH
    {
        public static void Run()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC HAI (ax² + bx + c = 0) ---");

            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Nhập số c: ");
            double c = double.Parse(Console.ReadLine()!);

            // Tính delta
            double delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"\nDelta = {delta}");

            // Biện luận nghiệm
            if (delta < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kết luận: Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Kết luận: Phương trình có nghiệm kép x = {x}");
            }
            else // delta > 0
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Kết luận: Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }

            // Trả màu về mặc định
            Console.ResetColor();
        }
    }
}