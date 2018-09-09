namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class LuhnValidatorTests
    {
        [Theory]
        [InlineData("378282246310005")]
        [InlineData("371449635398431")]
        [InlineData("378734493671000")]
        [InlineData("5610591081018250")]
        [InlineData("30569309025904")]
        [InlineData("38520000023237")]
        [InlineData("6011111111111117")]
        [InlineData("6011000990139424")]
        [InlineData("3530111333300000")]
        [InlineData("3566002020360505")]
        [InlineData("5555555555554444")]
        [InlineData("4012888888881881")]
        public void LuhnValidatorShouldReturnTrueForValuesThatPassTheLuhnChecksum(string candidate)
        {
            // Arrange
            Validator<string> validator = new LuhnValidator();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("123")]
        [InlineData("1111")]
        [InlineData("123456789")]
        [InlineData("5610591081018251")]
        public void LuhnValidatorShouldReturnFalseForValuesThatDoNotPassTheLuhnChecksum(string candidate)
        {
            // Arrange
            Validator<string> validator = new LuhnValidator();
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }
    }
}
