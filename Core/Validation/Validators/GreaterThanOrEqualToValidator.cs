namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator to determine whether the specified value is greater than or equal to the target value.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to validate.</typeparam>
    public sealed class GreaterThanOrEqualToValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        /// <summary>
        /// Creates a new instance of the <see cref="GreaterThanOrEqualToValidator{T}"/> class.
        /// </summary>
        /// <param name="target">The target value.</param>
        public GreaterThanOrEqualToValidator(T target) : base(value => value.CompareTo(target) > -1)
        {
        }
    }
}
