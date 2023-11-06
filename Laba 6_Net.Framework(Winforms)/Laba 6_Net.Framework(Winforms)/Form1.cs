using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_6_Net.Framework_Winforms_
{
    public partial class Form1 : Form
    {
        SortedList<int, cargo_plane> planes;
        public class cargo_plane
        {
            public string model;
            public float load_capability;
            public float Volume;
            public void Print()
            {
                //Console.WriteLine("Модель: " + model);
                //Console.WriteLine("Грузоподъёмность: " + load_capability);
                //Console.WriteLine("Объём: " + Volume);
            }
        }
        public Form1()
        {
            InitializeComponent();
            planes = new SortedList<int,cargo_plane>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cargo_plane a = new cargo_plane();

            int kol = 0;
            try
            {
                a.model = textBox1.Text;
                a.load_capability = (float)Convert.ToDouble(textBox2.Text);
                a.Volume = (float)Convert.ToDouble(textBox3.Text);
                planes.Add(kol, a);
                kol++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                UpdateDataGridView();
            }
            catch(Exception ex)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                Console.WriteLine("{0} Exception caught.", ex);
            }


        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            for(int i = 0; i < planes.Count; i++)
            {
                dataGridView1.Rows.Add(planes[i].model, planes[i].load_capability, planes[i].Volume);
            }
        }
    }
}
