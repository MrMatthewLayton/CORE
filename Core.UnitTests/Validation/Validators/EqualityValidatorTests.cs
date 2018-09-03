namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class EqualityValidatorTests
    {
        [Theory]
        [InlineData(123, 123)]
        [InlineData(1.23, 1.23)]
        [InlineData("abc", "abc")]
        [InlineData(true, true)]
        public void EqualityValidatorShouldReturnTrueForEqualValues<T>(T a, T b)
        {
            // Arrange
            Validator<T> validator = new EqualityValidator<T>(a);
            bool result;

            // Act
            result = validator.IsValid(b);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(123, 456)]
        [InlineData(1.23, 4.56)]
        [InlineData("abc", "xyz")]
        [InlineData(true, false)]
        public void EqualityValidatorShouldReturnFalseForNonEqualValues<T>(T a, T b)
        {
            // Arrange
            Validator<T> validator = new EqualityValidator<T>(a);
            bool result;

            // Act
            result = validator.IsValid(b);

            // Assert
            Assert.False(result);
        }
    }
}
