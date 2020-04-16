using System;

namespace Task3TrianglesSorting
{
    public class Triangle : Shape
    {
        
        #region Constructors

        public Triangle(double sideA, double sideB, double sideC, string name) : base(name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        #endregion

        #region Properties

        public override double Perimeter => CalculatePerimeter();
        public override double Area => CalculateArea();

        #endregion

        #region Methods

        protected sealed override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        protected sealed override double CalculateArea()
        {
            var halfPerimeter = Perimeter / 2;

            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) 
                                               * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return area;
        }

        #endregion

        #region PrivateFields

        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        #endregion
        
    }
}