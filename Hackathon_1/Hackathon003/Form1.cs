using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text ="0";
            radioButton1.Text = "華氏轉換成攝氏";
            radioButton2.Text = "攝氏轉換成華氏";
            
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = ".";
            button12.Text = "轉換";
            button13.Text = "清除";
        }


        private void button12_Click(object sender, EventArgs e)
        {

            double temperature = double.Parse(textBox1.Text);  //輸入的溫度
            double transform = 0;  //轉換後的溫度
            if (radioButton1.Checked) //輸入華 轉 攝
            {
                transform = (temperature - 32) * 5 / 9;
                label2.Text = $"{temperature}ºF = {transform:00.00}ºC";

            }
            if (radioButton2.Checked)
            {
                transform = temperature * 9 / 5 - 32;
                label2.Text = $"{temperature}ºC={transform:.00}ºC";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var number = (Button)sender;
            textBox1.Text += number.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }

        //℃ 


    }
}
