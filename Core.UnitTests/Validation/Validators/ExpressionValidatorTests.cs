namespace Core.UnitTests.Validation.Validators
{
    using Core.Validation;
    using Core.Validation.Validators;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using Xunit;

    public sealed class ExpressionValidatorTests
    {
        [Theory]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        [InlineData("ALCATRAZ")]
        public void ExpressionValidatorReturnsTrueForStringPredicateExpression(string candidate)
        {
            // Arrange
            Validator<string> validator = new ExpressionValidator<string>(value => value.StartsWith("A") && value.EndsWith("Z"));
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("ABC")]
        [InlineData("DEF")]
        public void ExpressionValidatorReturnsFalseForStringPredicateExpression(string candidate)
        {
            // Arrange
            Validator<string> validator = new ExpressionValidator<string>(value => value.StartsWith("A") && value.EndsWith("Z"));
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(123)]
        [InlineData(456)]
        public void ExpressionValidatorReturnsTrueForInt32PredicateExpression(int candidate)
        {
            // Arrange
            Validator<int> validator = new ExpressionValidator<int>(value => value < 789);
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(123)]
        [InlineData(456)]
        public void ExpressionValidatorReturnsFalseForInt32PredicateExpression(int candidate)
        {
            // Arrange
            Validator<int> validator = new ExpressionValidator<int>(value => value < 1);
            bool result;

            // Act
            result = validator.IsValid(candidate);

            // Assert
            Assert.False(result);
        }
    }
}
