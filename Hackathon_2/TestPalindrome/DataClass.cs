using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPalindrome
{
    class ClassPali
    {
        public int min { get; set; }
        public int Max { get; set; }
        public double Mn()
        {
            return (Max + min) / 2;
        }
    }
}
