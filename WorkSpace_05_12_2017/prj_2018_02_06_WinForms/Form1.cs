using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Univer;

namespace prj_2018_02_06_WinForms
{
    public partial class Form1 : Form
    {
        public int Current { get; set; }
        public Student Stud { get; set; }
        public Student[] group;
        public int Count { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Count = -1;
            Stud = new Student("Vasya", 2, 4);
            group = new Student[5];
            group[++Count] = Stud;
            Current = Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName.Text = Stud.Name;
            textBoxGroup.Text = Stud.NumGroup.ToString();
            textBoxNumMarks.Text = Stud.Marks.Length.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            int NumGroup = int.Parse(textBoxGroup.Text);
            int NumMarks = int.Parse(textBoxNumMarks.Text);
            Stud = new Student(Name, NumGroup, NumMarks);
            group[++Count] = Stud;
            Current = Count;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (Current <= 0) return;
            Stud = group[--Current];
            textBoxName.Text = Stud.Name;
            textBoxGroup.Text = Stud.NumGroup.ToString();
            textBoxNumMarks.Text = Stud.Marks.Length.ToString();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (Current >= Count) return;
            Stud = group[++Current];
            textBoxName.Text = Stud.Name;
            textBoxGroup.Text = Stud.NumGroup.ToString();
            textBoxNumMarks.Text = Stud.Marks.Length.ToString();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            textBoxLog.AppendText("Log date: " + DateTime.Now + "\n");
            for (int i = 0; i < group.Length; i++)
            {
                textBoxLog.AppendText(group[i].ToString());
            }
        }
    }
}
