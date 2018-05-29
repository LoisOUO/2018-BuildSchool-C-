using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        // string inputs;
        static void Main(string[] args)
        {

            // string input;
            var data = GetDictionary();
            for (int i = 1; i <= 100; i++)
            {
                string X = i.ToString();
            
                    X = X.Replace("0","D").Replace("3","A").Replace("5","B").Replace("9","C");
                    Console.Write(X);

                Console.WriteLine();
            }

        }



        static private Dictionary<int, string> GetDictionary()
        {
            return new Dictionary<int, string>
                {
                    {1,"1" },
                    {2,"2" },
                    {3,"A"},
                    {4,"4" },
                    {5,"B" },
                    {6,"6" },
                    {7,"7" },
                    {8,"8" },
                    {9,"C" },
                    {0,"D" }
                };

        }

    }

}