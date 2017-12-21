namespace Encore.UnitTests.Design
{
    using Core.Design;
    using Xunit;

    public sealed class FreezableTests
    {
        [Fact(DisplayName = "Freezable<System.Int32> will remain frozen after Freeze called")]
        public void FreezableOfInt32WillRemainFrozenAfterFreezeCalled()
        {
            // Arrange
            Freezable<int> freezable;
            int expected = 123;
            int actual;

            // Act
            freezable = new Freezable<int>(expected);
            freezable.Freeze();

            freezable.Value = 456;
            actual = freezable.Value;

            // Assert
            Assert.True(freezable.IsFrozen);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Freezable<System.String> will remain frozen after Freeze called")]
        public void FreezableOfStringWillRemainFrozenAfterFreezeCalled()
        {
            // Arrange
            Freezable<string> freezable;
            string expected = "Hello World";
            string actual;

            // Act
            freezable = new Freezable<string>(expected);
            freezable.Freeze();

            freezable.Value = "Goodbye World";
            actual = freezable.Value;

            // Assert
            Assert.True(freezable.IsFrozen);
            Assert.Equal(expected, actual);
        }
    }
}