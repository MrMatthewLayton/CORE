namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator to determine whether the specified value is null.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to be validated.</typeparam>
    public sealed class NullityValidator<T> : ExpressionValidator<T>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="NullityValidator{T}"/> class.
        /// </summary>
        public NullityValidator() : base(other => other == null)
        {
        }
    }
}
