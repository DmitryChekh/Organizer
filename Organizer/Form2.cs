using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool sign = true;
        bool resInBox = false;
        private void button_0_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 0;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (resInBox)
            {
                a = 0;
                textBox1.Text = "";
                label1.Text = "";
                resInBox = false;
            }
            textBox1.Text = textBox1.Text + 9;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            resInBox = false;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            sign = true;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            resInBox = false;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            sign = true;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            resInBox = false;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "x";
            sign = true;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            resInBox = false;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        private void button_equall_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
            resInBox = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    a = b;
                    break;
                default:
                    break;
            }
        }

        private void button_С_Click(object sender, EventArgs e)
        {
            a = 0;
            textBox1.Text = "";
            label1.Text = "";
            resInBox = false;
        }

        private void button_erase_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button_PlusMinus_Click(object sender, EventArgs e)
        {
            resInBox = false;
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if(sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void button_fract_Click(object sender, EventArgs e)
        {
            resInBox = false;
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
