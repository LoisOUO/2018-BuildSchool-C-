using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLED
{
    class Program
    {
        static private List<char> list;
        static void Main(string[] args)
        {
            list = new List<char>();

            string Str = Console.ReadLine();
            for (int i = 0; i < Str.Length; i++)
            {
                list.Add(Str[i]);
            }
            foreach (var item in list)
            {
                switch (item)
                {
                    case '1':
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("  |");
                        }
                            break;
                    case '2':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine(" __|");
                            Console.WriteLine("|__");
                        }
                        break;

                    case '3':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine(" __|");
                            Console.WriteLine(" __|");
                        }
                        break;
                    case '4':
                        {
                            Console.WriteLine("    ");
                            Console.WriteLine("|__|");
                            Console.WriteLine("   |");
                        }
                        break;

                    case '5':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine("|__");
                            Console.WriteLine(" __|");
                        }
                        break;

                    case '6':
                        {
                            Console.WriteLine(" __ ");
                            Console.WriteLine("|__ ");
                            Console.WriteLine("|__|");
                        }
                        break;

                    case '7':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine("   |");
                            Console.WriteLine("   |");
                        }
                        break;

                    case '8':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine("|__|");
                            Console.WriteLine("|__|");
                        }
                        break;

                    case '9':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine("|__|");
                            Console.WriteLine("   |");
                        }
                        break;

                    case '0':
                        {
                            Console.WriteLine(" __");
                            Console.WriteLine("|  |");
                            Console.WriteLine("|__|");
                        }
                        break;

                    default:
                        break;

                }

                
            }


        }
    }
}
