namespace Core.Validation.Validators
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class EnumerableEmptyValidator<T> : ExpressionValidator<IEnumerable<T>>
    {
        public EnumerableEmptyValidator() : base(value => value.Count() == 0)
        {
        }
    }
}
