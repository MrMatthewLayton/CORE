namespace Core.Linq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}" />.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class IEnumerableExtensions
    {
        public static bool ContainsAll<T>(this IEnumerable<T> enumerable, IEnumerable<T> items)
        {
            return !items.Except(enumerable).Any();
        }

        /// <summary>
        /// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The underlying type for the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="enumerable">The <see cref="IEnumerable{T}"/> upon which to invoke the <see cref="Action{T}"/>.</param>
        /// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of the <see cref="IEnumerable{T}"/>.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
            {
                action(item);
            }
        }

        /// <summary>
        /// Converts an <see cref="IEnumerable{T}"/> to a <see cref="LinkedList{T}"/>.
        /// </summary>
        /// <typeparam name="T">The underlying type of the <see cref="IEnumerable{T}"/>.</typeparam>
        /// <param name="enumerable">The <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>A new instance of <see cref="LinkedList{T}"/> containing the values of the <see cref="IEnumerable{T}"/>.</returns>
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> enumerable) => new LinkedList<T>(enumerable);
    }
}
