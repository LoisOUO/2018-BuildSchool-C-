using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consume.Models;

namespace consume
{
    public partial class AllData : Form
    {
        public AllData()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            //var contact = new ContactsModel();
            //var list = contact.Table.ToList();
            //dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contact = new ContactsModel();
            var list = contact.Table.ToList();
            var Startday = list.Where(x => x.RefuelingDate >= dateTimePicker1.Value && x.RefuelingDate <= dateTimePicker2.Value);
            dataGridView1.DataSource = Startday.ToList();

            var totalLote = Startday.Sum(x => x.Liter);
            var totalKilometer = Startday.Max(x=>x.Kilometer)-Startday.Min(x=>x.Kilometer);
            label2.Text = (totalKilometer / totalLote).ToString();
        }
    }
}
