using System;

namespace Vehicle
{
    class CVehicle
    {
        public CPoint Сoordinate { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }
        public CVehicle(CPoint сoordinate, int price, int speed, int year)
        {
            Сoordinate = сoordinate;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public CVehicle(int сoordinateX, int сoordinateY, int price, int speed, int year)
        {
            Сoordinate = new CPoint(сoordinateX, сoordinateY);
            Price = price;
            Speed = speed;
            Year = year;
        }
        public void Print()
        {
            Console.WriteLine($"Vehicle({Сoordinate.X},{Сoordinate.Y}), price {Price}, speed {Speed}, year {Year}");
        }
    }
}
