namespace Core.Validation.Validators
{
    public sealed class EqualityValidator<T> : Validator<T>
    {
        private readonly T value;

        public EqualityValidator(T value) => this.value = value;

        public override bool IsValid(T value) => Equals(this.value, value);
    }
}