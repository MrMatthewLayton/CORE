namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator that determines whether the specified <see cref="string"/> value is of the specified length.
    /// </summary>
    public sealed class StringLengthValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringLengthValidator"/> class.
        /// </summary>
        /// <param name="length">The target length of the string.</param>
        public StringLengthValidator(int length) : base(value => value != null && value.Length == length)
        {
        }
    }
}
