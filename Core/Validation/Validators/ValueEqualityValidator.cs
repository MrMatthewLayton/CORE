namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator that determines whether the specified value has value equality with the target value.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to validate.</typeparam>
    public sealed class ValueEqualityValidator<T> : ExpressionValidator<T>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ValueEqualityValidator{T}"/> class.
        /// </summary>
        /// <param name="target">The target value.</param>
        public ValueEqualityValidator(T target) : base(value => Equals(value, target))
        {
        }
    }
}
