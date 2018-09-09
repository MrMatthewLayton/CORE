namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class RegularExpressionValidatorTests
    {
        [Theory]
        [InlineData("[0-9]", "123")]
        public void RegularExpressionValidatorShouldReturnTrueForAStringThatMatchesTheGivenPattern(string pattern, string candidate)
        {
            // Arrange
            Validator<string> validator = new RegularExpressionValidator(pattern);
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("[0-9]", "ABC")]
        public void RegularExpressionValidatorShouldReturnFalseForAStringThatDoesNotMatchTheGivenPattern(string pattern, string candidate)
        {
            // Arrange
            Validator<string> validator = new RegularExpressionValidator(pattern);
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }
    }
}
