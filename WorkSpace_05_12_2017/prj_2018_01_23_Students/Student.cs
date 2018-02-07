using System;

namespace Univer
{
    public class Student
    {
        public class TypeMarks
        {
            private int[] marks;
            public int Length { get { return marks.Length; } }
            public double Average
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < marks.Length; i++)
                    {
                        sum += marks[i];
                    }
                    return sum / marks.Length;
                }
            }
            public TypeMarks(int numMarks)
            {
                marks = new int[numMarks];
            }
            public int this[int i]
            {
                set { marks[i] = value; }
                get { return marks[i]; }
            }
        }
        public string Name { get; set; }
        public int NumGroup { get; set; }
        public TypeMarks Marks { get; set; }
        /*private int[] marks;
        public int this[int i]
        {
            set { marks[i] = value; }
            get { return marks[i]; }
        }*/
        public void SetMark(int i, int mark)
        {
            Marks[i] = mark;
        }
        public int GetMark(int i)
        {
            return Marks[i];
        }
        public Student()
        {
            Console.WriteLine("Enter Student");
            Console.WriteLine("Name");
            Name = Console.ReadLine();
            Console.WriteLine("NumGroup");
            NumGroup = int.Parse(Console.ReadLine());
            Console.WriteLine("NumMarks");
            int numMarks = int.Parse(Console.ReadLine());
            Marks = new TypeMarks(numMarks);
        }
        public Student(string name, int numGroup, int numMarks)
        {
            Name = name;
            NumGroup = numGroup;
            Marks = new TypeMarks(numMarks);
        }
        public void Sesiya()
        {
            Random r = new Random();
            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = r.Next(2, 6);
            }
        }
        public double Average()
        {
            return Marks.Average;
        }
        public void print()
        {
            string marksStr = "Marks [";
            for (int i = 0; i < Marks.Length; i++)
            {
                marksStr += Marks[i].ToString();
                if (i < Marks.Length - 1) marksStr += ",";
                else marksStr += "]";
            }
            Console.WriteLine($"{Name}, {NumGroup}, {marksStr}");
        }
        public override string ToString()
        {
            return Name + ", " + NumGroup + ", " + Marks.Length;
        }
    }
}
