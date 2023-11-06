using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_Framework
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x= textBox1.Text;
            string y = textBox2.Text;
            string z = textBox3.Text;
            double x1=Convert.ToDouble(x);
            double y1=Convert.ToDouble(y);
            double z1=Convert.ToDouble(z);
            double A1 = x1 * x1 / (8 + ((x1 * x1) / 3) + (y1 * y1) / 6);
            double B1 = x1 * (Math.Pow(Math.Cos(x1 + z1), 3) + 1);
            textBox4.Text = A1.ToString();
            textBox5.Text = B1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
