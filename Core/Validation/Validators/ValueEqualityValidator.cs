namespace Core.Validation.Validators
{
    public sealed class ValueEqualityValidator<T> : ExpressionValidator<T>
    {
        public ValueEqualityValidator(T other) : base(value => Equals(value, other))
        {
        }
    }
}
