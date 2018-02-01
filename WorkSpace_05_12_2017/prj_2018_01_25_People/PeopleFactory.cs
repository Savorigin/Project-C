using System;

namespace People
{
    class PeopleFactory
    {
        private Random r;
        public PeopleFactory()
        {
            r = new Random();
        }
        public Human NextHuman()
        {
            return Get(r.Next(0, 3));
        }
        public Human Get(int n)
        {
            switch (n)
            {
                /*case 0: return new Student("Vasya", 1);
                case 1: return new Doctor("Aybolit", 66);
                case 2: return new Fighter("Bruce Lee", 100);*/
                case 0: return new Student();
                case 1: return new Doctor();
                case 2: return new Fighter();
                default: return null;
            }
        }
    }
}
