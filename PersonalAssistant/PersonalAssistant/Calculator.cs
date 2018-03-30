using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class Calculator : Form
    {
        private double x, y, z;
        char? C = null;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            C = '*';
            textBox1.Text = null;
            textBox2.Text += Convert.ToString(x);
            textBox2.Text += Convert.ToString(C);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            C = '/';
            textBox1.Text = null;
            textBox2.Text += Convert.ToString(x);
            textBox2.Text += Convert.ToString(C);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            C = '+';
            textBox1.Text = null;
            textBox2.Text += Convert.ToString(x);
            textBox2.Text += Convert.ToString(C);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            C = '-';
            textBox1.Text = null;
            textBox2.Text += Convert.ToString(x);
            textBox2.Text += Convert.ToString(C);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (C == '+')
            {
                textBox1.Text = Convert.ToString(x + y);
                textBox2.Text += Convert.ToString(y);
                textBox2.Text += Convert.ToString('=');
            }
            if (C == '-')
            {
                textBox1.Text = Convert.ToString(x - y);
                textBox2.Text += Convert.ToString(y);
                textBox2.Text += Convert.ToString('=');
            }
            if (C == '*')
            {
                textBox1.Text = Convert.ToString(x * y);
                textBox2.Text += Convert.ToString(y);
                textBox2.Text += Convert.ToString('=');
            }
            if (C == '/')
            {
                textBox1.Text = Convert.ToString(x / y);
                textBox2.Text += Convert.ToString(y);
                textBox2.Text += Convert.ToString('=');
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            
                textBox1.Text = Convert.ToString((x * y)/100);
                textBox2.Text += Convert.ToString(y);
                textBox2.Text += Convert.ToString('%');
                //textBox2.Text += Convert.ToString('=');
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
