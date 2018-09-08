namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public sealed class EnumerableCountValidatorTests
    {
        [Fact]
        public void EnumerableCountValidatorReturnsTrueForAnEnumerableWithTheGivenCount()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableCountValidator<int>(10);
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Range(1, 10));

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void EnumerableCountValidatorReturnsFalseForAnEnumerableWithoutTheGivenCount()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableCountValidator<int>(10);
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Range(1, 5));

            // Assert
            Assert.False(result);
        }
    }
}
