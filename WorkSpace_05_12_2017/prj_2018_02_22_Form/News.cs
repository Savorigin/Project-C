namespace prj_2018_02_22_Form
{
    public class News
    {
        public string Info { get; set; }
        public override string ToString()
        {
            return Info;
        }
    }
    class TV
    {
        public static void GetInfo(News news) { /*Console.WriteLine("TV : " + news);*/ }
    }
    class Radio
    {
        public static void GetInfo(News news) { /*Console.WriteLine("Radio : " + news);*/ }
    }
    class NewsPaper
    {
        public static void GetInfo(News news) { /*Console.WriteLine("NewsPaper : " + news);*/ }
    }
}