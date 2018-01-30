using System;

namespace People
{
    class Doctor : Human
    {
        public int IdLicense { get; set; }
        public Doctor() : base()
        {
            Console.WriteLine("Enter IdLicense");
            IdLicense = int.Parse(Console.ReadLine());
        }
        public Doctor(string name, int idLicense): base(name)
        {
            IdLicense = idLicense;
        }
        public void Cure()
        {
            Console.WriteLine("Curing...");
        }
        public override void print()
        {
            //Console.WriteLine("Doctor " + Name);
            Console.WriteLine(this);
        }
    }
}
