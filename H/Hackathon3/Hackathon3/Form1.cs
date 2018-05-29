using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon3
{
    public partial class Form1 : Form
    {
      //  int CtransformF;
       // int FtransformC;
        double temperature; //溫度
        string Sum; //輸入的溫度
        
       //string Decimal;//小數點
        public Form1()
        {
            InitializeComponent();
            //int CtransformF = (N * 9 / 5) + 32;
            //int FtransformC = (N - 32) * 5 / 9;
           // CtransformF= ((temperature * 9 / 5) + 32);
            // FtransformC = ((temperature - 32) * 5 / 9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temperature = double.Parse(Sum);
                //                Console.WriteLine(CtransformF);
                label2.Text = temperature.ToString()+ "°C";
                label4.Text = ((temperature * 9 / 5) + 32).ToString()+ "°F";
            }
            else
            {
                temperature = double.Parse(Sum);
                label2.Text = temperature.ToString()+ "°F";
                label4.Text = ((temperature-32)*5/9).ToString() + "°C";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sum +="1";
            

            textBox1.Text = Sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sum += "2";
            textBox1.Text = Sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sum += "3";
            textBox1.Text = Sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sum += "4";
            textBox1.Text = Sum.ToString();
            //textBox1.Text = (4).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sum += "5";
            textBox1.Text = Sum.ToString();
            //textBox1.Text = (5).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sum += "6";
            textBox1.Text = Sum.ToString();
            //textBox1.Text = (6).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sum += "7";
            textBox1.Text = Sum.ToString();
            //textBox1.Text = (7).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sum += "8";
            textBox1.Text = Sum.ToString();
            // textBox1.Text = (8).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sum += "9";


            textBox1.Text = Sum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sum += "0";
            textBox1.Text = Sum.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //            Decimal = ".";

            Sum += ".";
            textBox1.Text = Sum.ToString();


            //    textBox1.Text= (".").ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //清除
            //textBox1.Clear();
            Sum = string.Empty;
            textBox1.Text = string.Empty;

        }
    }
}
