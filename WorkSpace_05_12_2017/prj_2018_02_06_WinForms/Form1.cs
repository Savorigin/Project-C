using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Univer;

namespace prj_2018_02_06_WinForms
{
    public partial class Form1 : Form
    {
        public Student Stud { get; set; }
        public Student[] group;
        public int Count { get; set; }
        public int Current { get; set; }

        public Form1()
        {
            InitializeComponent();
            Count = -1;
            group = new Student[5];

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Stud = new Student("Vasya", 2, 4);
            //group[++Count] = Stud;
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
            for (int i = 0; i <= Count; i++)
            {
                textBoxLog.AppendText(group[i].ToString() + "\n");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            StreamReader f = new StreamReader(filename);
            string s = f.ReadLine();
            Count = int.Parse(s) - 1;
            Current = -1;
            group = new Student[Count + 1];
            while ((s=f.ReadLine()) != null)
            {
                if (Current < Count) group[++Current] = new Student(s);
            }
            f.Close();
            MessageBox.Show("Файл открыт");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            StreamWriter f = new StreamWriter(filename);
            f.WriteLine((Count+1).ToString());
            for (int i = 0; i < Count; i++)
            {
                f.WriteLine(group[i].ToString());
            }
            f.Flush();
            f.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mega programmer: Vladimir Savchenko");
        }
    }
}
