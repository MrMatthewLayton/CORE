namespace Core.Collections.Generic
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Provides extension methods for <see cref="LinkedListNode{T}"/>.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class LinkedListNodeExtensions
    {
        /// <summary>
        /// Determines whether a <see cref="LinkedListNode{T}"/> instance is the first node in a linked list.
        /// </summary>
        /// <typeparam name="T">The underlying type of the <see cref="LinkedListNode{T}"/>.</typeparam>
        /// <param name="node">The <see cref="LinkedListNode{T}"/> instance to test.</param>
        /// <returns>True if the node is the first in the linked list; otherwise, false.</returns>
        public static bool IsFirst<T>(this LinkedListNode<T> node)
        {
            return node.Previous == null;
        }

        /// <summary>
        /// Determines whether a <see cref="LinkedListNode{T}"/> instance is the last node in a linked list.
        /// </summary>
        /// <typeparam name="T">The underlying type of the <see cref="LinkedListNode{T}"/>.</typeparam>
        /// <param name="node">The <see cref="LinkedListNode{T}"/> instance to test.</param>
        /// <returns>True id the node is the first in the linked list; otherwise, false.</returns>
        public static bool IsLast<T>(this LinkedListNode<T> node)
        {
            return node.Next == null;
        }
    }
}
