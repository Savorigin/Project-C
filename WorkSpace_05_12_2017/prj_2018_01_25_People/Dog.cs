using System;

namespace People
{
    class Dog : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
        public int CompareTo(Object obj)
        {
            return 1;
        }
    }
}
