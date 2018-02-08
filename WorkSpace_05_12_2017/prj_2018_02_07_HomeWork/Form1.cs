using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prj_2018_02_07_HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(one);
            a.Start();
        }

        void one()
        {
            Graphics g = this.CreateGraphics();
            Pen a = new Pen(Color.Red, 6);
            g.DrawRectangle(a, 100, 100, 50, 100);

            Point[] polygon =
            {
                new Point(200, 250),
                new Point(250, 220),
                new Point(270, 270),
                new Point(200, 300),
                new Point(200, 250),
            };

            Pen b = new Pen(Color.Green, 3);
            Pen c = new Pen(Color.Blue, 5);
            g.DrawEllipse(b, 200, 100, 200, 100);
            g.DrawPolygon(c, polygon);

            int step = 0;
            for (int i = 0; i < 20; i++)
            {
                step += 10;
                g.DrawEllipse(a, 50 + step, 100, 100, 100);
                Thread.Sleep(100);
                g.DrawEllipse(b, 50 + step, 100, 100, 100);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            two();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            two();
        }

        void two()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen a = new Pen(Color.Blue, 1);
            Pen b = new Pen(Color.Green, 2);
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int sizeWidth = Form1.ActiveForm.Width;
            int sizeHeight = Form1.ActiveForm.Height;
            Point center = new Point(((int)(sizeWidth / 2) - 8), ((int)(sizeHeight / 2) - 19));

            g.DrawLine(a, 10, center.Y, center.X, center.Y);
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y);
            g.DrawLine(a, center.X, 10, center.X, center.Y);
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10);
            g.DrawString("X", drawFont, drawBrush, new Point(2 * center.X - 30, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrush, new Point(center.X + 30, 5), drawFormat);

            g.DrawLine(a, center.X, 10, center.X + 5, 20);
            g.DrawLine(a, center.X, 10, center.X - 5, 20);
        }
    }
}
