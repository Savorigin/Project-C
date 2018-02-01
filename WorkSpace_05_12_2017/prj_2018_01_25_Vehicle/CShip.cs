using System;

namespace Vehicle
{
    class CShip : CVehicle, ISwimable
    {
        public int CountPassengers { get; set; }
        public string Port { get; set; }
        public CShip(CPoint сoordinate, int price, int speed, int year, int count, string port) : base(сoordinate, price, speed, year)
        {
            CountPassengers = count;
            Port = port;
        }
        public CShip(int сoordinateX, int сoordinateY, int price, int speed, int year, int count, string port) : base(new CPoint(сoordinateX, сoordinateY), price, speed, year)
        {
            CountPassengers = count;
            Port = port;
        }
        public int Swim()
        {
            return (int) Speed / 2;
        }
    }
}
