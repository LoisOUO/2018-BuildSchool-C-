using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //開始遊戲 crandom.Next(int min,int max)
          
            var number = textBox1.Text;

            Random r 
        }
        
        


        private void button2_Click(object sender, EventArgs e)
        {//看答案

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //輸入的數字
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //檢查答案
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //放棄重來
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //遊戲歷程
        }
    }



}
