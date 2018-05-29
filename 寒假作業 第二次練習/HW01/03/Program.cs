using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {//迴圈倒置#2
            int x = 5;
            for (int i=x;i>0;i--)
            {
                for (int j = 5; j >= i; j--)
                { Console.Write(i); }
                Console.WriteLine();
            }


        }
    }
}
