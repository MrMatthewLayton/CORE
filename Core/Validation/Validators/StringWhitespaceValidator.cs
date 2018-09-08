namespace Core.Validation.Validators
{
    public sealed class StringWhitespaceValidator : ExpressionValidator<string>
    {
        public StringWhitespaceValidator() : base(value => !string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
        {
        }
    }
}
