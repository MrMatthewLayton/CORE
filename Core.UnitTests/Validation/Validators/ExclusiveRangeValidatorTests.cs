namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class ExclusiveRangeValidatorTests
    {
        [Fact]
        public void ExclusiveRangeValidatorReturnsTrueForIntegersWithinTheMinimumAndMaximumRange()
        {
            // Arrange
            Validator<int> validator = new ExclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(321);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ExclusiveRangeValidatorReturnsFalseForIntegersEqualToTheMinimumValue()
        {
            // Arrange
            Validator<int> validator = new ExclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(123);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExclusiveRangeValidatorReturnsFalseForIntegersEqualToTheMaximumValue()
        {
            // Arrange
            Validator<int> validator = new ExclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(456);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExclusiveRangeValidatorReturnsFalseForIntegersThanAreLessThanTheMinimumValue()
        {
            // Arrange
            Validator<int> validator = new ExclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(-123);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ExclusiveRangeValidatorReturnsFalseForIntegersThanAreGreaterThanTheMaximumValue()
        {
            // Arrange
            Validator<int> validator = new ExclusiveRangeValidator<int>(123, 456);
            bool result;

            // Act
            result = validator.IsValid(1000);

            // Assert
            Assert.False(result);
        }
    }
}
