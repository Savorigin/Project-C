using System;

namespace Vehicle
{
    class CBatMobile : CCarAmfibia, IFlyable
    {
        public CBatMobile(int сoordinateX, int сoordinateY, int price, int speed, int year) : base(new CPoint(сoordinateX, сoordinateY), price, speed, year)
        {
        }
        public CBatMobile(CPoint сoordinate, int price, int speed, int year) : base(сoordinate, price, speed, year)
        {
        }
        public int Fly()
        {
            return Speed * 10;
        }
    }
}
