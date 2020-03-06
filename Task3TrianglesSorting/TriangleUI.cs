using System;

namespace Task3TrianglesSorting
{
    public class TriangleUI
    {
        public Triangle ReadTriangle()
        {
            string[] inputData = new string [4];

            double sideA;
            double sideB;
            double sideC;
            string nameTriangle;
            try
            {
                sideA = double.Parse(inputData[0]);
                sideB = double.Parse(inputData[1]);
                sideC = double.Parse(inputData[2]);
                nameTriangle = inputData[3];

                return new Triangle(sideA,sideB,sideC,nameTriangle);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Empty");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Must enter more inf");
            }
            return ReadTriangle();
        }
    }
}