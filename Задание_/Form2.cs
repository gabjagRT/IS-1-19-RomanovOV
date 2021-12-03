using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        abstract class Komplekt<T>
        {
            protected int cost;
            protected int year;
            protected T article;
            public Komplekt(int n1, int n2, T n9)
            {
                cost = n1;
                year = n2;
                article = n9;
            }
            public abstract void Display(ListBox lb);
        }
        class CP<T> : Komplekt<T>
        {
            public CP(int n1, int n2, int n3, int n4, int n5, T n9)
                : base(n1, n2, n9)
            {
                frequency = n3;
                cores = n4;
                potoki = n5;
            }
            int frequency;
            int cores;
            int potoki;
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Стоимость - {cost}, Год производства - {year}, Частота памяти - {frequency}, Количество ядер - {cores}, Количество потоков - {potoki}");
            }
        }
        public int frequency { get { return frequency; } set { frequency = value; } }
        public int cores { get { return cores; } set { cores = value; } }
        public int potoki { get { return potoki; } set { potoki = value; } }
        class Videocard<T> : Komplekt<T>
        {
            public Videocard(int n1, int n2, int n6, string n7, int n8, T n9)
                : base(n1, n2, n9)
            {
                gpu_frequency = n6;
                vendor = n7;
                memory = n8;
            }
            int gpu_frequency;
            string vendor;
            int memory;
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Стоимость - {cost}, Год производства - {year}, Частота GPU - {gpu_frequency}, Производитель - {vendor}, Объём памяти - {memory}");
            }
        }
        public int gpu_frequency { get { return gpu_frequency; } set { gpu_frequency = value; } }
        public string vendor { get { return vendor; } set { vendor = value; } }
        public int memory { get { return memory; } set { memory = value; } }
        CP<int> ex1;
        Videocard<int> ex2;
        private void button1_Click_1(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int n6 = Convert.ToInt32(textBox3.Text);
            string n7 = textBox7.Text;
            int n8 = Convert.ToInt32(textBox8.Text);
            int n9 = Convert.ToInt32(textBox9.Text);
            ex2 = new Videocard<int>(n1, n2, n6, n7, n8, n9);
            ex2.Display(listBox1);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int n3 = Convert.ToInt32(textBox3.Text);
            int n4 = Convert.ToInt32(textBox4.Text);
            int n5 = Convert.ToInt32(textBox5.Text);
            int n9 = Convert.ToInt32(textBox9.Text);
            ex1 = new CP<int>(n1, n2, n3, n4, n5, n9);
            ex1.Display(listBox1);
        }
    }
}
