namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class GreaterThanValidatorTests
    {
        [Fact]
        public void GreaterThanValidatorReturnsTrueForIntegersGreaterThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GreaterThanValidatorReturnsFalseForIntegersNotGreaterThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanValidator<int>(456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GreaterThanValidatorReturnsFalseForIntegersEqualToTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.False(result);
        }
    }
}
