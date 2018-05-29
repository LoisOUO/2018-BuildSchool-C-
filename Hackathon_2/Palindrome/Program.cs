using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        private static List<char> list;
        static void Main(string[] args)
        {
            list = new List<char>();
            //string StrRed = Console.ReadLine();
            //string Str = StrRed;
            string Str = Console.ReadLine();
            for (int i = 0; i <Str.Length; i++)
            {
                list.Add(Str[i]);
            }
            var min = 0;
            var Max =list.Count-1;
            while (1 <= Max/2)
            {
                if (list[min] ==list[Max])
                {
                    min++;
                    Max--;
                    if (min == Max||(min+Max)/2==Max)
                    {
                        Console.WriteLine("回文");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("不是唷");
                    break;
                }
            }
        }
    }
}
