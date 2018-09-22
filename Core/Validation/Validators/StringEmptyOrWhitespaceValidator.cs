namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator to determine whether the specified <see cref="string"/> value is empty or whitespace.
    /// </summary>
    public sealed class StringEmptyOrWhitespaceValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringEmptyOrWhitespaceValidator"/> class.
        /// </summary>
        public StringEmptyOrWhitespaceValidator() : base(value => value != null && (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
        {
        }
    }
}
