namespace Core.Validation.Validators
{
    using System;
    using System.Linq.Expressions;

    public class ExpressionValidator<T> : Validator<T>
    {
        private readonly Expression<Func<T, bool>> expression;

        public ExpressionValidator(Expression<Func<T, bool>> expression) => this.expression = expression;

        public override bool IsValid(T value) => expression.Compile().Invoke(value);
    }
}
