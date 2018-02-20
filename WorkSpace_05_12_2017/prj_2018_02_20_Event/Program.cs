using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_20_Event
{
    //delegate int Sum(int x, int y);
    delegate void InfoDelegate(News news);
    class City
    {
        public event InfoDelegate mediaInfo;
        public void OnPrint(News news)
        {
            if (mediaInfo != null) mediaInfo(news);
        }
    }
    class News
    {
        public string Info { get; set; }
        public override string ToString()
        {
            return Info;
        }
    }
    class TV
    {
        public static void GetInfo(News news) { Console.WriteLine("TV : " + news); }
    }
    class Radio
    {
        public static void GetInfo(News news) { Console.WriteLine("Radio : " + news); }
    }
    class NewsPaper
    {
        public static void GetInfo(News news) { Console.WriteLine("NewsPaper : " + news); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sum sum = (x, y) =>  x + y;
            City Kiev = new City();
            City Lviv = new City();
            City Odessa = new City();

            Kiev.mediaInfo += TV.GetInfo;
            Kiev.mediaInfo += Radio.GetInfo;
            Lviv.mediaInfo += TV.GetInfo;
            Lviv.mediaInfo += Radio.GetInfo;
            Lviv.mediaInfo += NewsPaper.GetInfo;

            for (int i = 0; i < 10; i++)
            {
                Kiev.OnPrint(new News { Info = "Kiev Weather Cold " + i });
                Lviv.OnPrint(new News { Info = "Lviv Weather Cool " + i });
            }
        }
    }
}
