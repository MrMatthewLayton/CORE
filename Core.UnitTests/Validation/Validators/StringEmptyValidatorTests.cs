namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringEmptyValidatorTests
    {
        [Fact]
        public void StringEmptyValidatorReturnTrueForAnEmptyString()
        {
            // Arrange
            Validator<string> validator = new StringEmptyValidator();
            bool result;

            // Act
            result = validator.IsValid(string.Empty);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringEmptyValidatorReturnFalseForANonEmptyString()
        {
            // Arrange
            Validator<string> validator = new StringEmptyValidator();
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringEmptyValidatorReturnFalseForANullReference()
        {
            // Arrange
            Validator<string> validator = new StringEmptyValidator();
            bool result;

            // Act
            result = validator.IsValid(null);

            // Assert
            Assert.False(result);
        }
    }
}
