using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double totalTax = 0; //稅金
           double Money = double.Parse(textBox1.Text);

            double Tax5 = (540000) * 0.05;
            double Tax12 = (1210000 - 540000) * 0.12;
            double Tax20 = (2120000 - 1210000) * 20;
            //double TAx30=()

            if (Money <= 540000)
            {
                totalTax = Money * 0.05 ;
            }
            if (540000 < Money && Money <= 1210000)
            {
                totalTax = (Money - 540000)*0.12;
                totalTax += (54000) * 0.05;
            }

            if (1210000 < Money && Money <=2420000 )
            {
                totalTax = (Money - 1210000) * 0.2;
                totalTax += (669999) * 0.12;
                totalTax += (54000) * 0.05;
            }

            if (2420000 < Money && Money <= 4530000)
            {
                totalTax = (Money - 2420000) * 0.3;
                totalTax += (1209999) * 0.2;
                totalTax += (669999) * 0.12;
                totalTax += (54000) * 0.05;

            }
            if (4530000 < Money && Money <= 10310000)
            {
                totalTax = (Money - 4530000) * 0.3;
                totalTax += (2109999) * 0.3;
                totalTax += (1209999) * 0.2;
                totalTax += (669999) * 0.12;
                totalTax += (54000) * 0.05;

            }
            
            if (Money > 10300000)
            {
                totalTax = (Money - 10310000) * 0.50;
                totalTax += (5779999) * 0.4;
                totalTax += (2109999) * 0.3;
                totalTax += (1209999) * 0.2;
                totalTax += (669999)*0.12;
                totalTax += (54000) * 0.05;
            }

            label1.Text = ((decimal)(totalTax)).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
