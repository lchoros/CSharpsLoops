using Nakov.TurtleGraphics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonHideTurtle.Text = "Show turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonHideTurtle.Text = "Hide turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
        }

        private void drawStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonDrawSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Green;
            int step = 10;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(step);
                Turtle.Rotate(60);
                step += 10;
            }
        }

        private void buttonDrawSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Red;
            Turtle.X = 100;
            Turtle.Y = -100;
            for (int i = 0; i < 18; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(10);
                Turtle.Backward(250);
                Turtle.Rotate(10);
            }
        }
    }
}
