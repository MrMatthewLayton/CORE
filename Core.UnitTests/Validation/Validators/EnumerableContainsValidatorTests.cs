namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public sealed class EnumerableContainsValidatorTests
    {
        [Fact]
        public void EnumerableContainsValidatorReturnsTrueForEnumerableThatContainsTheGivenValues()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableContainsValidator<int>(new[] { 1, 2, 3 });
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Range(1, 10));

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void EnumerableContainsValidatorReturnsFalseForEnumerableThatDoNotContainTheGivenValues()
        {
            // Arrange
            Validator<IEnumerable<int>> validator = new EnumerableContainsValidator<int>(new[] { 1, 2, 3, 12, 13, 14 });
            bool result;

            // Act
            result = validator.IsValid(Enumerable.Range(1, 10));

            // Assert
            Assert.False(result);
        }
    }
}
