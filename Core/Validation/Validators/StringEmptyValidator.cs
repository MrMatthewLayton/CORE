namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator that determines whether the given <see cref="string"/> value is empty.
    /// </summary>
    public sealed class StringEmptyValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringEmptyValidator"/> class.
        /// </summary>
        public StringEmptyValidator() : base(value => value != null && string.IsNullOrEmpty(value))
        {
        }
    }
}
