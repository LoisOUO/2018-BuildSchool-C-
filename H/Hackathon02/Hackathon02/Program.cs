using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Candy Paper Free
            Console.Write("想吃幾顆糖果?");
            int Candy = int.Parse(Console.ReadLine()); 
            Console.WriteLine("如果想吃"+Candy+"顆糖果");
            int j=0; //j是買的糖果數量
            for (int i = Candy; i >= 0; i--) //可以把i看成離目標多遠
            {
              
                var paper = i; //每吃一顆糖有一張紙
                if (paper % 3 == 0)
                {
                    i--;    //三張紙換一顆糖果 所以用錢買的動作少一次
                }
                else
                {
                }
                j++; //購買次數+1
                //Console.WriteLine(j);
            }
            Console.WriteLine("總共要買"+j +"顆");
            //Console.ReadLine();
        }
        
    }
}
