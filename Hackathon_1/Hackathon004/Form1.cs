using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static List<int> list;
        private void button1_Click(object sender, EventArgs e)
        {
            Random Random1 = new Random();
            for (int i = 0; i < 4;)
            {
                foreach (var X in list)
                { 
                var R = Random1.Next(0, 10);
                if (X.ToString().Contains(R.ToString())) //用list寫
                {
                    Random1 = new Random();
                    R = Random1.Next(0, 10);
                }
                else
                {
                    i++;
                    list.Add(R);
                }
                Console.WriteLine(R.ToString());
            }
        }
        }


    }
}
