using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monkey
{
    class Program
    {
        static List<string> Monkeylist=new List<string>();
        static void Main(string[] args)
        {
            for (int j = 1; j <= 100; j++)
            {
                Monkeylist.Add(j.ToString());
                if (j % 3 == 0)
                {
                    Monkeylist.Remove(j.ToString());
                }
                
            }

            foreach (var item in Monkeylist)
            {
                for (int j = 0; j < 100; j++)
                {
                    //                if(item.IndexOf(item[]))
                    
                    Console.WriteLine(item);
                }
            }


        }
        static void deleteMonkey(List<string> i)
        {
            

            //i.IndexOf(i[3]);

        }
    }
}
