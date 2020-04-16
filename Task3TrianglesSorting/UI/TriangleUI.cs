using System;
using System.Collections.Generic;

namespace Task3TrianglesSorting
{
    public class TriangleUI
    {
        public const string Instruction = "Input format: Name; First Side; Second Side; Third Side.  All sides must be greater than zero";
        public const string Mistake = "You entered incorrect data";
        
        private const byte ArgsCount = 4;
        
        public string[] ReadTriangle()
        {
            Console.WriteLine("Enter name and sides in format: <name>; <side 1>; <side 2>; <side 3>");
            var inputData = Console.ReadLine()?.Split(';');

            if (inputData == null && inputData.Length != ArgsCount)
            {
                throw new ArgumentException("You entered incorrect data");
            }

            return inputData;
        }

        public void DisplayListOfTriangles(IEnumerable<Shape> figures)
        {
            var figureNumber = 1;
            
            Console.WriteLine("============= Triangles list: ===============");
            
            foreach (var figure in figures)
            {
                Console.WriteLine("{0}.{1}", figureNumber++, figure);
            }
        }
        
        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }
        
        public bool IsContiniue()
        {
            Console.WriteLine("Do you want to add figure?");
            var result = Console.ReadLine()?.ToLower();

            return result == "y" || result == "yes";
        }
    }
}