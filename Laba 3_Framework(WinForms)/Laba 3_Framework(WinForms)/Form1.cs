using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3_Framework_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Factorial(int i)
        {
            double res = 1;
            for(int j = 1; j < i; j++)
            {
                res*= j;
            }
            return res;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string eps = textBox1.Text;
            double eps1;
            double res=0;
            int i = 1;
            try
            {
                eps1=Convert.ToDouble(eps);
                if (eps1 <= 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    
                }
                else
                {
                    while(true) 
                    {
                        if (1 / (Math.Sqrt(Factorial(i))) < eps1)
                        {
                            textBox2.Text = res.ToString();
                            break;
                        }
                        else
                        {
                            res += 1 / (Math.Sqrt(Factorial(i)));
                            i += 1;
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                textBox1.Text = "";
                textBox2.Text = "";
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double res = 0;
            for (int i = -3; i < 4; i++)
            {
                res += -2 + Math.Sqrt(2 * (i + 1) * (i + 1) * (5 - i));
            }
            textBox3.Text= res.ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value;
            int kol=0;
            try 
            { 
                int x=Convert.ToInt32(textBox4.Text);
                value = textBox4.Text;

                for(int i = 0; i < value.Length-1; i++)
                {
                    if (value[i] > value[value.Length - 2])
                    {
                        kol += 1;
                    }
                }
                textBox5.Text= kol.ToString();
            }
            catch (Exception ex) 
            {   
                textBox4.Text = "";
                textBox5.Text = "";
                Console.WriteLine("{0} Exception caught.", ex);
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int res = 0;
            int degree;
            int var;
            try
            {
                int N=Convert.ToInt32(textBox6.Text);
                degree = N;
                for(int i = 1; i < N+1; i++)
                {
                    var=Convert.ToInt32(Math.Pow(i, degree));//Почему то без конвёрта ругается
                    res += var;
                    degree=degree - 1;
                }
                textBox7.Text= res.ToString();   
            }
            catch (Exception ex) 
            {
                textBox6.Text = "";
                textBox7.Text = "";
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
    }
}
