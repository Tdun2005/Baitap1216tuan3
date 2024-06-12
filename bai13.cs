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

            // Khai báo số nguyên 1 byte không dấu
            byte n;

            // Gọi hàm để nhập giá trị của n
            n = NhapSoNguyen1Byte();

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị nhập vào là: {n}");
        }

        // Hàm static để đọc số nguyên 1 byte không dấu nằm trong khoảng 2 đến 10
        static byte NhapSoNguyen1Byte()
        {
            byte result;
            while (true)
            {
                Console.Write("Nhập một số nguyên không dấu (1 byte) trong khoảng từ 2 đến 10: ");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out result) && result >= 2 && result <= 10)
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
