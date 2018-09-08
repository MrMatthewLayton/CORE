namespace Core.Validation.Validators
{
    public sealed class StringEmptyOrWhitespaceValidator : ExpressionValidator<string>
    {
        public StringEmptyOrWhitespaceValidator() : base(value => value != null && (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
        {
        }
    }
}
