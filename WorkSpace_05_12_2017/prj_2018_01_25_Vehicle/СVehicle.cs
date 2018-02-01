using System;

namespace Vehicle
{
    class CVehicle
    {
        public CPoint Coordinate { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }
        public CVehicle(CPoint сoordinate, int price, int speed, int year)
        {
            Coordinate = сoordinate;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public CVehicle(int сoordinateX, int сoordinateY, int price, int speed, int year)
        {
            Coordinate = new CPoint(сoordinateX, сoordinateY);
            Price = price;
            Speed = speed;
            Year = year;
        }
        public void SetCoordinate(int сoordinateX, int сoordinateY)
        {
            Coordinate.X = сoordinateX;
            Coordinate.Y = сoordinateY;
        }
        public void SetCoordinate(CPoint сoordinate)
        {
            Coordinate = сoordinate;
        }
        public CPoint GetCoordinate()
        {
            return Coordinate;
        }
        public void Print()
        {
            Console.WriteLine($"Vehicle({Coordinate.X},{Coordinate.Y}), price {Price}, speed {Speed}, year {Year}");
        }
        public override string ToString()
        {
            return $"Vehicle({Coordinate.X},{Coordinate.Y}), price {Price}, speed {Speed}, year {Year}";
        }
    }
}
