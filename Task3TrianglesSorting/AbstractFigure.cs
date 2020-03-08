using System;

namespace Task3TrianglesSorting
{
    public abstract class AbstractFigure: IComparable<AbstractFigure>
    {
        protected AbstractFigure(string name)
        {
            Name = name;
        }

        protected double Perimeter { get; set; }
        protected double Area { get; set; }
        protected string Name { get; }

        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        
        public int CompareTo(AbstractFigure other)
        {
            if (Area > other.Area)
            {
                return 1;
            }
            
            if (Area<other.Area)
            {
                return -1;
            }

            return 0;
        }
    }
}