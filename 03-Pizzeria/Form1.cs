using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Pizzeria
{
    public partial class Form1 : Form
    {
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void smallOrder_CheckedChanged(object sender, EventArgs e)
        {
                                
            if (listBox1.Items.Contains("Large"))
            {
                listBox1.Items.Remove("Large");
                total -= 10;
            }

            
            if (!listBox1.Items.Contains("Small"))
            {
                listBox1.Items.Insert(0, "Small");
                total += 5;
            }
            
            richTextBox1.Text = total.ToString("C2");

        }

        private void largeOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Small"))
            {
                listBox1.Items.Remove("Small");
                total -= 5;
            }

            if (!listBox1.Items.Contains("Large"))
            {
                listBox1.Items.Insert(0, "Large");
                total += 10;
            }
           
            richTextBox1.Text = total.ToString("C2");
        }

        private void orderButton_Click(object sender, EventArgs e)
        {

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please Select a Size!");
            }
            else
            {
                MessageBox.Show("Thank you for Ordering from Ngatai's Pizzeria!");
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }
                }
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)control;
                        radioButton.Checked = false;
                    }
                }

                listBox1.Items.Clear();
                richTextBox1.Clear();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }

            listBox1.Items.Clear();
            richTextBox1.Clear();
            total = 0;

        }

        private void sauce_CheckedChanged(object sender, EventArgs e)
        {


            if (!checkBox1.Checked)
            {
                listBox1.Items.Remove("Peri-Peri Sauce");
                total -= 0.5;
            }
            else
            {
                listBox1.Items.Add("Peri-Peri Sauce");
                total += 0.5;
            }
            richTextBox1.Text = total.ToString("C2");

        }

        private void cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                listBox1.Items.Remove("Extra Cheese");
                total -= 1.50;
            }
            else
            {
                listBox1.Items.Add("Extra Cheese");
                total += 1.50;
            }
            richTextBox1.Text = total.ToString("C2");
        }
        private void mushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                listBox1.Items.Remove("Mushrooms");
                total -= 1.00;
            }
            else
            {
                listBox1.Items.Add("Mushrooms");
                total += 1.00;
            }
            richTextBox1.Text = total.ToString("C2");
        }

        private void stuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                listBox1.Items.Remove("Stuffed Crust");
                total -= 5.00;
            }
            else
            {
                listBox1.Items.Add("Stuffed Crust");
                total += 5.00;
            }
            richTextBox1.Text = total.ToString("C2");
        }

        private void onion_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.Checked)
            {
                listBox1.Items.Remove("Onions");
                total -= 0.75;
            }
            else
            {
                listBox1.Items.Add("Onions");
                total += 0.75;
            }
            richTextBox1.Text = total.ToString("C2");
        }

        private void sauce_ChecStateChanged(object sender, EventArgs e)
        {

        }
    }
}
