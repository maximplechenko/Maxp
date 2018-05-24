using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int abcSum = a+b+c;

            Console.WriteLine(abcSum);
            */

            //2
            /*
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"perimeter is = {perimeter}");
            Console.WriteLine($"area is = {area}");
            */

            //4
            int a = 10;//int.Parse(Console.ReadLine());
            double b = -2;//int.Parse(Console.ReadLine());
            double c = 3;//int.Parse(Console.ReadLine());

            Console.WriteLine("{0,3:X}{1,10:#}{2,10}",a,b,c);
        }
    }
}
