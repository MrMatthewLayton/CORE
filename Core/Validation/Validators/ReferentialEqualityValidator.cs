namespace Core.Validation.Validators
{
    public sealed class ReferentialEqualityValidator<T> : ExpressionValidator<T>
    {
        public ReferentialEqualityValidator(T other) : base(value => ReferenceEquals(value, other))
        {
        }
    }
}
