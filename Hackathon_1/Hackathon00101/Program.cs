using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon00101
{
    class Program
    {
        //private static Dictionary<string, string>_d;
        static void Main(string[] args)
        {
            Num();
            ReplaceNum();
          
            
        }
        private static void ReplaceNum()
        {
            var ReNum = Num();
            string L;
            string K;
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    K = i.ToString();
                    
                    
                    Console.WriteLine(j);
                    //K = i.ToString();
                    //L = K.Replace(K, ReNum[int.Parse(K)]);
                    //console.writeline(l.tostring());
                }
            }
            
        }
        private static void Display()
        {

        }


        private static Dictionary<int,string> Num()
        {
            return new Dictionary<int, string>
            {
                {1,"1" },
                {2,"2" },
                {3,"A"},
                {4,"4" },
                {5,"B"},
                {6,"6" },
                {7,"7"},
                {8,"8" },
                {9,"C"},
                {0,"D"}

            };
        }

    }
}
