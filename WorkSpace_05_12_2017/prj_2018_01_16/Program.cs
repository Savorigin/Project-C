using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse jery = new Mouse("JerikoFF", 2.0, 5);
            jery.print();
            jery.eat(0.7);
            jery.print();

            Mouse micky = new Mouse("MickyMouse", 1.5, 3);
            micky.print();

            Mouse mouse1 = new Mouse();
            mouse1.print();

            Cat tom = new Cat("Tomidze", 7.0);
            tom.eat(1.5);
            tom.print();

            Console.WriteLine("Eating -------------------------");
            tom.eat(jery);
            tom.eat(micky);
            tom.eat(mouse1);
            tom.print();
            jery.print();
            micky.print();
            mouse1.print();
        }
    }
}
