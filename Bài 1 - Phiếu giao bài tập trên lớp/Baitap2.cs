using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1.Bài_1___Phiếu_giao_bài_tập_trên_lớp
{
    public static class Baitap2
    {
        public static void Run()
        {
            float cD;
            float cR;
            do
            {
                Console.Write("Nhập chiều dài: ");
                cD = float.Parse(Console.ReadLine()!);
                Console.Write("Nhập chiều rộng: ");
                cR = float.Parse(Console.ReadLine()!);

                if (cD <= 0 || cR <=0) { Console.WriteLine("Chiều dài hoặc chiều rộng của HCN không hợp lệ! Vui lòng nhập lại."); }
          

            } while (cD <= 0 || cR<=0);
            Console.WriteLine($"Chiều dài và chiều rộng hợp lệ bạn đã nhập là: {cD} và {cR}");
            Console.WriteLine($"Chu vi và diện tích của hình chữ nhật đó là: {(cD + cR) * 2} và {cD * cR}");

        }
    }
}
