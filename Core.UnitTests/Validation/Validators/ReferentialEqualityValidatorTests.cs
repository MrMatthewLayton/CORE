namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using Xunit;

    public sealed class ReferentialEqualityValidatorTests
    {
        [Fact]
        public void ReferentialEqualityValidatorReturnsTrueForObjectsEqualByReference()
        {
            // Arrange
            object operand1 = new object();
            object operand2 = operand1;
            Validator<object> validator = new ReferentialEqualityValidator<object>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ReferentialEqualityValidatorReturnsFalseForObjectsNotEqualByReference()
        {
            // Arrange
            object operand1 = new object();
            object operand2 = new object();
            Validator<object> validator = new ReferentialEqualityValidator<object>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.False(result);
        }
    }
}
