using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Formative_Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            double num1, num2, num3, num4, num5;
            double total;
            
            if((double.TryParse(textBox1.Text, out num1)  && (double.TryParse(textBox2.Text, out num2) && (double.TryParse(textBox3.Text, out num3) && (double.TryParse(textBox4.Text, out num4) && (double.TryParse(textBox5.Text, out num5)))))))
            {
                total = num1 + num2 + num3 + num4 + num5;
                
                textBox6.Text = total.ToString();
            }

            
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double num1, num2, num3, num4, num5;
            double average;

            if ((double.TryParse(textBox1.Text, out num1) && (double.TryParse(textBox2.Text, out num2) && (double.TryParse(textBox3.Text, out num3) && (double.TryParse(textBox4.Text, out num4) && (double.TryParse(textBox5.Text, out num5)))))))
            {
                average = (num1 + num2 + num3 + num4 + num5) / 5;

                textBox7.Text = average.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
    }
}
