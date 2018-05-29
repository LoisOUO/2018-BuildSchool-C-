using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("請輸入西元年份:");
            Console.WriteLine("請輸入中華民國年份:");
            string Tyears = Console.ReadLine();
            int years = int.Parse(Tyears)+1911;
            if (years %4==0 && years %100!=0    ) 
            {
                Console.WriteLine("輸入的是閏年");
            }
            if (years % 100 != 0 && years % 400 == 0)
            {
                Console.WriteLine("輸入的是閏年");
            }
            else
            {
                Console.WriteLine("輸入的不是閏年");
            }

        }
    }
}
