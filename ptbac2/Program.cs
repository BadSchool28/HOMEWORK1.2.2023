using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptbac2
{
    //Nguyễn Quang Trường
    //MaSV: 20it923
    //Lớp: 20MC
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x, x1, x2;
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2");
            Console.WriteLine("Mời nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập c: ");
            c = Convert.ToInt32(Console.ReadLine());
            float delta = b * b - 4*(a * c);
            if(a==0)
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm!");

                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }else
                {
                    x = (float)-c / b;
                    Console.WriteLine("Phương trình có nghiệm x= {0} ", x);
                } 
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
                else if (delta == 0)
                {
                    x = (double)((-b) / (2 * a));
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}",x);
                }
                else    
                {
                    x1 = (double)(-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm riêng biệt: \n" +
                        "x1= {0}\n" +
                        "x2= {1}",x1,x2);
                }
                
            }
            Console.ReadKey();
        }
    }
}
