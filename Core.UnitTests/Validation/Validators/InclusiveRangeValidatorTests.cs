namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class InclusiveRangeValidatorTests
    {
        [Fact]
        public void InclusiveRangeValidatorReturnsTrueForIntegersWithinTheMinimumAndMaximumRange()
        {
            // Arrange
            Validator<int> validator = new InclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(321);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InclusiveRangeValidatorReturnsTrueForIntegersEqualToTheMinimumValue()
        {
            // Arrange
            Validator<int> validator = new InclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InclusiveRangeValidatorReturnsTrueForIntegersEqualToTheMaximumValue()
        {
            // Arrange
            Validator<int> validator = new InclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InclusiveRangeValidatorReturnsFalseForIntegersThanAreLessThanTheMinimumValue()
        {
            // Arrange
            Validator<int> validator = new InclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(-123);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void InclusiveRangeValidatorReturnsFalseForIntegersThanAreGreaterThanTheMaximumValue()
        {
            // Arrange
            Validator<int> validator = new InclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(1000);

            // Assert
            Assert.False(result);
        }
    }
}
