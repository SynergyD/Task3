using System;


namespace Task3TrianglesSorting
{
    public class Triangle : AbstractFigure
    {
        public Triangle(double sideA,double sideB,double sideC,string name):base(name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            
        }

        public Triangle CreateTriangle(double sideA, double sideB, double sideC, string name = "")
        {
            if ((sideA + sideB) > sideC && (sideA + sideC) > sideB && (sideB + sideC) > sideA)
            {
                return new Triangle(sideA, sideB, sideC, name);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double CalculateArea()
        {
            double area;
            double halfPerimeter = Perimeter / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) *
                             (halfPerimeter - sideC));

            return area;
        }
        private double sideA;
        private double sideB;
        private double sideC;
    }
}