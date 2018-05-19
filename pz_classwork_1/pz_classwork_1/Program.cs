using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_classwork_1
{
    class Program
    {
        static void Main()
        {
            int i = 10000000;
            byte b = 8;

            double d = 12.12121212;
            float f = 3.14f;

            char c = 'c';
            string s = "string";

            Console.WriteLine($"int={i}");
            Console.WriteLine($"byte={b}");
            Console.WriteLine($"double={d}");
            Console.WriteLine($"float={f}");
            Console.WriteLine($"char={c}");
            Console.WriteLine($"string={s}");

            Console.WriteLine($"{nameof(i)}={i}");


            string fio;
            fio = Console.ReadLine();
            Console.WriteLine(fio);
            //h


        }
    }
}
