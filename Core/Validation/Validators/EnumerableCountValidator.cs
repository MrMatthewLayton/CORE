namespace Core.Validation.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a validator to determine whether an <see cref="IEnumerable{T}"/> instance has an exact number of items.
    /// </summary>
    /// <typeparam name="T">The underlying type of the <see cref="IEnumerable{T}"/> instance.</typeparam>
    public sealed class EnumerableCountValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EnumerableCountValidator{T}"/> class.
        /// </summary>
        /// <param name="count"></param>
        public EnumerableCountValidator(int count) : base(value => value.Count() == count)
        {
        }
    }
}
