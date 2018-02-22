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

namespace prj_2018_02_22_Form
{
    public partial class FormMain : Form
    {
        FormNews formTV;
        FormNews formRadio;
        FormNews formPaper;

        public FormMain()
        {
            InitializeComponent();
            formTV = new FormNews("formTV");
            formRadio = new FormNews("formRadio");
            formPaper = new FormNews("formPaper");

            formTV.Show();
            formRadio.Show();
            formPaper.Show();
        }
        private void GenerateNews(object obj)
        {
            CityEventNews city = obj as CityEventNews;
            if (city != null)
            {
            for (int i = 0; i < 20; i++)
            {
                city.OnUpdate(new News { Info = "Cold" });
                Thread.Sleep(200);
            }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CityEventNews kiev = new CityEventNews();

            kiev.media += formTV.Update;
            kiev.media += formRadio.Update;
            kiev.media += formPaper.Update;

            //new Thread(GenerateNews).Start(kiev);
            new Thread(() => 
            {
                if (kiev != null)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        kiev.OnUpdate(new News { Info = "Cold" });
                        Thread.Sleep(200);
                    }
                }
            }).Start(kiev);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CityEventNews lviv = new CityEventNews();

            lviv.media += formTV.Update;
            lviv.media += formRadio.Update;

            //new Thread(GenerateNews).Start(lviv);
            new Thread(() => GenerateNews(lviv)).Start();
        }
    }
}
