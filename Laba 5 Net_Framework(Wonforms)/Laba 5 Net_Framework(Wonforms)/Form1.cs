using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5_Net_Framework_Wonforms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text;
            textBox2.Text= str.Replace(" ", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] str1=textBox3.Text.Split(' ');
            string str2;
            str2 = str1[str1.Length - 1];
            for (int i = 0; i < str1.Length - 1; i++)
            {
                if (str1[i] != str2)
                {
                    str1[i] = str1[i].Remove(0, 1);
                }
                else
                {
                    str1[i] = str1[i].Replace(str1[i], "");
                }
            }
            for (int i = 0; i < str1.Length - 1; i++)
            {

                Результат.Items.Add(str1[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str3 =textBox4.Text;
            textBox5.Text=str3.ToUpper();
        }
    }
}
