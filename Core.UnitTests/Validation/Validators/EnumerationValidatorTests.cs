namespace Core.UnitTests.Validation.Validators
{
    using Core.UnitTests.Candidates.Enumerations;
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class EnumerationValidatorTests
    {
        [Theory]
        [InlineData("Red")]
        [InlineData("Green")]
        [InlineData("Blue")]
        public void EnumerationValidatorShouldReturnTrueForValueThatIsDefinedWithinTheGivenEnumeration(string candidate)
        {
            // Arrange
            Validator<string> validator = new EnumerationValidator<Color>();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("Orange")]
        [InlineData("Purple")]
        [InlineData("Brown")]
        public void EnumerationValidatorShouldReturnFalseForValueThatIsDefinedWithinTheGivenEnumeration(string candidate)
        {
            // Arrange
            Validator<string> validator = new EnumerationValidator<Color>();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }
    }
}
