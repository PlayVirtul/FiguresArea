using FiguresArea.Figures;
using Xunit;

namespace FiguresArea.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnArea()
        {
            //arrange
            var circle = new Circle(10);
            var resultArea = 314.1592653589793;

            //act
            var area = circle.Area;

            //assert
            Assert.Equal(area, resultArea);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-1000000)]
        public void CreateCircleWithNegativeRadius_ShouldThrowArgumentOutOfRangeException(double radius)
        {
            //arrange
            Circle circle;

            //act

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                circle = new Circle(radius);
            });
        }
    }
}