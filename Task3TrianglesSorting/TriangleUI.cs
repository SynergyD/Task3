using System;
using System.Collections.Generic;

namespace Task3TrianglesSorting
{
    public class TriangleUI
    {
        private const byte ArgsCount = 4;
        public Triangle ReadTriangle()
        {
            Console.WriteLine("Enter sides and name pls");
            var inputData = Console.ReadLine()?.Split(',');

            if (inputData != null && inputData.Length == ArgsCount)
            {
                var sideA = double.Parse(inputData[0]);
                var sideB = double.Parse(inputData[1]);
                var sideC = double.Parse(inputData[2]);
                var nameTriangle = inputData[3];

                return new Triangle(sideA, sideB, sideC, nameTriangle);
            }
            
            return ReadTriangle();
        }

        public void ShowListOfTriangles(List<AbstractFigure> triangles)
        {
            var index = 1;
            Console.WriteLine("============= Triangles list: ===============");
            foreach (var triangle in triangles)
            {
                Console.WriteLine("{0}.{1}",index++,triangle);
            }
        }

        public void PrintMistake()
        {
            Console.WriteLine("You entered incorrect data");
        }
        
        
        public static bool AddFigure()
        {
            Console.WriteLine("Do you want add figure?");
            var result = Console.ReadLine()?.ToLower();
            var add = false || (result == "y" || result == "yes");

            return add;
        }
    }
}