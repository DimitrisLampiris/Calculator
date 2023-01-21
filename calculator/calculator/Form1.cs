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
    public partial class Form1 : Form
    {
        int[] prosth = new int[10];
        int[] aferesi = new int[10];
        int[] polap = new int[10];
        int[] dieresi = new int[10];
        arxik obj = new arxik();
        public Form1()
        {
            InitializeComponent();
        }
      
        string[] lathi = new string[25];
        int c = 0,pontoi=0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.message();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Random rdm = new Random();
            for (int i = 0; i < 10; i++)
            {
                prosth[i] = rdm.Next(1, 101);
                aferesi[i] = rdm.Next(1, 101);
                polap[i] = rdm.Next(1, 101);
                dieresi[i] = rdm.Next(1, 101);
            }
            count = 1;
            c = 0;
            obj.prostheteos1 = prosth[0];
            obj.prostheteos2 = prosth[1];
            obj.afereteos1 = aferesi[0];
            obj.afereteos2 = aferesi[1];
            obj.pol1 = polap[0];
            obj.pol2 = polap[1];
            obj.dier1 = dieresi[0];
            obj.dier2 = dieresi[1];
            label1.Text = obj.prostheteos1.ToString();
            label3.Text = obj.prostheteos2.ToString();
            label5.Text = obj.afereteos1.ToString();
            label7.Text = obj.afereteos2.ToString();
            label9.Text = obj.pol1.ToString();
            label11.Text = obj.pol2.ToString();
            label13.Text = obj.dier1.ToString();
            label15.Text = obj.dier2.ToString();
            second = 0;
            timer1.Enabled = true;
            numericUpDown1.ReadOnly = numericUpDown2.ReadOnly = numericUpDown3.ReadOnly = numericUpDown4.ReadOnly = false;
            c1 = c2 = c3 = c4 = false;
            button4.Enabled = true;
            n = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int apotel4 = 0, apotel1 = 0, apotel2 = 0, apotel3 = 0;
            next = true;
            label17.Text = second.ToString();
            if (numericUpDown1.Text != "")
            {
                apotel1 = int.Parse(numericUpDown1.Text);
                c1 = true;
            }
            else c1 = false;
            if (numericUpDown2.Text != "")
            {
                apotel2 = int.Parse(numericUpDown2.Text);
                c2 = true;
            }
            else c2 = false;
            if (numericUpDown3.Text != "")
            {
                apotel3 = int.Parse(numericUpDown3.Text);
                c3 = true;
            }
            else c3 = false;
            if (numericUpDown4.Text != "")
            {
                apotel4 = int.Parse(numericUpDown4.Text);
                c4 = true;
            }
            else c4 = false;



            if (apotel1 == obj.prostheteos1 + obj.prostheteos2 && c1)
            {
                pontoi += 5;
               


            }
            else
            {
                int sum1 = obj.prostheteos1 + obj.prostheteos2;
               lathi[c]=label1.Text+label2.Text+label3.Text +"=" + sum1.ToString();
                c++;
            }
            if (apotel2 == obj.afereteos1 - obj.afereteos2 && c2)
            {
                pontoi += 5;


            }
            else
            {
                int afer1 = obj.afereteos1 - obj.afereteos2;
                lathi[c] = label5.Text + label6.Text + label7.Text + "=" + afer1.ToString();
                c++;
            }
            if (apotel3 == obj.pol1 * obj.pol2 && c3)
            {
                pontoi += 5;


            }
            else
            {
                int pol = obj.pol1 * obj.pol2;
                lathi[c] = label9.Text + label10.Text + label11.Text + "=" + pol.ToString();
                c++;
            }

            if (apotel4 == obj.dier1 / obj.dier2 && c4)
            {
                pontoi += 5;


            }
            else
            {
                int dier = obj.dier1 / obj.dier2;
                lathi[c] = label13.Text + label14.Text + label15.Text + "=" + dier.ToString();
                c++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.message();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Random rdm = new Random();
            for (int i = 0; i < 10; i++)
            {
                prosth[i]= rdm.Next(1, 101);
                aferesi[i]= rdm.Next(1, 101);
                polap[i] = rdm.Next(1, 101);
                dieresi[i] = rdm.Next(1, 101);
            }
            count = 1;
            c = 0;
            obj.prostheteos1 = prosth[0];
            obj.prostheteos2 = prosth[1];
            obj.afereteos1 = aferesi[0];
            obj.afereteos2 = aferesi[1];
            obj.pol1 = polap[0];
            obj.pol2 = polap[1];
            obj.dier1 =dieresi[0];
            obj.dier2 = dieresi[1];
            label1.Text = obj.prostheteos1.ToString();
            label3.Text = obj.prostheteos2.ToString();
            label5.Text = obj.afereteos1.ToString();
            label7.Text = obj.afereteos2.ToString();
            label9.Text = obj.pol1.ToString();
            label11.Text = obj.pol2.ToString();
            label13.Text = obj.dier1.ToString();
            label15.Text = obj.dier2.ToString();
            second = 0;
            timer1.Enabled = true;
            numericUpDown1.ReadOnly = numericUpDown2.ReadOnly = numericUpDown3.ReadOnly = numericUpDown4.ReadOnly = false;
            c1 = c2 = c3 = c4=false;
            button4.Enabled = true;
            n = 2;
        }
        bool  c1, c2, c3, c4,next;
        int second =0,count=1,n=2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        

          
            second ++;
            label17.Text = second.ToString();
          
            if (count != 5) {
                if (next )
                {
                  
                    count++;
                    obj.prostheteos1 = prosth[n];
                    obj.prostheteos2 = prosth[n+1];
                    obj.afereteos1 = aferesi[n];
                    obj.afereteos2 = aferesi[n+1];
                    obj.pol1 = polap[n];
                    obj.pol2 = polap[n+1];
                    obj.dier1 = dieresi[n];
                    obj.dier2 = dieresi[n+1];
                    label1.Text = obj.prostheteos1.ToString();
                    label3.Text = obj.prostheteos2.ToString();
                    label5.Text = obj.afereteos1.ToString();
                    label7.Text = obj.afereteos2.ToString();
                    label9.Text = obj.pol1.ToString();
                    label11.Text = obj.pol2.ToString();
                    label13.Text = obj.dier1.ToString();
                    label15.Text = obj.dier2.ToString();
                    numericUpDown1.Text = numericUpDown2.Text = numericUpDown3.Text = numericUpDown4.Text = "0";
                    n += 2;
                    c1 = c2 = c3 = c4 = next=false;
                }

            }
            else
            {
                button4.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("TELOS PAIXNIDIOY pontoi: "+ pontoi.ToString());
                pontoi = 0;
                for(int i = 0; i < c; i++)
                {
                    MessageBox.Show(lathi[i].ToString());
                
                }
                c = 0;
               
                
                next = false;
            }
                if (second <= 120)
                {
                    label17.BackColor = Color.Green;


                }
                else if (second <= 150)
                {
                    label17.BackColor = Color.Orange;

                }
                else
                    label17.BackColor = Color.Red;

            if (second == 180)
                MessageBox.Show("TIME IS UP!!! You can still play thw quiz!");
            }
        }
    class info{
        public void message()
        {
            MessageBox.Show("Prospathise na liseis tous 5 girous praksewn mesa se 3 lepta.Ama xreiasteis boitheia xrisimopoise to calculator.Gia kathe sosti apantisi perneis 5 pontous");
        }
    }
    class arxik
    {
        public int prostheteos1, prostheteos2;
        public int afereteos1, afereteos2;
        public int pol1, pol2;
        public int dier1, dier2;
        public int score, lathoi;
    }




    }

