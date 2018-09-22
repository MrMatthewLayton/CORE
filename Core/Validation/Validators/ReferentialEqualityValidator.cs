namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator to determine whether the specified value has referential equality with the target value.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to validate.</typeparam>
    public sealed class ReferentialEqualityValidator<T> : ExpressionValidator<T>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ReferentialEqualityValidator{T}"/> class.
        /// </summary>
        /// <param name="target">The target value.</param>
        public ReferentialEqualityValidator(T target) : base(value => ReferenceEquals(value, target))
        {
        }
    }
}
