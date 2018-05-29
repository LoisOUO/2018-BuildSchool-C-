using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0310HW001
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int sed = 1;
            int total = 0;
            Console.WriteLine("費氏數列");
            for (int i = 0; i <= 1836311903; i++)
            {
                i = sed;
                Console.WriteLine(sed);
                total = first + sed;
                
                //Console.WriteLine(sed);
                first = sed;
                sed = total;
               // i = sed;
                //Console.WriteLine(i);
                /*
               total= first + sed;
                Console.WriteLine(total);
                //Console.WriteLine($"{first} + {sed} = {total}");
                first = sed;
                sed = total;
                i = total;*/
                // Console.WriteLine(sed+"____");

            }
            Console.ReadLine();
         }
    }
}
