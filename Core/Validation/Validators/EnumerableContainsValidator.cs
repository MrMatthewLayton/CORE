namespace Core.Validation.Validators
{
    using Core.Linq;
    using System.Collections.Generic;

    public sealed class EnumerableContainsValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        public EnumerableContainsValidator(IEnumerable<T> items) : base(value => value.ContainsAll(items))
        {
        }
    }
}
