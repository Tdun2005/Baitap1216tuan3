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

            // Khai báo số nguyên 2 byte không dấu
            ushort n;

            // Gọi hàm để nhập giá trị của n
            n = NhapSoNguyen2Byte();

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị nhập vào là: {n}");

            // Tính tổng bình phương các số từ 1 đến n
            ulong tongBinhPhuong = TinhTongBinhPhuong(n);

            // In ra console giá trị tính được
            Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {tongBinhPhuong}");
        }

        // Hàm static để đọc số nguyên 2 byte không dấu từ bàn phím
        static ushort NhapSoNguyen2Byte()
        {
            ushort result;
            while (true)
            {
                Console.Write("Nhập một số nguyên không dấu (2 byte): ");
                string input = Console.ReadLine();
                if (ushort.TryParse(input, out result))
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

        // Hàm tính tổng bình phương các số từ 1 đến n
        static ulong TinhTongBinhPhuong(ushort n)
        {
            ulong sum = 0;
            for (ushort i = 1; i <= n; i++)
            {
                sum += (ulong)i * i;
            }
            return sum;
        }
    }
}
