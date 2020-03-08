using System;


namespace Task3TrianglesSorting
{
    public class Triangle : AbstractFigure
    {
        public Triangle(double sideA,double sideB,double sideC,string name):base(name)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }
        public sealed override double CalculatePerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public sealed override double CalculateArea()
        {
            var halfPerimeter = Perimeter / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * 
                                 (halfPerimeter - _sideB) * (halfPerimeter - _sideC));

            return area;
        }

        public bool IsValid(Triangle triangle)
        {
            if (triangle._sideA <= 0 || triangle._sideB <= 0 || triangle._sideC <= 0 ||
                triangle._sideA + triangle._sideB < triangle._sideC ||
                triangle._sideA + triangle._sideC < triangle._sideB ||
                triangle._sideC + triangle._sideB < triangle._sideA)
            {
                return false;
            }

            return true;
        }

        public override string ToString() => $"[Triangle {Name}]: {Area:F2} cm";
        
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
    }
}