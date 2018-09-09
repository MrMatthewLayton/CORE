namespace Core.Validation.Validators
{
    public sealed class StringMinimumLengthValidator : ExpressionValidator<string>
    {
        public StringMinimumLengthValidator(int minimumLength) : base(value => value.Length >= minimumLength)
        {
        }
    }
}
