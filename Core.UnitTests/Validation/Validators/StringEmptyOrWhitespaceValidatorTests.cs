namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringEmptyOrWhitespaceValidatorTests
    {
        [Fact]
        public void StringEmptyOrWhitespaceValidatorReturnsTrueForEmptyString()
        {
            // Arrange
            Validator<string> validator = new StringEmptyOrWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid(string.Empty);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringEmptyOrWhitespaceValidatorReturnsTrueForWhitespaceString()
        {
            // Arrange
            Validator<string> validator = new StringEmptyOrWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid("   ");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringEmptyOrWhitespaceValidatorReturnsFalseForNonEmptyOrWhitespaceString()
        {
            // Arrange
            Validator<string> validator = new StringEmptyOrWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringEmptyOrWhitespaceValidatorReturnsFalseForNullReference()
        {
            // Arrange
            Validator<string> validator = new StringEmptyOrWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid(null);

            // Assert
            Assert.False(result);
        }
    }
}
