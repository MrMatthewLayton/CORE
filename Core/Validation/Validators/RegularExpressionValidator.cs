namespace Core.Validation.Validators
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a validator to determine whether the specified value matches a regular expression pattern.
    /// </summary>
    public sealed class RegularExpressionValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="RegularExpressionValidator"/> class.
        /// </summary>
        /// <param name="pattern">The regular expression pattern against which to test the value.</param>
        public RegularExpressionValidator(string pattern) : base(value => new Regex(pattern).IsMatch(value))
        {
        }
    }
}
