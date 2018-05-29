using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    class MyData
    {
        public string star { get; set; }
        public string monthStars { get; set; }
        public string monthEnd { get; set; }
        public int dayStars { get; set; }
        public int dayEnd { get; set; }

    }
    class Num
    {
        public string Stars { get; set; }    //星座
        public int NumNumerology { get; set; }  //生命靈數
        public string Narrative{ get; set; }  //敘述部分
    }

}
