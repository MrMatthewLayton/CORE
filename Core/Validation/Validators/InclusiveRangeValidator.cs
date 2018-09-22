namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator that determines whether the specified value is inclusively within range.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to validate.</typeparam>
    public sealed class InclusiveRangeValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        /// <summary>
        /// Creates a new instance of the <see cref="InclusiveRangeValidator{T}"/> class.
        /// </summary>
        /// <param name="minimum">The minimum range value.</param>
        /// <param name="maximum">The maximum range value.</param>
        public InclusiveRangeValidator(T minimum, T maximum) : base(value => value.CompareTo(minimum) > -1 && value.CompareTo(maximum) < 1)
        {
        }
    }
}
