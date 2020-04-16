using System;

namespace Task3TrianglesSorting
{
    public abstract class Shape: IComparable<Shape>
    {
        #region Constructors

        protected Shape(string name)
        {
            Name = name;
        }

        #endregion

        #region Properties

        public abstract double Perimeter { get; }
        public abstract double Area { get; }
        private string Name { get; }

        #endregion

        #region AbstractMethods

        protected abstract double CalculatePerimeter();
        protected abstract double CalculateArea();

        #endregion

        #region Methods

        public int CompareTo(Shape other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other),"Object is null");
            }
            
            if (Area > other.Area)
            {
                return 1;
            }

            if (Area < other.Area)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"[{GetType().Name} {Name}]: {Area:F2} cm";
        }

        #endregion
    }
}