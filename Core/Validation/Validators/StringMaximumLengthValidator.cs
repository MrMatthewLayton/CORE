namespace Core.Validation.Validators
{
    public sealed class StringMaximumLengthValidator : ExpressionValidator<string>
    {
        public StringMaximumLengthValidator(int maximumLength) : base(value => value.Length <= maximumLength)
        {
        }
    }
}
