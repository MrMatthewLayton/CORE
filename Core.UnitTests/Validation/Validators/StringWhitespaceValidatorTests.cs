namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringWhitespaceValidatorTests
    {
        [Fact]
        public void StringWhitespaceValidatorReturnsTrueForWhitespaceString()
        {
            // Arrange
            Validator<string> validator = new StringWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid("   ");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringWhitespaceValidatorReturnsFalseForNonWhitespaceString()
        {
            // Arrange
            Validator<string> validator = new StringWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid("   abc   ");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringWhitespaceValidatorReturnsFalseForEmptyString()
        {
            // Arrange
            Validator<string> validator = new StringWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid(string.Empty);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringWhitespaceValidatorReturnsFalseForNullReference()
        {
            // Arrange
            Validator<string> validator = new StringWhitespaceValidator();
            bool result;

            // Act
            result = validator.IsValid(null);

            // Assert
            Assert.False(result);
        }
    }
}
