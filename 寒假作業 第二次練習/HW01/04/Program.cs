using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        { //奇偶數判斷#2
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            string N = Console.ReadLine();
            char S = ',';
            string[] A = N.Split(S);
            for (int i = 0; i <= A.Length - 1; i++)
            {
                if (int.Parse(A[i]) % 2 == 0)
                {
                    list1.Add(int.Parse(A[i]));
                }
                if ((int.Parse(A[i])) % 2 != 0)
                {
                    list2.Add(int.Parse(A[i]));
                }
                list1.Sort();
                list2.Sort();
            }
            Console.Write("偶數:");
            foreach (var X in list1)
            {
                Console.Write(X+",");
            }
            Console.WriteLine();
            Console.Write("奇數:");
            foreach (var Y in list2)
            {
                Console.Write(Y+",");
            }
        }
    }
}
