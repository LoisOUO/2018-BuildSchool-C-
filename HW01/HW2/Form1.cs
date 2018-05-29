using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Form1 : Form
    {
        static private List<MyData> list;
        public Form1()
        {
            InitializeComponent();
            list = CreateList();
        }

       static List<MyData> CreateList()
        {
            var list = new List<MyData>();
            list.Add(new MyData { start = "台北", end = "新竹", fare =177 });
            list.Add(new MyData { start = "台北", end = "台中", fare = 375 });
            list.Add(new MyData { start = "台北", end = "嘉義", fare = 598 });
            list.Add(new MyData { start = "台北", end = "台南", fare = 738 });
            list.Add(new MyData { start = "台北", end = "高雄", fare = 842 });
            
            list.Add(new MyData { start = "新竹", end = "新竹", fare = 0 });
            list.Add(new MyData { start = "新竹", end = "台中", fare = 197 });
            list.Add(new MyData { start = "新竹", end = "嘉義", fare = 421 });
            list.Add(new MyData { start = "新竹", end = "台南", fare = 560 });
            list.Add(new MyData { start = "新竹", end = "高雄", fare = 755 });

         //  list.Add(new MyData { start = "台中", end = "新竹", fare = 177 });
           // list.Add(new MyData { start = "台中", end = "台中", fare = 0 });
            list.Add(new MyData { start = "台中", end = "嘉義", fare = 224 });
            list.Add(new MyData { start = "台中", end = "台南", fare = 363 });
            list.Add(new MyData { start = "台中", end = "高雄", fare = 469 });

          //  list.Add(new MyData { start = "嘉義", end = "新竹", fare = 177 });
           // list.Add(new MyData { start = "嘉義", end = "台中", fare = 375 });
           // list.Add(new MyData { start = "嘉義", end = "嘉義", fare = 0 });
            list.Add(new MyData { start = "嘉義", end = "台南", fare = 139 });
            list.Add(new MyData { start = "嘉義", end = "高雄", fare = 245 });

           // list.Add(new MyData { start = "台南", end = "新竹", fare = 177 });
            //list.Add(new MyData { start = "台南", end = "台中", fare = 375 });
           // list.Add(new MyData { start = "台南", end = "嘉義", fare = 598 });
           // list.Add(new MyData { start = "台南", end = "台南", fare = 738 });
            list.Add(new MyData { start = "台南", end = "高雄", fare = 106 });

            //list.Add(new MyData { start = "高雄", end = "新竹", fare = 177 });
           // list.Add(new MyData { start = "高雄", end = "台中", fare = 375 });
            //list.Add(new MyData { start = "高雄", end = "嘉義", fare = 598 });
           // list.Add(new MyData { start = "高雄", end = "台南", fare = 738 });
           // list.Add(new MyData { start = "高雄", end = "高雄", fare = 842 });

            return list;
            
        }

       






        private void button1_Click(object sender, EventArgs e)
        {

            var item1 = comboBox1.SelectedItem;
            var item2 = comboBox2.SelectedItem;
            List<MyData> StartT;
            bool bool1 = list.Exists((x) => x.start == item1.ToString() && x.end == item2.ToString());
            if (bool1)
            {
                 StartT = (list.Where((x) => x.start == item1.ToString() && x.end == item2.ToString())).ToList();
            }
            else
            {
                StartT = (list.Where((x) => x.start == item2.ToString() && x.end == item1.ToString())).ToList();
            }

            


            foreach (var T in StartT)
            {
                if (checkBox1.Checked)
                {
                    var S =T.fare*2*0.9;
                   // decimal X = Convert.ToDecimal(S);

                    if (checkBox2.Checked)
                    {
                        label4.Text = (Math.Ceiling(S*0.9)).ToString(); }
                    else
                    { label4.Text = (Math.Ceiling(S).ToString());
                    }
                }
                else
                {
                    var S = T.fare ;
                    if (checkBox2.Checked)
                    { label4.Text = Math.Ceiling(S*0.9).ToString(); }
                    else
                    { label4.Text = ((S ).ToString()); }
                }


              //  Console.WriteLine(item1 + "item");
               // Console.WriteLine(T.fare + "$");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           //北上


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //南下


        }
    }
}
