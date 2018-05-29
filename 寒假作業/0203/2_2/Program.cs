using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        static private List<int> odd;//= new List<int>();
        static private List<int> even;//= new List<int>();

        static void Main(string[] args)
        {
            even = new List<int>();
            odd = new List<int>();
            string X = Console.ReadLine();
            string[] Y = X.Split(',');
            foreach (var Z in Y)
            {
                if (int.Parse(Z) % 2 == 0)
                {
                    even.Add(int.Parse(Z));
                }
                else
                {
                    odd.Add(int.Parse(Z));
                }
            }
            odd.Sort();
            even.Sort();
            Console.Write("奇數:");
            foreach (var L in odd)
            {
                Console.Write(L +",");
            }
            Console.WriteLine();
            Console.Write("偶數:");
            foreach (var L in even)
            {
                Console.Write(L +",");
            }
            Console.WriteLine();


        }
      
        
        

    }
}
