using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul
{
    public partial class Form1 : Form
    {
        double total, two;
        string op;
        bool oppress = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "0";
            oppress = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "1";
            oppress = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "2";
            oppress = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "3";
            oppress = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "4";
            oppress = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "5";
            oppress = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "6";
            oppress = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "7";
            oppress = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "8";
            oppress = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (oppress == true)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "9";
            oppress = false;
        }

        // Additopn Function
        private void Addition_Click(object sender, EventArgs e)
        {
            if (oppress == false)
            {
                total = Convert.ToDouble(textBox1.Text) + total;
                textBox1.Text = Convert.ToString(total);
                op = "+";
                oppress = true;
            } 
        }

        // Subtraction Function
        private void Sub_Click(object sender, EventArgs e)
        {
            if (oppress == false)
            {
                if (total == 0)
                {
                    total = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    Equal_Click();
                }
                textBox1.Text = Convert.ToString(total);
                op = "-";
                oppress = true;
            }
        }

        // Multiplication Function
        private void multiply(object sender, EventArgs e)
        {
            if (oppress == false)
            {
                if (total == 0)
                {
                    total = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    Equal_Click();
                }
                textBox1.Text = Convert.ToString(total);
                op = "*";
                oppress = true;
            }
        }

        //Division Function
        private void Divide_Click(object sender, EventArgs e)
        {
            if (oppress == false)
            {
                if (total == 0)
                {
                    total = Convert.ToDouble(textBox1.Text);

                }
                else
                {
                    Equal_Click();
                }
            }
            textBox1.Text = Convert.ToString(total);
            op = "/";
            oppress = true;
        }

        // Equals Function
        private void equals(object sender, EventArgs e)
        {
            two = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case "+":
                    textBox1.Text = Convert.ToString(total + two);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(total - two);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(total * two);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(total / two);
                    break;
            }
        }
        private void Equal_Click()
        {
            switch (op)
            {
                case "+":
                    total = Convert.ToDouble(textBox1.Text) + total;
                    break;
                case "-":
                    total = Convert.ToDouble(textBox1.Text) - total;
                    break;
                case "*":
                    total = Convert.ToDouble(textBox1.Text) * total;
                    break;
                case "/":
                    total = Convert.ToDouble(textBox1.Text) / total;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // Button Images Change On Click
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = calcul.Properties.Resources._11;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = calcul.Properties.Resources.Untitled_2;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = calcul.Properties.Resources._22;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = calcul.Properties.Resources._2;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = calcul.Properties.Resources._33;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = calcul.Properties.Resources._3;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = calcul.Properties.Resources._44;
        }
        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = calcul.Properties.Resources._4;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = calcul.Properties.Resources._55;
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = calcul.Properties.Resources._5;
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = calcul.Properties.Resources._66;
        }
        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = calcul.Properties.Resources._6;
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            button7.BackgroundImage = calcul.Properties.Resources._77;
        }
        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            button7.BackgroundImage = calcul.Properties.Resources._7;
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            button8.BackgroundImage = calcul.Properties.Resources._88;
        }
        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            button8.BackgroundImage = calcul.Properties.Resources._8;
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            button9.BackgroundImage = calcul.Properties.Resources._99;
        }
        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            button9.BackgroundImage = calcul.Properties.Resources._9;
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            button10.BackgroundImage = calcul.Properties.Resources._00;
        }
        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            button10.BackgroundImage = calcul.Properties.Resources._0;
        }

        private void multiply_MouseDown(object sender, MouseEventArgs e)
        {
            multiply_button.BackgroundImage = calcul.Properties.Resources.multiply1;
        }

        private void multiply_MouseUp(object sender, MouseEventArgs e)
        {
            multiply_button.BackgroundImage = calcul.Properties.Resources.multiply;
        } 

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            button14.BackgroundImage = calcul.Properties.Resources.divide1;
        }

        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            button14.BackgroundImage = calcul.Properties.Resources.divide;
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button12.BackgroundImage = calcul.Properties.Resources.minus1;
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            button12.BackgroundImage = calcul.Properties.Resources.minus;
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            button11.BackgroundImage = calcul.Properties.Resources.plus1;
        }

        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            button11.BackgroundImage = calcul.Properties.Resources.plus;
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            button16.BackgroundImage = calcul.Properties.Resources.C0;
        }

        private void button16_MouseUp(object sender, MouseEventArgs e)
        {
            button16.BackgroundImage = calcul.Properties.Resources.C;
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            button15.BackgroundImage = calcul.Properties.Resources.equals1;
        }

        private void button15_MouseUp(object sender, MouseEventArgs e)
        {
            button15.BackgroundImage = calcul.Properties.Resources.equals;
        }

        private void ON_Click(object sender, EventArgs e)
        {
            total = 0;
            two = 0;
            textBox1.Clear();
        }
    }
}

