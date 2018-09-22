namespace Core.Validation.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a validator to determine whether the <see cref="IEnumerable{T}"/> instance is empty.
    /// </summary>
    /// <typeparam name="T">The underlying type of the <see cref="IEnumerable{T}"/> instance.</typeparam>
    public sealed class EnumerableEmptyValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EnumerableEmptyValidator{T}"/> class.
        /// </summary>
        public EnumerableEmptyValidator() : base(value => value.Count() == 0)
        {
        }
    }
}
