using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
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
                        {
                            Console.Write("    "); //1
                        }
                        break;
                    case '2':
                        {
                            Console.Write(" __ "); //2-1
                        }
                        break;
                    case '3':
                        {
                            Console.Write(" __ "); //3--1
                        }
                        break;
                    case '4':
                        {
                            Console.Write("    "); //4-1
                        }
                        break;
                    case '5':
                        {
                            Console.Write(" __ "); //5-1
                        }
                        break;
                    case '6':
                        {
                            Console.Write(" __ "); //6-1
                        }
                        break;
                    case '7':
                        {
                            Console.Write(" __ "); //7-1
                        }
                        break;
                    case '8':
                        {
                            Console.Write(" __ ");  //8-
                        }
                        break;
                    case '9':
                        {
                            Console.Write(" __ "); //9-1
                        }
                        break;
                    case '0':
                        {
                            Console.Write(" __ "); //0-1
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine();
            foreach (var item2 in list)
            {
                switch (item2)
                {
                    case '1':
                        {
                            Console.Write("   |"); //1 
                        }
                        break;
                    case '2':
                        {
                            Console.Write(" __|"); //2-2
                        }
                        break;

                    case '3':
                        {
                            Console.Write(" __|"); //3-2
                        }
                        break;
                    case '4':
                        {
                            Console.Write("|__|"); //4-2
                        }
                        break;
                    case '5':
                        {
                            Console.Write("|__ "); //5-2
                        }
                        break;

                    case '6':
                        {
                            Console.Write("|__ "); //6-2
                        }
                        break;

                    case '7':
                        {
                            Console.Write("   |"); //7-2
                        }
                        break;
                    case '8':
                        {
                            Console.Write("|__|"); //8-2
                        }
                        break;
                    case '9':
                        {
                            Console.Write("|__|"); //9-2
                        }
                        break;
                    case '0':
                        {
                            Console.Write("|  |"); //0-2
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            foreach (var item3 in list)
            {
                switch (item3)
                {
                    case '1':
                        {
                            Console.Write("   |");//1
                        }
                        break;
                    case '2':
                        {
                            Console.Write("|__ "); //2-3
                        }
                        break;
                    case '3':
                        {
                            Console.Write(" __|"); //3-3
                        }
                        break;
                    case '4':
                        {
                            Console.Write("   |"); //4-3
                        }
                        break;
                    case '5':
                        {
                            Console.Write(" __|"); //5-3
                        }
                        break;
                    case '6':
                        {
                            Console.Write("|__|");  //6-3
                        }
                        break;

                    case '7':
                        {
                            Console.Write("   |"); //7-3
                        }
                        break;

                    case '8':
                        {
                            Console.Write("|__|"); //8-3
                        }
                        break;
                    case '9':
                        {
                            Console.Write("   |"); //9-3
                        }
                        break;
                    case '0':
                        {
                            Console.Write("|__|"); //0-3
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }











    }
}

