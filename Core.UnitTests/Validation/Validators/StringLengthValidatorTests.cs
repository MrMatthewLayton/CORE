namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class StringLengthValidatorTests
    {
        [Fact]
        public void StringLengthValidatorReturnsTrueForStringOfSpecifiedLength()
        {
            // Arrange
            Validator<string> validator = new StringLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid("abc");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringLengthValidatorReturnsFalseForStringNotOfSpecifiedLength()
        {
            // Arrange
            Validator<string> validator = new StringLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid(string.Empty);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringLengthValidatorReturnsFalseForNullReference()
        {
            // Arrange
            Validator<string> validator = new StringLengthValidator(3);
            bool result;

            // Act
            result = validator.IsValid(null);

            // Assert
            Assert.False(result);
        }
    }
}
