using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division3x5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~100不被3整除，也不被5整除的數字有:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //Console.WriteLine($"{i}");
                }
                else { Console.WriteLine(i); }
            }
            Console.ReadLine();

        }
    }
}
