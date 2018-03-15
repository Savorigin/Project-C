using System;
using System.IO;

namespace RailWay
{
    public class TrainFactory
    {
        public TrainFactory()
        {

        }
        public Vagon GetNextVagon()
        {
            Random r = new Random();
            return GetVagon(r.Next(0, 2));
        }
        public IStackVagon GetRandStackVagon(int n)
        {
            IStackVagon stackVagon = new StackVagon1();
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                stackVagon.Push(GetVagon(r.Next(0, 2)));
            }
            return stackVagon;
        }
        public IStackVagon GetStackVagonFromFile(string fileName)
        {
            IStackVagon stackVagon = new StackVagon1();
            StreamReader sr = new StreamReader(fileName);
            string strVagons = sr.ReadToEnd();
            string[] masStrVagonType = strVagons.Split(';');
            for (int i = 0; i < masStrVagonType.Length; i++)
            {
                stackVagon.Push(new Vagon { Type = int.Parse(masStrVagonType[i]) });
            }
            return stackVagon;
        }
        public Vagon GetVagon(int n)
        {
            switch (n)
            {
                case 0: return new Vagon { Type = 0 };
                case 1: return new Vagon { Type = 1 };
                case 2:
                    {
                        Console.WriteLine("Enter type {0, 1}");
                        int value = int.Parse(Console.ReadLine());
                        return new Vagon { Type = value };
                    }
                default: throw new ArgumentException();
            }
        }
    }
}
