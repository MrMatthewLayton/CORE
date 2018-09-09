namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class EmailAddressValidatorTests
    {
        [Theory]
        [InlineData("a.b@c.com")]
        public void EmailAddressValidatorShouldReturnTrueForAValidEmailAddress(string candidate)
        {
            // Arrange
            Validator<string> validator = new EmailAddressValidator();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("abc")]
        public void EmailAddressValidatorShouldReturnFalseForAnInvalidEmailAddress(string candidate)
        {
            // Arrange
            Validator<string> validator = new EmailAddressValidator();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }
    }
}
