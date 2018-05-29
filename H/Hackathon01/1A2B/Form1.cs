using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static private List<string> list;
        private void button1_Click(object sender, EventArgs e)
        {
            Random Ran = new Random();
            
            List<int> list = new List<int>();  //
            Random RandomNumber = new Random(); //亂數
                                                //  var RandomRrange = RandomNumber.Next(0, 10); //產生一個在亂數的範圍的數字
           // int Random1 = Ran.Next(0, 10);
            for (int i = 0; i < 4; i++)
            {
                int Random1= Ran.Next(0, 10);
                foreach (var item in list)
                {
                    if (item == Random1)
                    {
                        Random1 = Random1 + 1; 
                        Console.WriteLine("++");
                    }
                    list.Add(Random1);
                }
                Console.WriteLine(list.Count);
                
           }



            


        }
      




    }
}
