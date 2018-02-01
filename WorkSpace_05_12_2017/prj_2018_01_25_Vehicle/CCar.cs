﻿using System;

namespace Vehicle
{
    class CCar : CVehicle, IMoveable
    {
        public CCar(CPoint сoordinate, int price, int speed, int year) : base(сoordinate, price, speed, year)
        {
        }
        public CCar(int сoordinateX, int сoordinateY, int price, int speed, int year): base(сoordinateX, сoordinateY, price, speed, year)
        {
        }
        public int Move()
        {
            return Speed;
        }
    }
}
