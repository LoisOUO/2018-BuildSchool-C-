using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02080000
{
    class Program
    {
        static void Main(string[] args)
        {
            String X = Console.ReadLine();
            int Y = int.Parse(X);
            for (int i = Y; i >0; i--)
            {
                Console.WriteLine();
                for (int j = i; j > 0; j--)
                {
                    Console.Write(i);
                }

            }


        }
    }
}
