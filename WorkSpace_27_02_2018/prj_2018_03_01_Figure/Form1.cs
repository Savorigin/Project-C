using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_2018_02_27_01;

namespace prj_2018_03_01_Figure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorPoint[] masColorPoint = new ColorPoint[5];
            masColorPoint[0] = new ColorPoint(200, 100, "Green");
            masColorPoint[1] = new ColorPoint(300, 200, "Blue");
            masColorPoint[2] = new ColorPoint(200, 300, "Red");
            masColorPoint[3] = new ColorPoint(100, 100, "Black");
            masColorPoint[4] = new ColorPoint(200, 200, "Aqua");
            Graphics g = panel1.CreateGraphics();
            foreach (var item in masColorPoint)
            {
                Pen p = new Pen(Color.FromName(item.Color), 5);
                g.DrawEllipse(p, item.X, item.Y, 200, 100);
            }
        }
    }
}
