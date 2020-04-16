using System;
using System.Collections.Generic;

namespace Task3TrianglesSorting
{
    public class TrianglesSortingApp
    {
        private readonly TriangleUI ui;

        public TrianglesSortingApp(TriangleUI ui)
        {
            this.ui = ui;
        }

        public void Run(string sideA, string sideB, string sideC, string name)
        {

            var triangles = new List<Shape>
            {
                GetTriangle(GetSide(sideA), GetSide(sideB), GetSide(sideC), name)
            };

            ui.DisplayListOfTriangles(triangles);

            while (ui.IsContiniue())
            {
                var param = ui.ReadTriangle();

                triangles.Add(GetTriangle(GetSide(param[1]),
                    GetSide(param[2]), GetSide(param[3]), param[0].Trim()));

                triangles.Sort();
                triangles.Reverse();

                ui.DisplayListOfTriangles(triangles);
            }
        }

        private Triangle GetTriangle(double sideA, double sideB, double sideC, string name)
        {
            CheckSides(sideA, sideB, sideC);

            return new Triangle(sideA, sideB, sideC, name);
        }

        private static double GetSide(string side)
        {
            if (double.TryParse(side, out var numberSide))
            {
                return numberSide;
            }

            throw new FormatException("Incorrect format");        
        }

        private void CheckSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0.0 || sideC + sideB < sideA)
            {
                throw new ArgumentException("Incorrect first side", nameof(sideA));
            }

            if (sideB <= 0.0 || sideA + sideC < sideB)
            {
                throw new ArgumentException("Incorrect second side", nameof(sideB));
            }
            
            if (sideC <= 0.0 || sideA + sideB < sideC)
            {
                throw new ArgumentException("Incorrect third side", nameof(sideC));
            }
        }
    }
}