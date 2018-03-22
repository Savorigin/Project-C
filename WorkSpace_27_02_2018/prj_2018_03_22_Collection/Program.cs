using System;
using System.Collections.Generic;

namespace prj_2018_03_22_Collection
{
    class Program
    {
        class Word
        {
            public string Eng { get; set; }
            public string Rus { get; set; }
            public override string ToString()
            {
                return $"{Eng}, {Rus}";
            }
        }

        static void ExamleCollection()
        {
            Stack<Word> stackWord = new Stack<Word>();
            stackWord.Push(new Word { Eng = "apple", Rus = "яблоко" });
            stackWord.Push(new Word { Eng = "banana", Rus = "банан" });
            stackWord.Push(new Word { Eng = "ananas", Rus = "ананас" });

            foreach (var item in stackWord)
            {
                Console.WriteLine(item);
            }

            LinkedList<Word> listWord = new LinkedList<Word>(stackWord);
            foreach (var item in listWord)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            SortedList<string, string> sortWords = new SortedList<string, string>();
            foreach (var item in listWord)
            {
                sortWords.Add(item.Eng, item.Rus);
            }

            foreach (var item in sortWords)
            {
                Console.WriteLine(item);
            }

        }
        static void FregWordInStr(string str)
        {
            Dictionary<string, int> fregDic = new Dictionary<string, int>();
            //Dictionary<string, List<string>> fregDic = new Dictionary<string, List<string>>();
            string[] words = str.Split(' ');
            foreach (var item in words)
            {
                string[] elem = item.Split(":");
            }
            int count = -1;
            foreach (var item in words)
            {
                count++;
                if (!fregDic.ContainsKey(item))
                {
                    fregDic.Add(item, 1);
                }
                fregDic[item] += 1;
            }

            foreach (var list in fregDic)
            {
                Console.WriteLine(list);
            }
        }
        static void Main(string[] args)
        {
            string str = string.Empty;
            using (var webClient = new System.Net.WebClient())
            {
                str = webClient.DownloadString("https://stackoverflow.com/questions/3231969/download-file-from-url-to-a-string");
            }
            //string str = "Mama:MAMA mila:MMM ramy:RRR Mama:MAMA mila:MM ramy:RR Mama:mama";
            FregWordInStr(str);
        }
    }
}
