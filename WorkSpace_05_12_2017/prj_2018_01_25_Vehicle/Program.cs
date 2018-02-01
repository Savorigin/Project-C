using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vf = new VehicleFactory();

            CVehicle[] vehicle = new CVehicle[10];

            for (int i = 0; i < vehicle.Length; i++)
            {
                vehicle[i] = vf.NextVehicle();
            }

            for (int i = 0; i < vehicle.Length; i++)
            {
                vehicle[i].Print();
            }

            CVehicle maxPrice = null;

            int countCars = 0;
            int countPlanes = 0;
            int countShips = 0;

            CCar[] masCars = new CCar[10];
            CPlane[] masPlanes = new CPlane[10];
            CShip[] masShips = new CShip[10];

            int countVeh = 0;
            CVehicle[] masVeh = new CVehicle[10];

            for (int i = 0; i < vehicle.Length; i++)
            {
                if (vehicle[i].GetType().Name == "CCar")
                {
                    masCars[countCars++] = (CCar)vehicle[i];
                }
                else if(vehicle[i].GetType().Name == "CPlane")
                {
                    masPlanes[countPlanes++] = (CPlane)vehicle[i];
                }
                else if (vehicle[i].GetType().Name == "CShip")
                {
                    masShips[countShips++] = (CShip)vehicle[i];
                }
                if (vehicle[i].GetType().Name != "CPlane")
                {
                    if (maxPrice == null) maxPrice = vehicle[i];
                    else if (maxPrice.Price < vehicle[i].Price) maxPrice = vehicle[i];
                }
                if (vehicle[i].Year > 2000 && vehicle[i].Year < 2010)
                {
                    if (vehicle[i].GetType().Name == "CCar")
                    {
                        if (vehicle[i].Year > 2003)
                            masVeh[countVeh++] = vehicle[i];
                    }
                    else if (vehicle[i].GetType().Name == "CPlane")
                    {
                        masVeh[countVeh++] = vehicle[i];
                    }
                    else if (vehicle[i].GetType().Name == "CShip")
                    {
                        if (vehicle[i].Year < 2005)
                            masVeh[countVeh++] = vehicle[i];
                    }
                }
            }
            Console.WriteLine("Cars " + countCars);
            Console.WriteLine("Planes " + countPlanes);
            Console.WriteLine("Ships " + countShips);
            if (maxPrice != null) maxPrice.Print();

            Console.WriteLine("--------------------------");

            Array.Resize(ref masVeh, countVeh);
            for (int i = 0; i < masVeh.Length; i++)
            {
                masVeh[i].Print();
            }

            Console.WriteLine("--------------------------");

            SwimableVehicle sv = new SwimableVehicle();
            ISwimable[] masSwim = new ISwimable[10];

            for (int i = 0; i < masSwim.Length; i++)
            {
                masSwim[i] = sv.NextVehicle();
            }

            int iSwimable = 0;
            for (int i = 0; i < vehicle.Length; i++)
            {
                if (vehicle[i] is ISwimable)
                    masSwim[iSwimable++] = vehicle[i] as ISwimable;
            }

            Array.Resize(ref masSwim, iSwimable);
            for (int i = 0; i < masSwim.Length; i++)
            {
                Console.WriteLine(masSwim);
            }
        }
    }
}
