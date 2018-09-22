namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator that determines whether the specified <see cref="string"/> value is whitespace.
    /// </summary>
    public sealed class StringWhitespaceValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringWhitespaceValidator"/> class.
        /// </summary>
        public StringWhitespaceValidator() : base(value => !string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
        {
        }
    }
}
