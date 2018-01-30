using System;

namespace People
{
    class VetDoctor : Doctor
    {
        public string AnimalType { get; set; }
        public VetDoctor(string name, int idLicense, string animal) : base(name, idLicense)
        {
            AnimalType = animal;
        }
    }
}
