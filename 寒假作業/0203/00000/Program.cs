using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00000
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string X = Console.ReadLine();
            int i = int.Parse(X);
            for (int Y = i; Y >0; Y--)
            {
                for (int Z = Y; Z >0 ; Z--)
                {
                    Console.Write(Y);
                }
                Console.WriteLine();
            }



        }
    }
}
