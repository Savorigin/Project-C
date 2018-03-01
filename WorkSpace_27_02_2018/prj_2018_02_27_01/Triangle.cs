using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    public class Triangle : AbstractFigure
    {
        public Point ApexA { get; set; }
        public Point ApexB { get; set; }
        public Point ApexC { get; set; }
        public Line SideAB { get; set; }
        public Line SideBC { get; set; }
        public Line SideAC { get; set; }

        public Triangle(Point apexA, Point apexB, Point apexC)
        {
            ApexA = apexA;
            ApexB = apexB;
            ApexC = apexC;
            /*SideAB = new Line(ApexA, ApexB);
            SideBC = new Line(ApexB, ApexC);
            SideAC = new Line(ApexA, ApexC);*/
        }

        public Line GetSideAB()
        {
            if (SideAB == null) SideAB = new Line(ApexA, ApexB);
            return SideAB;
        }
        public double GetLengthAB()
        {
            return SideAB.Length;
        }

        public override void Print()
        {
            Console.WriteLine("Triangle : " + ToString());
        }
    }
}
