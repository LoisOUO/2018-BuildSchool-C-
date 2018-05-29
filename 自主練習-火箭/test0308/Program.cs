using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0308
{
    class Program
    {
        static void Main(string[] args)
        { //第一部分
            Console.WriteLine();
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" "); // Console.Write("_");

                }
                for (int j = i*2-1; j <10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //第二
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("   *****"); //Console.WriteLine("___*****");
            }
            //第三
            for (int i = 3; i < 6; i++)
            {
                for (int j = i; j <5; j++)
                {
                    Console.Write(" "); //Console.Write("_");
                }
                for (int j = 2 * i + 1; j >0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //第四
            for (int i = 2; i < 5; i++)
            {
                for (int j = i; j<5 ;j++)
                {
                    Console.Write("*");
                }
                for (int j = 2 * i + 1; j >0; j--)
                {
                    Console.Write(" "); // Console.Write("_");
                }
                for (int j = i; j <5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("   * * *   "); //Console.WriteLine("___*_*_*___");
            }
            Console.ReadLine();
            
        }
    }
}
