namespace Core.Validation.Validators
{
    using Core.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a validator to determine whether the specified items are contained within an <see cref="IEnumerable{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The underlying type of the <see cref="IEnumerable{T}"/> instance.</typeparam>
    public sealed class EnumerableContainsValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EnumerableContainsValidator{T}"/> class.
        /// </summary>
        /// <param name="items">The items to find in the <see cref="IEnumerable{T}"/> instance.</param>
        public EnumerableContainsValidator(IEnumerable<T> items) : base(value => value.ContainsAll(items))
        {
        }
    }
}
