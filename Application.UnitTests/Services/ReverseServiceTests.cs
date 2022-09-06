using Application.Services;

namespace Application.UnitTests.Services
{
    public class ReverseServiceTests
    {
        private readonly ReverseService _sut;

        public ReverseServiceTests()
        {
            _sut = new ReverseService();
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(49, 7)]
        [InlineData(0, 0)]
        public void SquareDigit_ShouldCalculateSquareOfDigit_WhenDigitIsMoreThanZero(double digit, double expected)
        {
            // Act
            var result = _sut.SquareDigit(digit);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SquareDigit_ShouldThrowInvalidOperationException_WhenDigitIsNegative()
        {
            // Arrange
            double digit = -1;

            // Assert
            Assert.Throws<InvalidOperationException>(() => _sut.SquareDigit(digit));
        }

        [Theory]
        [InlineData("test", "tset")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("apl", "lpa")]
        public void ReverseString_ShouldReverseString_WhenStringIsPassed(string str, string expected)
        {
            // Act
            var result = _sut.ReverseString(str);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
