using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {//字串替換
            string N = Console.ReadLine() ;
            
            for (int i = 0; i < N.Length; i++)
            {
                //Console.WriteLine(N[i] +"N[i]");

                switch (N[i])
                {
                    case '1':
                        Console.Write("一");
                        break;
                    case '2':
                        Console.Write("二");
                        break;
                    case '3':
                        Console.Write("三");
                        break;
                    case '4':
                        Console.Write("四");
                        break;
                    case '5':
                        Console.Write("五");
                        break;
                    case '6':
                        Console.Write("六");
                        break;
                    case '7':
                        Console.Write("七");
                        break;
                    case '8':
                        Console.Write("八");
                        break;
                    case '9':
                        Console.Write("九");
                        break;
                }

            }
            
        }
    }
}
