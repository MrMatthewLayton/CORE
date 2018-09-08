namespace Core.Validation.Validators
{
    using System;

    public sealed class InclusiveRangeValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public InclusiveRangeValidator(T minimum, T maximum) : base(value => value.CompareTo(minimum) > -1 && value.CompareTo(maximum) < 1)
        {
        }
    }
}
