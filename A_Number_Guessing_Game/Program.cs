using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Number_Guessing_Game
{
    //Nguyễn Quang Trường
    //MaSV: 20it923
    //Lớp: 20MC
    internal class Program
    {
        static void Main(string[] args)
        {
            int dead = 0;
            int nb;
            Random rd= new Random();
            int luckynumber = rd.Next(1,100);
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("luckynumber: {0} ",luckynumber);
            //Console.WriteLine("Mời bạn nhập số: ");
            nb = Convert.ToInt32(Console.ReadLine());
            
            if (nb < 1 || nb > 100)
            {
                Console.WriteLine("Nhập lại n (1<n100)");
            }
            else if (nb != luckynumber) 
            {
                for (int i = 7; i >= dead ; i--)
                {
                    Console.WriteLine("Mời bạn nhập số: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n==luckynumber)
                    {
                        Console.WriteLine($"Bạn đã đoán đúng luckynumber {luckynumber}");
                        break;
                    }
                    else if (n < luckynumber)
                    {
                        Console.WriteLine($"Bạn đã đoán sai, số {n} nhỏ hơn luckynumber, bạn còn {i} mạng!");
                    }
                    else 
                    {
                        Console.WriteLine($"Bạn đã đoán sai, số {n} lớn hơn luckynumber, bạn còn {i} mạng!");
                    }
                    
                }   

            }
            else
            {
                Console.WriteLine("Bạn thực sự đẳng cấp khi đoán trúng ngay lần đầu tiên!");
            }

            Console.ReadLine();
            

        }
    }
}
