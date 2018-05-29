using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Y = Console.ReadLine();
            DateTime D = new DateTime(int.Parse(Y),1,1);
            switch(D.DayOfWeek)
            {
                    
                case DayOfWeek.Friday:

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:

                    Console.WriteLine("星期六有 ");
                    break;

            }

        }
    }
}
