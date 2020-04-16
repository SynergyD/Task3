using System;
using Task3TrianglesSorting;
using Xunit;

namespace TrianglesSortingTests
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(3, 4, 5, 4, 3, 5, 0)]
        [InlineData(3.0, 4, 5.0, 3, 4.0, 5.0, 0)]
        [InlineData(3.27, 4.12356234, 5.12324, 3.27, 4.12356234, 5.12324,0)]
        public void CompareTo_CompareEqualTriangles_ShouldCorrect(double firstA, double firstB, double firstC,
            double secondA, double secondB, double secondC, int expected)
        {
            var firstTriangle = new Triangle(firstA, firstB, firstC, "Test1");
            var secondTriangle = new Triangle(secondA, secondB, secondC, "Test2");

            var actual = firstTriangle.CompareTo(secondTriangle);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 8, 10, 3, 4, 5, 1)]
        public void CompareTo_FirstTriangleShouldBeGreater_ShouldCorrect(double firstA, double firstB, double firstC,
            double secondA, double secondB, double secondC, int expected)
        {
            var firstTriangle = new Triangle(firstA, firstB, firstC, "Test1");
            var secondTriangle = new Triangle(secondA, secondB, secondC, "Test2");

            var actual = firstTriangle.CompareTo(secondTriangle);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0, 6.0, 8.0, 10.0, -1)]
        [InlineData(4, 3, 6, 5.0, 5, 6, -1)]
        public void CompareTo_SecondTriangleShouldBeGreater_ShouldCorrect(double firstA, double firstB, double firstC,
            double secondA, double secondB, double secondC, int expected)
        {
            var firstTriangle = new Triangle(firstA, firstB, firstC, "Test1");
            var secondTriangle = new Triangle(secondA, secondB, secondC, "Test2");

            var actual = firstTriangle.CompareTo(secondTriangle);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareTo_CompareShapeAndNull_ShouldFail()
        {
            Shape shape = null;
            var firstTriangle = new Triangle(3.0, 4.0, 5.0, "Test1");
            var parameterName = "other";

            Assert.Throws<ArgumentNullException>(parameterName, () => firstTriangle.CompareTo(shape));
        }

    }
}