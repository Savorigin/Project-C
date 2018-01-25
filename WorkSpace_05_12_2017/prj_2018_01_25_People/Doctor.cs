using System;

namespace People
{
    class Doctor: Human
    {
        public int IdLicense { get; set; }
        public Doctor(string name, int idLicense): base(name)
        {
            IdLicense = idLicense;
        }
        public void Cure()
        {
            Console.WriteLine("Curing...");
        }
    }
}
