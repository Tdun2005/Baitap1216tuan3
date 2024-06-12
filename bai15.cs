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

            // Khai báo mảng 1 chiều các số thực 4 byte và cấp phát cho a gồm n phần tử
            float[] a = new float[n];

            // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
            NhapMangSoThuc(a, n);

            // In ra màn hình giá trị được nhập của mảng a
            Console.WriteLine("Các phần tử của mảng là:");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
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

        // Hàm static để nhập vào một mảng số thực 4 byte với số phần tử n cho trước
        static void NhapMangSoThuc(float[] a, byte n)
        {
            for (byte i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                a[i] = NhapSoThuc4Byte();
            }
        }
    }
}
