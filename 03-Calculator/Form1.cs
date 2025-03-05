using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double total;

            if(double.TryParse(richTextBox1.Text, out num1) && (double.TryParse(richTextBox2.Text, out num2)))
            {
                total = num1 + num2;

                richTextBox3.Text = total.ToString();
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double total;

            if (double.TryParse(richTextBox1.Text, out num1) && (double.TryParse(richTextBox2.Text, out num2)))
            {
                total = num1 - num2;

                richTextBox3.Text = total.ToString();
            }
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double total;

            if (double.TryParse(richTextBox1.Text, out num1) && (double.TryParse(richTextBox2.Text, out num2)))
            {
                total = num1 * num2;

                richTextBox3.Text = total.ToString();
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double total;

            if (double.TryParse(richTextBox1.Text, out num1) && (double.TryParse(richTextBox2.Text, out num2)))
            {
                total = num1 / num2;

                richTextBox3.Text = total.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
        }
    }
}
