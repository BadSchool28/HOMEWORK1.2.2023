using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplemath
{
    //Nguyễn Quang Trường
    //MaSV: 20it923
    //Lớp: 20MC
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            double a, b, ketqua;
            int pheptinh;
            Console.WriteLine("CHƯƠNG TRÌNH GIẢI TOÁN CƠ BẢN" +
                "");
            Console.WriteLine("Mời nhập a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("1. Cộng");
            Console.WriteLine("2. Trừ");
            Console.WriteLine("3. Nhân");
            Console.WriteLine("4. Chia");
            Console.WriteLine("Nhập phép tính: ");
            pheptinh = Convert.ToInt32(Console.ReadLine());
            switch (pheptinh)
            {
                case 1:
                    ketqua = (double)a + b;
                    Console.Write("Kết quả: {0} + {1} = {2} ", a,b,ketqua);
                    break;

                case 2:
                    ketqua = (double)a - b;
                    Console.Write("Kết quả: {0} - {1} = {2} ", a, b, ketqua);
                    break;
                case 3:
                    ketqua = (double)a * b;
                    Console.Write("Kết quả: {0} * {1} = {2} ", a, b, ketqua);
                    break;
                case 4:
                    ketqua = (double)a / b;
                    Console.Write("Kết quả: {0} / {1} = {2} ", a, b, ketqua);
                    break;
                default:
                    Console.Write("Bạn đã nhập số không hợp lệ!\n");
                    break;
            }

            Console.ReadKey();
        }
    }
}

