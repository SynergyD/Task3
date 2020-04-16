using System;
using Task3TrianglesSorting;
using Xunit;

namespace TrianglesSortingTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(1.0, 2.0, 3.0, 6.0)]
        [InlineData(4, 5, 6, 15)]
        [InlineData(3.27, 4.12356234, 5.12324, 12.51680234)]
        public void CalculatePerimeter_ShouldCorrect(double sideA, double sideB, double sideC, double expected)
        {
            var eps = 0.000001;
            var triangle = new Triangle(sideA, sideB, sideC, "test");

            var actual = triangle.Perimeter;

            Assert.True(expected - actual < eps);
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0, 6.0)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(3.27, 4.12356234, 5.12324, 6.7322844651071)]
        public void CalculateArea_ShouldCorrect(double sideA, double sideB, double sideC, double expected)
        {
            var eps = 0.000001;
            var triangle = new Triangle(sideA, sideB, sideC, "test");

            var actual = triangle.Area;

            Assert.True(expected - actual < eps);
        }
    }
}