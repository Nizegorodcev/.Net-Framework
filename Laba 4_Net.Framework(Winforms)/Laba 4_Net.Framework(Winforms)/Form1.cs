using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_4_Net.Framework_Winforms_
{
    struct teacher
    {
        public string name;
        public string surname;
        public string middle_name;//отчество
        public string Objects;//Предмет
        public string universitet;
        public string faculty;
    }
    public partial class Form1 : Form
    {
        private List<teacher[]> teacherList;
        public Form1()
        {
            InitializeComponent();
            teacherList = new List<teacher[]>();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //teacherList.Add(new teacher[](textBox6.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher[] Teacher = new teacher[]
            {
                new teacher
                {
                    name = textBox6.Text,
                    surname = textBox1.Text,
                    middle_name = textBox2.Text,
                    Objects = textBox3.Text,
                    universitet = textBox4.Text,
                    faculty=textBox5.Text
                }
            };
            teacherList.Add(Teacher);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox5.Clear();
            textBox6.Clear();
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var Teacher in teacherList)
            {
                foreach (var Tr in Teacher)
                {
                    dataGridView1.Rows.Add(Tr.name,Tr.surname,Tr.middle_name,Tr.Objects,Tr.universitet,Tr.faculty);
                }
            }
        }
    }
}
