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
            byte m, n;

            // Gọi hàm để nhập giá trị của m và n
            m = NhapSoNguyen1Byte("m");
            n = NhapSoNguyen1Byte("n");

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị m nhập vào là: {m}");
            Console.WriteLine($"Giá trị n nhập vào là: {n}");

            // Khai báo mảng 2 chiều các số nguyên 4 byte và cấp phát cho a gồm m*n phần tử
            int[,] a = new int[m, n];

            // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
            NhapMangSoNguyen(a, m, n);

            // In ra màn hình giá trị được nhập của mảng a
            Console.WriteLine("Các phần tử của mảng là:");
            InMang2Chieu(a, m, n);

            // Gọi hàm để tính tổng các phần tử của mảng chia hết cho 2024
            int tongChiaHetCho2024 = TinhTongChiaHet(a, m, n, 2024);

            // In ra màn hình giá trị tính được
            Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {tongChiaHetCho2024}");
        }

        // Hàm static để đọc số nguyên 1 byte không dấu nằm trong khoảng 2 đến 10
        static byte NhapSoNguyen1Byte(string tenBien)
        {
            byte result;
            while (true)
            {
                Console.Write($"Nhập một số nguyên không dấu (1 byte) cho {tenBien} trong khoảng từ 2 đến 10: ");
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

        // Hàm static để đọc số nguyên 4 byte từ bàn phím
        static int NhapSoNguyen4Byte()
        {
            int result;
            while (true)
            {
                Console.Write("Nhập một số nguyên 4 byte: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
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

        // Hàm static để nhập vào một mảng 2 chiều các số nguyên 4 byte với số phần tử m và n cho trước
        static void NhapMangSoNguyen(int[,] a, byte m, byte n)
        {
            for (byte i = 0; i < m; i++)
            {
                for (byte j = 0; j < n; j++)
                {
                    Console.Write($"Nhập phần tử thứ [{i + 1}, {j + 1}]: ");
                    a[i, j] = NhapSoNguyen4Byte();
                }
            }
        }

        // Hàm static để in ra các phần tử của mảng 2 chiều
        static void InMang2Chieu(int[,] a, byte m, byte n)
        {
            for (byte i = 0; i < m; i++)
            {
                for (byte j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Hàm static để tính tổng các phần tử chia hết cho số nguyên dương p của mảng
        static int TinhTongChiaHet(int[,] a, byte m, byte n, int p)
        {
            int sum = 0;
            for (byte i = 0; i < m; i++)
            {
                for (byte j = 0; j < n; j++)
                {
                    if (a[i, j] % p == 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
