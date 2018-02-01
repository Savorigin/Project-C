using System;

namespace Vehicle
{
    sealed class VehicleFactory
    {
        private Random r;
        public VehicleFactory()
        {
            r = new Random();
        }
        public CVehicle NextVehicle()
        {
            return Get(r.Next(0, 3));
        }
        public CVehicle Get(int n)
        {
            switch (n)
            {
                case 0: return new CCar(13, 75, 12000, 200, 2015);
                case 1: return new CPlane(73, 15, 250000, 450, 2014, 2500);
                case 2: return new CShip(150, 275, 5000000, 50, 2000, 500, "Ukraine");
                default: return null;
            }
        }
    }
}
