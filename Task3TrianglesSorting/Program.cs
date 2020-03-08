using System;
using System.Collections.Generic;

namespace Task3TrianglesSorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TriangleUI _ui = new TriangleUI();
            List<AbstractFigure> Triangles = new List<AbstractFigure>();
            
            while(TriangleUI.AddFigure())
            {
                Triangle triangle = _ui.ReadTriangle();
                if (triangle.IsValid(triangle))
                {
                    Triangles.Add(triangle);
                    Triangles.Sort();
                    _ui.ShowListOfTriangles(Triangles);
                }
                else
                {
                    _ui.PrintMistake();
                }
            }
        }
    }
}