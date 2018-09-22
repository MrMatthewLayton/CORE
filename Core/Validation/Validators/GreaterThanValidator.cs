namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator that determines whether the specified value is greater than the target value.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to be validated.</typeparam>
    public sealed class GreaterThanValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        /// <summary>
        /// Creates a new instance of the <see cref="GreaterThanValidator{T}"/> class.
        /// </summary>
        /// <param name="target">The target value.</param>
        public GreaterThanValidator(T target) : base(value => value.CompareTo(target) == 1)
        {
        }
    }
}
