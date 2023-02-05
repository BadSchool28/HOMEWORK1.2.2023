using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songuyento
{
    //Nguyễn Quang Trường
    //MaSV: 20it923
    //Lớp: 20MC
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("CHƯƠNG TRÌNH KIỂM TRA SỐ NGUYÊN TỐ");
            Console.WriteLine("Nhập a ");
            a = int.Parse(Console.ReadLine());
            while (a < 2)
            {
                Console.WriteLine("Nhập lại a (a>=2): ");
                a = int.Parse(Console.ReadLine());           
            }
            
                int demUoc = 0;

                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        demUoc++;
                    }
                }
                if (demUoc == 2)
                {
                    Console.WriteLine(" số {0} là số nguyên tố",a);
                }
                else
                {
                    Console.WriteLine("{0} không phải là số nguyên tố",a);
                }

                 Console.ReadKey();
        }
    }
}
