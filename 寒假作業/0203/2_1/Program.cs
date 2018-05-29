using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            for (int Y = X; Y > 0; Y--)  //由數字遞減
            {
              for (int Z = Y; Z <= X; Z++) //做的次數增加
                {
                    Console.Write(Y);
               }
              Console.WriteLine();
                
                
            }


        }
    }
}
