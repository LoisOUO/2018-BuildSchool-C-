using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字:");
            string X = Console.ReadLine();
            for (int Y = 0; Y < X.Length; Y++)
            {
                if (X[Y] == '1')
                {
                    Console.Write("一");
                }
                if (X[Y] == '2')
                {
                    Console.Write("二");
                }
                if (X[Y] == '3')
                {
                    Console.Write("三");
                }
                if (X[Y] == '4')
                {
                    Console.Write("四");
                }
                if (X[Y] == '5')
                {
                    Console.Write("五");
                }
                if (X[Y] == '6')
                {
                    Console.Write("六");
                }
                if (X[Y] == '7')
                {
                    Console.Write("七");
                }
                if (X[Y] == '8')
                {
                    Console.Write("八");
                }
                if (X[Y] == '9')
                {
                    Console.Write("九");
                }
                if (X[Y] == '0')
                {
                    Console.Write("零");
                }

            }



        }
    }
}
