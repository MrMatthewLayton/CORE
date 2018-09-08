namespace Core.Validation.Validators
{
    public sealed class StringLengthValidator : ExpressionValidator<string>
    {
        public StringLengthValidator(int length) : base(value => value != null && value.Length == length)
        {
        }
    }
}
