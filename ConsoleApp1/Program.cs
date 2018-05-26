using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//4.1
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            else if (a < b)
            {
                Console.WriteLine("a<b");
            }
            else
            {
                Console.WriteLine("a=b");
            }
            //Console.ReadLine();
            */

            //4.3
            byte number = 30;

            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Odd");
                    break;

            }

            Console.ReadLine();


        }
    }
}
