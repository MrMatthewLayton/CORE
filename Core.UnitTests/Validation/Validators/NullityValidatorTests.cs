namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class NullityValidatorTests
    {
        [Fact]
        public void NullityValidatorReturnsTrueForNullReference()
        {
            // Arrange
            Validator<object> validator = new NullityValidator<object>();
            bool result;

            // Act
            result = validator.IsValid(null);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void NullityValidatorReturnsFalseForNonNullReference()
        {
            // Arrange
            Validator<object> validator = new NullityValidator<object>();
            bool result;

            // Act
            result = validator.IsValid(new object());

            // Assert
            Assert.False(result);
        }
    }
}
