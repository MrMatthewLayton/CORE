namespace Core.UnitTests.Collections.Generic
{
    using Core.Collections.Generic;
    using System.Collections.Generic;
    using Xunit;

    public sealed class LinkedListNodeExtensionTests
    {
        [Fact(DisplayName = "LinkedListNodeExtensions.IsFirst is true for the first element of the list")]
        public void IsFirstIsTrueForTheFirstElementOfTheList()
        {
            // Arrange
            LinkedList<string> list;
            LinkedListNode<string> node;
            bool result;

            // Act
            list = new LinkedList<string>(new string[] { "One", "Two", "Three" });
            node = list.First;
            result = node.IsFirst();

            // Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "LinkedListNodeExtensions.IsLast points to the last element of the list")]
        public void IsLastIsTrueForTheLastElementOfTheList()
        {
            // Arrange
            LinkedList<string> list;
            LinkedListNode<string> node;
            bool result;

            // Act
            list = new LinkedList<string>(new string[] { "One", "Two", "Three" });
            node = list.Last;
            result = node.IsLast();

            // Assert
            Assert.True(result);
        }
    }
}
