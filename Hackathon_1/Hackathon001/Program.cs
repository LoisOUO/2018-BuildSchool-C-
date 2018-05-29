using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                foreach (var X in i.ToString())
                {
                    switch (X)
                    {
                        case '3':
                            Console.Write("A");
                            break;
                        case '5':
                            Console.Write("B");
                            break;
                        case '9':
                            Console.Write("C");
                            break;
                        case '0':
                            Console.Write("D");
                            break;
                        default:
                            Console.Write(X);
                            break;
                    }
                   
                }
                Console.WriteLine();
            } Console.ReadLine();
        }
    }
}
