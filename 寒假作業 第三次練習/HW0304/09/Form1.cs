using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        private static Dictionary<Class1, double> _d;
        private static List<string> list;
        private static List<string> list2;
        
        public Form1()
        {
            InitializeComponent();
            Dic();
            list= createList();
            list2 = createList();
            SetCombobox();
     
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            //fare 起站到迄站的票價
            var fare = _d.Where(x => x.Key.End == comboBox1.Text && x.Key.Start == comboBox2.Text||x.Key.Start == comboBox1.Text && x.Key.End == comboBox2.Text).Select(x => x.Value);
            // fare=_d.Where(x=>x.Key.Start==comboBox1.Text&&x.Key.End==comboBox2.Text).Select(x=>x.Value)
            foreach (var Fare1 in fare)
            {
                //MessageBox.Show("價格:"+Fare1.ToString());
                label4.Text = Fare1.ToString();

                var FareFF = Fare1;
                if (checkBox1.Checked)
                {
                   FareFF= FareFF * 0.9*2;

                }
                if (checkBox2.Checked)
                {
                    FareFF = FareFF * 0.9;
                }
                label5.Text =Math.Ceiling(FareFF).ToString();
            }
            
        }
        
        private void SetCombobox()
        {
            comboBox1.DataSource = list;
            comboBox2.DataSource = list2;
            
        }
        
        static List<string> createList() 
        {
            var list1 = new List<string>();
            list1.Add("台北");
            list1.Add("新竹");
            list1.Add("台中");
            list1.Add("台南");
            list1.Add("嘉義");
            list1.Add("高雄");
            return list1;
        }
        
        private static void Dic()
        {
            _d = new Dictionary<Class1, double>();
            _d.Add(new Class1 { Start = "台北", End = "新竹" }, 177);
            _d.Add(new Class1 { Start = "台北", End = "台中" }, 375);
            _d.Add(new Class1 { Start = "台北", End = "嘉義" }, 598);
            _d.Add(new Class1 { Start = "台北", End = "台南" }, 738);
            _d.Add(new Class1 { Start = "台北", End = "高雄" }, 842);

            _d.Add(new Class1 { Start = "新竹", End = "台中" }, 197);
            _d.Add(new Class1 { Start = "新竹", End = "嘉義" }, 421);
            _d.Add(new Class1 { Start = "新竹", End = "台南" }, 560);
            _d.Add(new Class1 { Start = "新竹", End = "高雄" }, 755);

            _d.Add(new Class1 { Start = "台中", End = "嘉義" }, 224);
            _d.Add(new Class1 { Start = "台中", End = "台南" }, 363);
            _d.Add(new Class1 { Start = "台中", End = "高雄" }, 469);

            _d.Add(new Class1 { Start = "嘉義", End = "台南" }, 139);
            _d.Add(new Class1 { Start = "嘉義", End = "高雄" }, 245);

            _d.Add(new Class1 { Start = "台南", End = "高雄" }, 106);
            _d.Add(new Class1 { Start = "", End = "" }, 177);
            //  _d.Add(new Class1 { Start = "", End = "" }, );
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox thecomboBox = (ComboBox)sender; //找索引值
            //int index = thecomboBox.SelectedIndex; //index為索引值
            //  string item = list[index];    //第index位置的內容

            var SS = list.IndexOf(comboBox1.Text);
            list2 = new List<string>();
            if (radioButton1.Checked) //如果選擇南下
            {
                for (int i = SS+1; i < 6; i++)
                {
                    list2.Add(list[i]);
                }
            }

            else if (radioButton2.Checked) //如果選擇南下
            {
                for (int i = SS-1; i >= 0; i--)
                {
                    list2.Add(list[i]);
                }
            }
            if (list2.Count == 0)
            {
                comboBox2.SelectedText = null;
                comboBox2.Text = null;
            }
            
            SetCombobox();//listchang要更新
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }




}
