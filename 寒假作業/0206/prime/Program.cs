using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=50;
            int i;
            for (  i = 3; i < N; i++)
            {
                if (N % i == 0 )
                {
                    Console.WriteLine( N+"不是質數" );
                    break;
                }
                else
                {
                    Console.WriteLine(N +"是質數");
                    break;
                }

            }



        }
    }
}
