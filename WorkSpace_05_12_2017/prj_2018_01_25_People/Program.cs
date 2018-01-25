using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Human stud1 = new Student("Vasya", 1);
            Console.WriteLine(stud1);
            stud1.Eat();
            //stud1.Study();

            Human doc1 = new Doctor("Aybolit", 66);
            Console.WriteLine(doc1);
            doc1.Eat();
            //doc1.Cure();

            Human fight1 = new Fighter("Bruce Lee", 100);
            Console.WriteLine(fight1);
            fight1.Eat();
            //fight1.Fight();

            Human[] masHuman = new Human[3];
            masHuman[0] = stud1;
            masHuman[1] = doc1;
            masHuman[2] = fight1;

            for (int i = 0; i < masHuman.Length; i++)
            {
                Console.WriteLine(masHuman[i]);
            }
        }
    }
}
