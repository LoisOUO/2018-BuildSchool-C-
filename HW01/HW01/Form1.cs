using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class Form1 : Form
    {
        
        static private List<Class1> list;
        public Form1()
        {
            InitializeComponent();
            list = CreateList();
            var list01 = income();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = list01;

            var MaxSeller = list.Where((x)=>x.total==list.Max((s)=>s.total));
            foreach (var seller in MaxSeller)
            {
                label1.Text += seller.Name01;
                //Console.WriteLine(" " + seller.Name01);
            }
            var MaxProduct = list01.Where((z) => z.Sales == list01.Max((s) => s.Sales));
            foreach(var product in MaxProduct)
            {
                label5.Text += product.product;

            }

            /*

                        var bill = list.Where((x) => x.Name01 == "Bill").Sum((x) => x.Pen * 12 + x.Pencil * 16 + x.Ruler * 10 + x.Eraser * 14 + x.White * 15);
                        var john = list.Where((x) => x.Name01 == "John").Sum((x) => x.Pen * 12 + x.Pencil * 16 + x.Ruler * 10 + x.Eraser * 14 + x.White * 15);
                        var david = list.Where((x) => x.Name01 == "David").Sum((x) => x.Pen * 12 + x.Pencil * 16 + x.Ruler * 10 + x.Eraser * 14 + x.White * 15);
            */
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        static List<Class1> CreateList()
        {
            var list = new List<Class1>();
            list.Add(new Class1() { Name01 = "Bill", Pen = 33, Pencil = 32, Eraser = 56, Ruler = 45, White = 33, total = 33 * 12 + 32 * 16 + 56 * 10 + 45 * 14 + 33 * 15 });
            list.Add(new Class1() { Name01 = "John", Pen = 77, Pencil = 33, Eraser = 68, Ruler = 45, White = 23 ,total=77*12+33*16+68*10+45*14+23*15});
            list.Add(new Class1() { Name01 = "David", Pen = 43, Pencil = 55, Eraser = 43, Ruler = 67, White = 65,total=43*12+55*16+43*10+67*14+65*15 });

            return list;
            /*
        原子筆單價12 Pen
         鉛筆單價16 Pencil
         橡皮擦單價10 Eraser
         直尺單價14 Ruler
         立可白單價15 white*/
        }
        static List<Class2>income()
        {
            var list01 = new List<Class2>();
            list01.Add(new Class2() { product = "原子筆", Price =12, sum =list.Sum((x)=>x.Pen),Sales=list.Sum((x)=>x.Pen)*12 });
            list01.Add(new Class2() { product = "鉛筆", Price =16, sum =list.Sum((x)=>x.Pencil),Sales= list.Sum((x) => x.Pencil) *16});
            list01.Add(new Class2() { product = "橡皮擦", Price =10, sum =list.Sum((x)=>x.Eraser),Sales= list.Sum((x) => x.Eraser)*10 });
            list01.Add(new Class2() { product = "直尺", Price =14, sum =list.Sum((x)=>x.Eraser),Sales= list.Sum((x) => x.Eraser)*14 });
            list01.Add(new Class2() { product = "立可白", Price =15, sum = list.Sum((x)=>x.White),Sales= list.Sum((x) => x.White)*15 });
            return list01;

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
