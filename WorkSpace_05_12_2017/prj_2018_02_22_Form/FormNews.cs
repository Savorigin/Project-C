using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_2018_02_22_Form
{
    public partial class FormNews : Form
    {
        public FormNews(string name)
        {
            InitializeComponent();
            this.Text = name;
        }

        public void Update(News news)
        {
            textBox1.Text += news.Info;
        }

        private void FormNews_Load(object sender, EventArgs e)
        {

        }
    }
}
