using System;

namespace Task3TrianglesSorting
{
    public abstract class AbstractFigure: IComparable<AbstractFigure>
    {
        public AbstractFigure(string name)
        {
            Name = name;
            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }

        public AbstractFigure()
        {
            
        }

        public double Perimeter { get; private set; }
        public double Area { get; private set; }
        private string Name { get; set; }

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
            else
            {
                return 0;
            }
        }
    }
}