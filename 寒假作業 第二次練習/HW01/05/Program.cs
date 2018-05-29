using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {//閏年
            Console.Write("請輸入一個民國年分:");
            int Y = int.Parse(Console.ReadLine());
            int X = (Y + 1911);
            if (X % 4 == 0)  //可被整除
            {
                if (X % 100 == 0 && X % 400 != 0) //閏年 如果可以被100整除，需同時被400整除，否則不是閏年
                {
                    Console.WriteLine(X + "不是閏年");
                    return;
                }
                else
                {
                    Console.WriteLine(X + "為閏年");
                    return;
                }
            }
            else
            {
                Console.WriteLine(X + "不是閏年");
            }
            
        }
    }
}
