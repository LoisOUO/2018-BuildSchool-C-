using consume.Models;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //存檔方式
            //ContactsModel contacts = new ContactsModel();
            ////contacts.Table.Add(new Table { })
            //contacts.SaveChanges(); //存檔這個動作
            Table Data = new Table()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = (double)( numericUpDown1.Value),
                Kilometer = (double)(numericUpDown2.Value)
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.Table.Add(Data);
                context.SaveChanges();
                MessageBox.Show("存檔成功");

            }
            catch
            {
                MessageBox.Show("失敗");
            }

            
            //DateTime AddTime = dateTimePicker1.Value;
            //var AddL = numericUpDown1.Value;
            //var AddK = numericUpDown2.Value;
            
            
            //存檔方式
            //ContactsModel contacts = new ContactsModel();
            ////contacts.Table.Add(new Table { })
            //contacts.SaveChanges(); //存檔這個動作
        }
        private void ClearTextBox()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
