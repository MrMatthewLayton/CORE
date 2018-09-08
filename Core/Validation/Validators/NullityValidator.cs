namespace Core.Validation.Validators
{
    public sealed class NullityValidator<T> : ExpressionValidator<T>
    {
        public NullityValidator() : base(other => other == null)
        {
        }
    }
}
