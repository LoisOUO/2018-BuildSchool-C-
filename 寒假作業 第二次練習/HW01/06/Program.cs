using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {//計算一年內的周六與周日
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))//如果該年為閏年
            {
                DateTime date =new DateTime (year, 1, 1);
                Console.WriteLine(date.DayOfWeek);
              
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        Console.WriteLine("六53 日52");
                        return;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("六53 日53");
                        return;
                    case DayOfWeek.Sunday:
                        Console.WriteLine( "六:53 日:53");
                        return;
                    default:
                        Console.WriteLine("六:52 日:52");
                        break;
                }
                //Console.WriteLine(year + "是閏年")
            }

            else //該年!為閏年
            {
                DateTime date = new DateTime(year, 1, 1);
                Console.WriteLine(date.DayOfWeek);
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        Console.WriteLine("六:53 日:52");
                        return;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("六:52 日:53");
                        return;
                    default:
                        Console.WriteLine("六:52 日:52");
                        break;
                }
            }
        }
    }
}
