using System;

namespace People
{
    class Student : Human, ISwim
    {
        public int NumGroup { get; set; }
        public Student() : base()
        {
            Console.WriteLine("Enter NumGroup");
            NumGroup = int.Parse(Console.ReadLine());
        }
        public Student(string name, int numGroup): base(name)
        {
           NumGroup = numGroup;
        }
        public void Study()
        {
            Console.WriteLine("Styding...");
        }
        public override void Eat()
        {
            Console.WriteLine("Student Eating...");
        }
        public override string ToString()
        {
            return $"Student {base.ToString()}, {NumGroup}";
        }
        public override void print()
        {
            Console.WriteLine("Student " + Name);
        }
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
