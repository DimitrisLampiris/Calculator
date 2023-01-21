using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        int a,b,praksi,temp;
        bool allagipraksis=false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                b = int.Parse(textBox1.Text);
                if (praksi == 1)
                {
                    int c;
                    if (allagipraksis == false)
                    {
                        c = a + b;
                    }
                    else
                        c = temp + b;
                   textBox1.Text = c.ToString();
                    
                }
                else if (praksi == 2)
                {
                    int c;
                    if (allagipraksis==false)
                    {
                        c = a - b;
                    }
                    else
                        c = temp - b;
                    textBox1.Text = c.ToString();
                }
                else if (praksi == 3)
                {
                    int c;
                    if (allagipraksis==false)
                    {
                        c = a * b;
                    }
                    else
                        c = temp *b;
                    textBox1.Text = c.ToString();
                }
                else if (praksi == 4)
                {
                    float c, a1, b1;
                    if (allagipraksis == false)
                    {
                        a1 = float.Parse(a.ToString());
                        b1 = float.Parse(b.ToString());
                    }
                    else
                    {
                        a1 = float.Parse(temp.ToString());
                        b1 = float.Parse(b.ToString());
                    }
                     c = a1 / b1;
                    textBox1.Text = c.ToString();
                }
               
            }
            catch (System.FormatException) { }
            allagipraksis = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                allagipraksis = true;
                temp = a;
            }
            textBox1.Text = "";
            praksi = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                allagipraksis = true;
                temp = a;
            }
            textBox1.Text = "";
            praksi = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                allagipraksis = true;
                temp = a;
            }

          
            textBox1.Text = "";
            praksi = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            a = 0;
            b = 0;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use the calculator to solve the quiz!");
        }

        private void backspacebutton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            catch (System.ArgumentOutOfRangeException) { }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (System.FormatException)
            {
                allagipraksis = true;
                temp = a;
            }
            textBox1.Text = "";
            praksi = 1;
        }
    }
    
}
