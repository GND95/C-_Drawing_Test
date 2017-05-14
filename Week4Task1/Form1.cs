using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int second = 0;
        System.Drawing.Graphics g;
        Pen black = new Pen(Color.Black, 5f);

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = second + 1;

            if (second == 1)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawEllipse(black, 235, 50, 100, 100); //head
            }
            else if (second == 2)
            {
                g.DrawLine(black, 265f, 145f, 245f, 250f); // body
            }
            else if (second == 3)
            {
                g.DrawLine(black, 200f, 125f, 255f, 200f); // arm
            }
            else if (second == 4)
            {
                g.DrawLine(black, 450f, 100f, 255f, 200f); // arm
            }
            else if (second == 5)
            {
                g.DrawLine(black, 100f, 375f, 245f, 250); //left leg
            }
            else if (second == 6)
            {
                g.DrawLine(black, 800f, 800f, 245f, 250); //right leg
            }
            else if (second >= 7)
            {
                timer1.Stop();
                MessageBox.Show("\"Hello World,\" Whispers Bob","Finished");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            timer1.Interval = 1000;
            timer1.Start();
            button1.Enabled = false; 
        }
    }
}
