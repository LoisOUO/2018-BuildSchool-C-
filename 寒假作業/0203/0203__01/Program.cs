using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203__01
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = Console.ReadLine();
          //  string[] Y = X.Split(',');
            for (int Z = X.Length-1; Z >= 0; Z--)
            {
                Console.Write(X[Z]);

            }
        }
        

    }
}
