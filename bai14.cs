using System;
using System.Text;

namespace VietnameseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập mã hóa để hiển thị tiếng Việt trong console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Khai báo số thực 4 byte
            float x;

            // Gọi hàm để nhập giá trị của x
            x = NhapSoThuc4Byte();

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị nhập vào là: {x}");
        }

        // Hàm static để đọc số thực 4 byte từ bàn phím
        static float NhapSoThuc4Byte()
        {
            float result;
            while (true)
            {
                Console.Write("Nhập một số thực 4 byte: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
                }
            }
            return result;
        }
    }
}
