using System;

namespace prj_2018_03_06_Duck
{
    abstract class Duck
    {
        public IFly FlyBehavior { get; set; }
        public IQuack QuackBehavior { get; set; }
        public void PerformFly() { FlyBehavior.Fly(); }
        public void PerformQuack() { QuackBehavior.Quack(); }
    }

    public interface IQuack
    {
        void Quack();
    }

    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Silent");
        }
    }

    public class ForteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Forte quack");
        }
    }

    public interface IFly
    {
        void Fly();
    }

    public class FlyByWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Fly by wings");
        }
    }
    public class NotFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Not fly");
        }
    }

    class RegularDuck : Duck
    {
        public RegularDuck()
        {
            FlyBehavior = new FlyByWings();
            QuackBehavior = new MuteQuack();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Duck regularDuck = new RegularDuck();
            regularDuck.PerformFly();
            regularDuck.PerformQuack();
            regularDuck.FlyBehavior = new NotFly();
            regularDuck.PerformFly();
            regularDuck.PerformQuack();
        }
    }
}
