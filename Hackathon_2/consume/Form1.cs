using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm s = new AddForm();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllData A = new AllData();
            A.Show();
        }
    }
}
