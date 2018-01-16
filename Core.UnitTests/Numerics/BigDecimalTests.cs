namespace Core.UnitTests.Numerics
{
    using Core.Numerics;
    using Xunit;

    public sealed class BigDecimalTests
    {
        [Theory]
        [InlineData(int.MaxValue, 1, "214748364.7")]
        [InlineData(int.MaxValue, 2, "21474836.47")]
        [InlineData(int.MaxValue, 4, "214748.3647")]
        [InlineData(int.MaxValue, 8, "21.47483647")]
        [InlineData(int.MaxValue, 16, "0.0000002147483647")]
        public void BigDecimalShouldRespectScale(int value, int scale, string expected)
        {
            // Arrange
            BigDecimal sut;
            string actual;

            // Act
            sut = new BigDecimal(value, scale);
            actual = sut.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
