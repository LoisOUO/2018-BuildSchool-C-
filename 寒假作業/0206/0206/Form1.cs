using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string years = textBox1.Text;
            int Y = int.Parse(years)+1911;
            DateTime D = new DateTime(Y, 1, 1);
            if (DateTime.IsLeapYear(Y))
            {
                switch (D.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                       MessageBox.Show("星期六:53天，星期日:52天");
                        break;
                    case DayOfWeek.Saturday:
                        MessageBox.Show("星期六:53天，星期日:53天");
                        break;
                    case DayOfWeek.Sunday:
                        MessageBox.Show("星期六:52天，星期日:53天");
                        break;
                    default:
                        MessageBox.Show("星期六:52天，星期日:52天");
                        break;
                }
            }
            else
            {
                switch (D.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        MessageBox.Show("星期六:52天，星期日:52天");
                        break;
                    case DayOfWeek.Saturday:
                        MessageBox.Show("星期六:53天，星期日:52天");
                        break;
                    case DayOfWeek.Sunday:
                        MessageBox.Show("星期六:52天，星期日53天");
                        break;
                    default:
                        MessageBox.Show("星期六:52天，星期日:52天");
                        break;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
