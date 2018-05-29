using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數字");
            string input = Console.ReadLine();
            value = int.Parse(input);
            if (value %2 ==0)
            {
                Console.WriteLine("輸入的是偶數");
            }
            else
            {
              Console.WriteLine("輸入的是奇數");
            }


        }
    }
}
