using System;

namespace Vehicle
{
    class CPlane : CVehicle
    {
        public int Hight { get; set; }
        public CPlane(CPoint сoordinate, int price, int speed, int year, int hight) : base(сoordinate, price, speed, year)
        {
            Hight = hight;
        }
        public CPlane(int сoordinateX, int сoordinateY, int price, int speed, int year, int hight) : base(сoordinateX, сoordinateY, price, speed, year)
        {
            Hight = hight;
        }
    }
}
