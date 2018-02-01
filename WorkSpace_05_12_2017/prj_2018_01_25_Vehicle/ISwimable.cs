using System;

namespace Vehicle
{
    interface ISwimable
    {
        int Swim();
    }
    sealed class SwimableVehicle
    {
        private Random r;
        public SwimableVehicle()
        {
            r = new Random();
        }
        public ISwimable NextVehicle()
        {
            return Get(r.Next(0, 3));
        }
        public ISwimable Get(int n)
        {
            switch (n)
            {
                case 0: return new CCarAmfibia(13, 75, 12000, 200, 2015);
                case 1: return new CBatMobile(73, 15, 250000, 450, 2014);
                case 2: return new CShip(150, 275, 5000000, 50, 2000, 500, "Ukraine");
                default: return null;
            }
        }
    }
}
