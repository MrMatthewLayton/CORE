namespace Core.UnitTests
{
    using Core.UnitTests.Candidates.Models;
    using System;
    using Xunit;

    public sealed class HashCodeTests
    {
        [Fact]
        public void HashCodeOfNullAndNonNullValuesShouldProduceAValidHash()
        {
            // Arrange
            Person sut = new Person("John", null, DateTime.MinValue);
            int? hashCode = null;

            // Act
            hashCode = sut.GetHashCode();

            // Assert
            Assert.NotNull(hashCode);
        }
    }
}
