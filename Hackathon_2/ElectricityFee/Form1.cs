using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DicMoney();
        }
        private static Dictionary<string, Electricity> ProvinceDic;
        
        private void button1_Click(object sender, EventArgs e)
        {

            int TimeMM = int.Parse(textBox1.Text);
            int Flowering = (350 + (TimeMM * 4));
            ProvinceDic["中華電信"].total = Flowering;
     
            var RemoteTransmission = (400 + TimeMM * 3);
            ProvinceDic["遠傳"].total = RemoteTransmission;
            var another = (500 + TimeMM * 2);
            ProvinceDic["台灣大哥大"].total = another;
     
            var Maxprovince = ProvinceDic.Min(x => x.Value.total);
            var XX= (ProvinceDic.Where(x => x.Value.total == Maxprovince).Select(x=>x.Key));
            foreach (var item in XX)
            {
                    label4.Text = item;
            }
            
            label1.Text =$"中華電信: {Flowering}";
            label2.Text = $"遠傳:{RemoteTransmission}";
            label3.Text = $"台灣大哥大:{another}";


        }
        private void DicMoney()
        {
            ProvinceDic = new Dictionary<string, Electricity>();
            ProvinceDic.Add("中華電信", new Electricity {});
            ProvinceDic.Add("遠傳", new Electricity { });
            ProvinceDic.Add("台灣大哥大", new Electricity { });
         
        }

        
        class Electricity
        {

            public int total { get; set; }
            public int Money { get; set; }
        }
    }
}
