namespace Core.Validation.Validators
{
    using System;

    public sealed class GreaterThanOrEqualToValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public GreaterThanOrEqualToValidator(T other) : base(value => value.CompareTo(other) > -1)
        {
        }
    }
}
