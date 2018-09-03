namespace Core.Validation.Validators
{
    public sealed class NullityValidator<T> : Validator<T>
    {
        public override bool IsValid(T value) => value == null;
    }
}
