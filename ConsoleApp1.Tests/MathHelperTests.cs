using ConsoleApp1;
using Xunit;

namespace ConsoleApp1.Tests
{
    public class MathHelperTests
    {
        [Fact]
        public void Sum_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            int result = MathHelper.Sum(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Sum_WithZero_ReturnsOtherNumber()
        {
            int result = MathHelper.Sum(7, 0);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Sum_TwoNegativeNumbers_ReturnsCorrectResult()
        {
            int result = MathHelper.Sum(-4, -6);
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Sum_PositiveAndNegative_ReturnsCorrectResult()
        {
            int result = MathHelper.Sum(10, -3);
            Assert.Equal(7, result);
        }
    }
}
