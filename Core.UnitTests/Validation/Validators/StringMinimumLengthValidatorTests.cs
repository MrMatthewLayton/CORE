namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringMinimumLengthValidatorTests
    {
        [Fact]
        public void StringMinimumLengthValidatorReturnsTrueForAStringThatIsLongerThanTheMinimumLength()
        {
            // Arrange
            Validator<string> validator = new StringMinimumLengthValidator(2);
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringMinimumLengthValidatorReturnsTrueForAStringThatMatchesTheMinimumLength()
        {
            // Arrange
            Validator<string> validator = new StringMinimumLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringMinimumLengthValidatorReturnsFalseForAStringThatIsShorterThanTheMinimumLength()
        {
            // Arrange
            Validator<string> validator = new StringMinimumLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid("ab");

            // Assert
            Assert.False(result);
        }
    }
}
