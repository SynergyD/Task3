using System;

namespace Task3TrianglesSorting
{
    public class FigureUI
    {
        public virtual bool IsAddFigure()
        {
            var result = Console.ReadLine();
            bool isMore = false;
            Console.WriteLine("Do you want add figure?");
            
            if (result.ToUpper() == "Y" || result.ToUpper() == "YES")
            {
                isMore = true;
            }

            return isMore;
        }
    }
}