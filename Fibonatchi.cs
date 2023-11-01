using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonatchi
{
    internal class Program
    {
        static void Main(string[] args)
        {//علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی
            double x =1;
            double y =0;
            Console.WriteLine("n = ");
            double n = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i < n; i++)
            {
                x = x + y;
                Console.Write(x);
                Console.Write(" ");
                y = x + y;
                Console.Write(y);
                Console.Write(" ");
            }
                Console.ReadKey();
            }
        }

    }
    

