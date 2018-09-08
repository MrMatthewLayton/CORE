namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public sealed class EnumerableEmptyValidatorTests
    {
        [Fact]
        public void EnumerableEmptyValidatorReturnsTrueForAnEmptyEnumerable()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableEmptyValidator<int>();
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Empty<int>());

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void EnumerableEmptyValidatorReturnsFalseForANonEmptyEnumerable()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableEmptyValidator<int>();
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Range(1, 10));

            // Assert
            Assert.False(result);
        }
    }
}
