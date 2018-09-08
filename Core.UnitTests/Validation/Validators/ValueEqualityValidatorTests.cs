namespace Core.UnitTests.Validation.Validators
{
    using Core.UnitTests.Candidates.Models;
    using Core.Validation;
    using Core.Validation.Validators;
    using System;
    using Xunit;

    public sealed class ValueEqualityValidatorTests
    {
        [Fact]
        public void ValueEqualityValidatorReturnsTrueForIntegersEqualByValue()
        {
            // Arrange
            int operand1 = 123;
            int operand2 = 123;
            Validator<int> validator = new ValueEqualityValidator<int>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValueEqualityValidatorReturnsFalseForIntegersNotEqualByValue()
        {
            // Arrange
            int operand1 = 123;
            int operand2 = 456;
            Validator<int> validator = new ValueEqualityValidator<int>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValueEqualityValidatorReturnsTrueForStringsEqualByValue()
        {
            // Arrange
            string operand1 = "abc";
            string operand2 = "abc";
            Validator<string> validator = new ValueEqualityValidator<string>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValueEqualityValidatorReturnsFalseForStringNotEqualByValue()
        {
            // Arrange
            string operand1 = "abc";
            string operand2 = "xyz";
            Validator<string> validator = new ValueEqualityValidator<string>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValueEqualityValidatorReturnsTrueForPersonsEqualByValue()
        {
            // Arrange
            Person operand1 = new Person("John", "Smith", new DateTime(2000, 01, 01));
            Person operand2 = new Person("John", "Smith", new DateTime(2000, 01, 01));
            Validator<Person> validator = new ValueEqualityValidator<Person>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValueEqualityValidatorReturnsFalseForPersonsNotEqualByValue()
        {
            // Arrange
            Person operand1 = new Person("John", "Smith", new DateTime(2000, 01, 01));
            Person operand2 = new Person("Jack", "Jones", new DateTime(1990, 12, 12));
            Validator<Person> validator = new ValueEqualityValidator<Person>(operand1);
            bool result;

            // Act
            result = validator.IsValid(operand2);

            // Assert
            Assert.False(result);
        }
    }
}
