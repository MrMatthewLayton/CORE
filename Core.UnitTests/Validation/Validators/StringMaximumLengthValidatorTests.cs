namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringMaximumLengthValidatorTests
    {
        [Fact]
        public void StringMaximumLengthValidatorReturnsTrueForAStringThatIsShorterThanTheMaximumLength()
        {
            // Arrange
            Validator<string> validator = new StringMaximumLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid("ab");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringMaximumLengthValidatorReturnsTrueForAStringThatMatchesTheMaximumLength()
        {
            // Arrange
            Validator<string> validator = new StringMaximumLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringMaximumLengthValidatorReturnsFalseForAStringThatIsLongerThanTheMaximumLength()
        {
            // Arrange
            Validator<string> validator = new StringMaximumLengthValidator(2);
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.False(result);
        }
    }
}
