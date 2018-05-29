using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransform
{
    public class Class1
    {

        public static bool Istrue01(string item)
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

        public static bool Istrue02(string item)
        {
            string str = item.Substring(13, 8);
            string[] format = { "yyyyMMdd" };
            DateTime date;

            return DateTime.TryParseExact(str,
                                       format,
                                       System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None,
                                       out date) && (str == "99999999");

        }
        public static bool Istrue03(string item)
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
