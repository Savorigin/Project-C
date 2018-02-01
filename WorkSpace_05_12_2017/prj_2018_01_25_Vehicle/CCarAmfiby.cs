using System;

namespace Vehicle
{
    class CCarAmfibia : CCar, ISwimable
    {
        public CCarAmfibia(int сoordinateX, int сoordinateY, int price, int speed, int year) : base(new CPoint(сoordinateX, сoordinateY), price, speed, year)
        {
        }
        public CCarAmfibia(CPoint сoordinate, int price, int speed, int year) : base(сoordinate, price, speed, year)
        {
        }
        public int Swim()
        {
            return Speed / 2;
        }
    }
}
