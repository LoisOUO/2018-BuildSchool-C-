using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();

            if (DateTime.IsLeapYear(int.Parse(year)))
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }
        }
    }
}
