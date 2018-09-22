namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator to determine whether the specified value is exclusively within range.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to be validated.</typeparam>
    public sealed class ExclusiveRangeValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ExclusiveRangeValidator{T}"/> class.
        /// </summary>
        /// <param name="minimum">The minimum range value.</param>
        /// <param name="maximum">The maximum range value.</param>
        public ExclusiveRangeValidator(T minimum, T maximum) : base(value => value.CompareTo(minimum) > 0 && value.CompareTo(maximum) < 0)
        {
        }
    }
}
