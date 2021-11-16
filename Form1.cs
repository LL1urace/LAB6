using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool LeftMove, UpMove;
        int speed = 0;
        Random rnd = new Random();
        int rcolor=1;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (speed == 0)
                speed = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (speed != 0)
                speed = Convert.ToInt32(numericUpDown1.Value);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            rcolor = rnd.Next(0, 3);
            if (rcolor == 1)
            {
                circle.Image = LAB6.Properties.Resources.circle2;
            }
            else if (rcolor == 2)
            {
                circle.Image = LAB6.Properties.Resources.circle3;
            }   
            else if (rcolor == 3)
            {
                circle.Image = LAB6.Properties.Resources.circle1;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LeftMove == true)
            {
                circle.Left += 2 * speed;
            }
            else
            {
                circle.Left -= 2 * speed;
            }
            if (UpMove == true)
            {
                circle.Top += 2 * speed;
            }
            else
            {
                circle.Top -= 2 * speed;
            }
            if (circle.Left - 5 <= richTextBox1.Left)
            {
                LeftMove = true;
            }
            if (circle.Left + 45 >= richTextBox1.Right)
            {
                LeftMove = false;
            }
            if (circle.Top - 5 <= richTextBox1.Top)
            {
                UpMove = true;
            }
            if (circle.Top + 45 >= richTextBox1.Bottom)
            {
                UpMove = false;
            }

        }
    }
}