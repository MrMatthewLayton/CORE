namespace Encore.UnitTests.Design
{
    using Core.Design;
    using Xunit;

    public sealed class SingletonTests
    {
        [Fact(DisplayName = "Singleton<System.Int32> will point to same instance")]
        public void SingletonOfInt32WillPointToTheSameInstance()
        {
            // Arrange
            Singleton<int> a;
            Singleton<int> b;

            // Act
            a = 123;
            b = 456;

            // Assert
            Assert.Equal(a.Value, b.Value);
            Assert.True(ReferenceEquals(a, b));
        }

        [Fact(DisplayName = "Singleton<System.String> will point to same instance")]
        public void SingletonOfStringWillPointToSameInstance()
        {
            // Arrange
            Singleton<string> a;
            Singleton<string> b;

            // Act
            a = "Hello";
            b = "World";

            // Assert
            Assert.Equal(a.Value, b.Value);
            Assert.True(ReferenceEquals(a, b));
        }
    }
}