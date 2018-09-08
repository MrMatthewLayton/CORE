namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class LessThanValidatorTests
    {
        [Fact]
        public void LessThanValidatorReturnsTrueForIntegersLessThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanValidator<int>(456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void LessThanValidatorReturnsFalseForIntegersNotLessThanTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void LessThanValidatorReturnsFalseForIntegersEqualToTheOtherValue()
        {
            // Arrange
            Validator<int> validator = new LessThanValidator<int>(123);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.False(result);
        }
    }
}
