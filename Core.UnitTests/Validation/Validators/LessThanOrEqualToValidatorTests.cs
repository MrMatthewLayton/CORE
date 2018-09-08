namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class LessThanOrEqualToValidatorTests
    {
        [Fact]
        public void LessThanOrEqualToValidatorReturnsTrueForIntegersLessThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanOrEqualToValidator<int>(456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void LessThanOrEqualToValidatorReturnsFalseForIntegersNotLessThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanOrEqualToValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void LessThanOrEqualToValidatorReturnsTrueForIntegersEqualToTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanOrEqualToValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.True(result);
        }
    }
}
