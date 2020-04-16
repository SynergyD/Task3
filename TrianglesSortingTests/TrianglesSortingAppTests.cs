using System;
using Task3TrianglesSorting;
using Xunit;

namespace TrianglesSortingTests
{
    public class TrianglesSortingAppTests
    {
        [Theory]
        [InlineData("2", "0", "3", "sideB")]
        [InlineData("1", "2", "30", "sideC")]
        [InlineData("-2", "9", "10", "sideA")]
        public void CheckSides_TriangleIsNotValid_ShouldFail(string sideA, string sideB, string sideC,string parameterName)
        {
            var ui = new TriangleUI();
            var app = new TrianglesSortingApp(ui);

            Assert.Throws<ArgumentException>(parameterName, () => app.Run(sideA, sideB, sideC,"Test"));
        }

        [Theory]
        [InlineData("3.0", "4", "a")]
        public void GetSide_IncorrectTypeOfSide_ShouldFail(string sideA, string sideB, string sideC)
        {
            var ui = new TriangleUI();
            var app = new TrianglesSortingApp(ui);

            Assert.Throws<FormatException>(() => app.Run(sideA, sideB, sideC, "Test"));
        }
        
        
        
    }
}