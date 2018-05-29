using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list = new List<int>();
            list2 = new List<int>();
        }
        List<int> list;
        List<int> list2;
        int RanNum;
        private void button1_Click(object sender, EventArgs e)
        {

            Random Ran = new Random();
            for (int i = 0; i < 4;)
            // parts.Exists(x => x.PartId == 1444));{
            {
                RanNum = Ran.Next(0, 10); //產生一個 0-9的數字

                if (list.Exists(x => x == RanNum))
                { }
                else
                {
                    list.Add(RanNum);
                    i++;
                }
            }
            foreach (var X in list)
            {

                System.Diagnostics.Debug.Write(X + " "); //顯示隨機出現的數字

            }
            System.Diagnostics.Debug.WriteLine("");
            /*
            Console.WriteLine();
            string Player = "1234";  //獎設輸入的數字是1234
            var chars = Player.ToArray();     //轉換成字串
            for (int j = 0; j < chars.Length; j++) //把每個字元猜開
            {
                list2.Add(int.Parse((chars[j]).ToString()));

            }

            var intersectedList = list.Intersect(list2); //做交集
            foreach (var item in intersectedList)
            {
                Console.WriteLine(item + "item"); //顯示交集的數字
            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {//放棄
            listBox1.Items.Clear();
            list = new List<int>();
            list2 = new List<int>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength =4;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Player = textBox1.Text;  //輸入的數字是1234
            var chars = Player.ToArray();     //轉換成字串
            for (int j = 0; j < chars.Length; j++) //把每個字元猜開
            {
                list2.Add(int.Parse((chars[j]).ToString()));

            }
            var intersectedList = list.Intersect(list2); //做交集
            int A = 0;
            int B = 0;
            foreach (var item in intersectedList)
            {
                var X = list2.IndexOf(item);
                if (X == list.IndexOf(item))
                { //如果交集後的數字位置相同
                    A++;
                }
                else
                {//如果交集後的數字不相同
                    B++;
                }
            }
            //Console.WriteLine(A + "A" + B + "B");
            listBox1.Items.Add(Player+":"+A + "A"+B+"B:");
            if (A == 4)
            { MessageBox.Show("過關!"); }
            list2 = new List<int>();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
