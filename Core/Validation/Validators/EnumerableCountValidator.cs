namespace Core.Validation.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class EnumerableCountValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        public EnumerableCountValidator(int count) : base(value => value.Count() == count)
        {
        }
    }
}
