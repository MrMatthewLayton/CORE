namespace Core.Validation.Validators
{
    using System.Text.RegularExpressions;

    public sealed class RegularExpressionValidator : ExpressionValidator<string>
    {
        public RegularExpressionValidator(string pattern) : base(value => new Regex(pattern).IsMatch(value))
        {
        }
    }
}
