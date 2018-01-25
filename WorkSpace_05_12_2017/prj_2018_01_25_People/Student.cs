using System;

namespace People
{
    class Student: Human
    {
        public int NumGroup { get; set; }
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
    }
}
