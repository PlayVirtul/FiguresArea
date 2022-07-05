using FiguresArea.Figures;
using Xunit;

namespace FiguresArea.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnArea()
        {
            // arrange
            var triangle = new Triangle(5, 5, 6);
            var resultArea = 12;

            //act
            var area = triangle.Area;

            // assert
            Assert.Equal(resultArea, area);
        }

        [Fact]
        public void CreateNonExistentTriangle_ShouldThrowArgumentException()
        {
            // arrange
            Triangle triangle;

            //act

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                triangle = new Triangle(1, 2, 3);
            });
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -100, 0)]
        [InlineData(-1, -100, -100)]
        [InlineData(-1, 0, -100)]
        [InlineData(0, 0, -100)]
        public void CreateTriangleWithNegativeSides_ShouldThrowArgumentOutOfRangeException(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            // arrange
            Triangle triangle;

            //act

            // assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(26, 10, 24)]
        [InlineData(25, 15, 20)]
        public void IsRightTriangle_ShouldReturnTrue(double firstSide, double secondSide, double thirdSide)
        {
            //arrange
            var rightTriangle = new Triangle(firstSide, secondSide, thirdSide);

            //act
            var result = rightTriangle.IsRightTriangle;

            //assert
            Assert.Equal(result, true);
        }

        [Theory]
        [InlineData(7, 8, 5)]
        [InlineData(9, 7, 10)]
        [InlineData(8, 5, 4)]
        public void IsRightTriangle_ShouldReturnFalse(double firstSide, double secondSide, double thirdSide)
        {
            //arrange
            var rightTriangle = new Triangle(firstSide, secondSide, thirdSide);

            //act
            var result = rightTriangle.IsRightTriangle;

            //assert
            Assert.Equal(result, false);
        }
    }
}