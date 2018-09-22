namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator to determine whether the specified value is less than or equal to the target value.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to be validated.</typeparam>
    public sealed class LessThanOrEqualToValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        /// <summary>
        /// Creates a new instance of the <see cref="LessThanOrEqualToValidator{T}"/> class.
        /// </summary>
        /// <param name="target">The target value.</param>
        public LessThanOrEqualToValidator(T target) : base(value => value.CompareTo(target) < 1)
        {
        }
    }
}
