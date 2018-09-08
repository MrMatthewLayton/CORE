namespace Core.Validation.Validators
{
    using System;

    public sealed class ExclusiveRangeValidator<T> : ExpressionValidator<T> where T : IComparable
    {
        public ExclusiveRangeValidator(T minimum, T maximum) : base(value => value.CompareTo(minimum) > 0 && value.CompareTo(maximum) < 0)
        {
        }
    }
}
