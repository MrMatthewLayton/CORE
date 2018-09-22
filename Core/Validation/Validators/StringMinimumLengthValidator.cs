namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator that determines whether the specified <see cref="string"/> value is greater than or equal to the minimum length.
    /// </summary>
    public sealed class StringMinimumLengthValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringMinimumLengthValidator"/> class.
        /// </summary>
        /// <param name="minimumLength">The target minimum length of the string.</param>
        public StringMinimumLengthValidator(int minimumLength) : base(value => value.Length >= minimumLength)
        {
        }
    }
}
