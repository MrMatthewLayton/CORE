namespace Core.Validation.Validators
{
    /// <summary>
    /// Represents a validator to determine whether the specified <see cref="string"/> value is less than or equal to the maximum length.
    /// </summary>
    public sealed class StringMaximumLengthValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="StringMaximumLengthValidator"/> class.
        /// </summary>
        /// <param name="maximumLength">The target maximum length of the string.</param>
        public StringMaximumLengthValidator(int maximumLength) : base(value => value.Length <= maximumLength)
        {
        }
    }
}
