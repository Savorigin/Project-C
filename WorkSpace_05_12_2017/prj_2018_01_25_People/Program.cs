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
    class Program
    {
        static void Main(string[] args)
        {
            Human stud1 = new Student("Vasya", 1);
            Human doc1 = new Doctor("Aybolit", 66);
            Human fight1 = new Fighter("Bruce Lee", 100);

            /*Console.WriteLine(stud1);
            stud1.Eat();
            //stud1.Study();
                        
            Console.WriteLine(doc1);
            doc1.Eat();
            //doc1.Cure();
                        
            Console.WriteLine(fight1);
            fight1.Eat();
            //fight1.Fight();*/

            //PeopleFactory pf = new PeopleFactory();

            Human[] masHuman = new Human[5];
            /*for (int i = 0; i < masHuman.Length; i++)
            {
                masHuman[i] = pf.NextHuman();
            }*/

            masHuman[0] = stud1;
            masHuman[1] = doc1;
            masHuman[2] = fight1;
            masHuman[3] = new VetDoctor("House", 666, "Cat");
            masHuman[4] = new Doctor("Semenov", 33);

            int iDoc = -1;
            Doctor[] masDoc = new Doctor[5];
            for (int i = 0; i < masHuman.Length; i++)
            {
                if (masHuman[i] is Doctor)
                {
                    //Doctor doc = (Doctor)masHuman[i];
                    Doctor doc = masHuman[i] as Doctor;
                    Console.WriteLine(doc.IdLicense);
                    masDoc[++iDoc] = doc;
                }
                Doctor doc2 = masHuman[i] as Doctor;
                if (doc2 != null) Console.WriteLine(doc2.IdLicense);
                if (masHuman[i].GetType().Name == "Doctor")
                {
                    Console.WriteLine("doc.................");
                }
                //Console.WriteLine(masHuman[i]);
                masHuman[i].print();
            }
            Array.Resize(ref masDoc, iDoc + 1);
            Console.WriteLine(masDoc.Length);
            for (int i = 0; i < masDoc.Length; i++)
            {
                if (masDoc[i] == null) continue;
                Console.WriteLine(masDoc[i]);
            }
        }
    }
}
