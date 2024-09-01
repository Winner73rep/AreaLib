using AreaLib;

namespace AreaLib.Tests
{
    public class AreaLibTests
    {
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        [Fact]
        public void GetAreaTriangleTest()
        {
            // Arrange
            double a = 13;
            double b = 14;
            double c = 15;

            // Act
            double result = Area.GetAreaRunTime(Area.Shape.Triangle, a, b, c);

            // Assert
            Assert.Equal(84, result);
        }

        /// <summary>
        /// Площадь прямоугольного треугольника
        /// </summary>
        [Fact]
        public void GetAreaRightTriangleTest()
        {
            // Arrange
            double a = 6;
            double b = 10;
            double c = 8;

            // Act
            double result = Area.GetAreaRunTime(Area.Shape.Triangle, a, b, c);

            // Assert
            Assert.Equal(24, result);
        }
        /// <summary>
        /// Площадь круга
        /// </summary>
        [Fact]
        public void GetAreaCircleTest()
        {
            // Arrange
            double r = 5;

            // Act
            double result = Area.GetAreaRunTime(Area.Shape.Circle, radius: r);

            // Assert
            Assert.Equal(78.5d, result);
        }
    }
}