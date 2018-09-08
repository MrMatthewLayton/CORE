namespace Core.Validation.Validators
{
    using System;

    public sealed class GreaterThanValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public GreaterThanValidator(T other) : base(value => value.CompareTo(other) == 1)
        {
        }
    }
}
