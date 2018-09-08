namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class GreaterThanOrEqualToValidatorTests
    {
        [Fact]
        public void GreaterThanOrEqualToValidatorReturnsTrueForIntegersGreaterThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanOrEqualToValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GreaterThanOrEqualToValidatorReturnsFalseForIntegersNotGreaterThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanOrEqualToValidator<int>(456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GreaterThanOrEqualToValidatorReturnsTrueForIntegersEqualToTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new GreaterThanOrEqualToValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.True(result);
        }
    }
}
