using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            //迴圈倒置#1
            string N = Console.ReadLine(); //輸入一個有,分開的字串
            char splits = ','; //有,的地方
            string[] A = N.Split(splits); //把有,切開 放到陣列裡
            
            for (int i = A.Length-1; i >= 0; i--) //從最後(最大)一個開始做 遞減
            {
                Console.Write(A[i] +',');
                    
            }
           
           /*
            string X = "abcde"; //輸入字串
            for (int i = X.Length-1; i >= 0; i--) //i=最後的字元 從最後一個開始做 遞減到第一個字元
            {
                Console.Write(X[i]); //
            }*/
            /*
            string X = "abc,bcd,cde"; //
            char S = ','; //有,的地方
            string[] A = X.Split(S); // 有,切開 放到陣列裡面

            for (int i = 0; i < A.Length; i++) //把A[]一個一個拿出來(各做一次)
            {
                string Y = A[i]; //A[i] =abc bcd cde 
                for (int j = 0; j < Y.Length; j++) //把 abc bcd cde 切成字元                {
                    Console.WriteLine(Y[j]);

                }
            }*/

        }
    }
}
