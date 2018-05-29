using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //判斷奇數偶數
            Console.WriteLine("請輸入一個數字");
            int N=int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            { Console.WriteLine(N + "為偶數"); }
            else { Console.WriteLine(N+"為奇數");    }

        }
    }
}
