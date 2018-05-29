using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon002
{
    class Program
    {
        static void Main(string[] args)
        {
            int candy = 12; //目標糖果12
            int j = 0; //包裝紙
            int p = 0;//購買糖果的數量
            for (int i = candy; i > 0; i--)
            {
                p++;
                j++;
                if (j % 3 == 0)
                {
                    i--; ;
                    j++;
                }
            }
            Console.WriteLine("購買數量:"+p);



        }
    }
}
