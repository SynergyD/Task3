using System;
using System.Collections.Generic;

namespace Task3TrianglesSorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractFigure figure = new Triangle(5,4,3,"Name");
            Console.WriteLine(figure.Area);
            Console.WriteLine(figure.Perimeter);
            //Console.ReadLine();
            
        }

        public void AddNewTriangleToList(SortedSet<Triangle> triangles)
        {
            
        }
        
        
        
    }
}