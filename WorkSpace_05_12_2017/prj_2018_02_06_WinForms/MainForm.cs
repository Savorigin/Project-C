using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_2018_02_06_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxOk.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                //Thread.Sleep(100);
            }
            try
            {
                int value = int.Parse(textBoxOk.Text);
                textBoxOk.Text = (value + 2).ToString();
                textBoxOk.ForeColor = Color.Green;
                /*Point b = buttonOk.Location;
                buttonOk.Location = new Point(b.X + 10, b.Y + 10);*/
                textBoxOk2.Text = textBoxOk2.Text + textBoxOk.Text;
                textBoxOk2.Text = textBoxOk2.Text + "/n";
            }
            catch (Exception)
            {
                textBoxOk.Text = "Error";
                textBoxOk.ForeColor = Color.Red;
            }
        }

        private void buttonOk_Enter(object sender, EventArgs e)
        {
            /*Point b = buttonOk.Location;
            buttonOk.Location = new Point(b.X + 10, b.Y + 10);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
