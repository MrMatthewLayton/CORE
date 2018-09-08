namespace Core.Validation.Validators
{
    using System;

    public sealed class LessThanOrEqualToValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public LessThanOrEqualToValidator(T other) : base(value => value.CompareTo(other) < 1)
        {
        }
    }
}
