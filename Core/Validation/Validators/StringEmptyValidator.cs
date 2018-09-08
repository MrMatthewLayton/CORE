namespace Core.Validation.Validators
{
    public sealed class StringEmptyValidator : ExpressionValidator<string>
    {
        public StringEmptyValidator() : base(value => value != null && string.IsNullOrEmpty(value))
        {
        }
    }
}
