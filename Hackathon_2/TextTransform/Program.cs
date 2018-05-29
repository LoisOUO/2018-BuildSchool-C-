using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TextTransform.Model;

namespace TextTransform
{
    class Program
    {
        private static List<DayTable> list;

        static void Main(string[] args)
        {
            string fileName = "test03.txt";
            list = new List<DayTable>();
            if (File.Exists(fileName))
            {
                string[] Lines = File.ReadAllLines(fileName);
                foreach (var item in Lines)
                {
                    if (Istrue00(item))
                    {
                        string[] format = { "yyyyMMdd" };
                        DateTime date;
                        DateTime date2;
                        DateTime.TryParseExact(item.Substring(13, 8),
                                                   format,
                                                   System.Globalization.CultureInfo.InvariantCulture,
                                                   System.Globalization.DateTimeStyles.None,
                                                   out date);
                        DateTime.TryParseExact(item.Substring(21, 8),
                                                   format,
                                                   System.Globalization.CultureInfo.InvariantCulture,
                                                   System.Globalization.DateTimeStyles.None,
                                                   out date2);
                        DayTable data = new DayTable()
                        {
                            TickNumber = item.Substring(0, 3),
                            FlyingDay = date,
                            Birthday = date2
                        };
                        try
                        {
                            DayModel list = new DayModel();
                            list.DayTable.Add(data);
                            list.SaveChanges();
                        }
                        catch
                        {
                            Console.WriteLine("錯誤" + item);
                        }

                    }
                }
            }

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();


        }
        private static bool Istrue00(string item)
        {
            return Istrue01(item) && Istrue02(item) && Istrue03(item);
        }

        private static bool Istrue01(string item)
        {
            if (item.Substring(0, 3) == "695" || item.Substring(0, 3) == "525")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Istrue02(string item)
        {
            string str = item.Substring(13, 8);
            string[] format = { "yyyyMMdd" };
            DateTime date;

            return DateTime.TryParseExact(str,
                                       format,
                                       System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None,
                                       out date) || (str == "99999999");

        }
        private static bool Istrue03(string item)
        {
            string str = item.Substring(21, 8);
            string[] format = { "yyyyMMdd" };
            DateTime date;

            return DateTime.TryParseExact(str,
                                       format,
                                       System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None,
                                       out date);

        }



    }
}
