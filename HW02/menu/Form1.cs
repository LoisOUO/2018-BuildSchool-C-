using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //高麗菜 3 豆干*2-15 海帶*2-15 肉片-40
            var Cabbage = (int)(numericUpDown1.Value);
            var beans = (int)numericUpDown2.Value;
            var kelp =(int) numericUpDown3.Value;
            var meat = (int)numericUpDown4.Value;
            var total = (int)(Cabbage * 30 + beans * 15 + kelp * 15 + meat * 40);
            label6.Text = total.ToString();
            label8.Text = null;

            var Money1000 = 0;
            var Money500 = 0;
            var Money100 = 0;
            var Money50 = 0;
            var Money10 = 0;
            var Money5 = 0;
            
            if (total / 1000 >= 0)
            {
                Money1000 = total/ 1000;
                total = total - Money1000 * 1000;
                label8.Text += $"千元鈔票:{Money1000} ";
            }
            if (total / 500 >= 0)
            {
                Money500 = total / 500;
                total = total - Money500 * 500;
                label8.Text += $"五百鈔票:{Money500}";
            }
            if (total / 100 >= 0)
            {
                Money100 = total / 100;
                total -= Money100 * 100;
                label8.Text += $"一百鈔票:{Money100}";
            }
            if (total / 50 >= 0)
            {
                Money50 = total / 50;
                total -= Money50 * 50;
                label8.Text += $"五十元硬幣:{Money50}";
            }
            if (total / 10 >= 0)
            {
                Money10 = total / 10;
                total -= Money10*10;
                label8.Text += $"十元硬幣:{Money10}";
            }
            if (total/5 >= 0)
            {
                Money5 = total / 5;
                total -= Money5 * 5;
                label8.Text += $"五元硬幣:{Money5}";
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
