namespace Core.Validation.Validators
{
    using System;

    public sealed class LessThanValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public LessThanValidator(T other) : base(value => value.CompareTo(other) == -1)
        {
        }
    }
}
