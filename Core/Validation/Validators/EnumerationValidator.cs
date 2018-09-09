namespace Core.Validation.Validators
{
    using System;

    public sealed class EnumerationValidator<T> : ExpressionValidator<string> where T : Enum
    {
        public EnumerationValidator() : base(value => Enum.IsDefined(typeof(T), value))
        {
        }
    }
}
