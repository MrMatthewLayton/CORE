namespace Core.Validation.Validators
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents an expression based validator.
    /// </summary>
    /// <typeparam name="T">The underlying type of the value to be validated.</typeparam>
    public class ExpressionValidator<T> : Validator<T>
    {
        /// <summary>
        /// The expression that will be used to validate the specified value.
        /// </summary>
        private readonly Expression<Func<T, bool>> expression;

        /// <summary>
        /// Creates a new instance of the <see cref="ExpressionValidator{T}"/> class.
        /// </summary>
        /// <param name="expression">The expression that will be used to validate the specified value.</param>
        public ExpressionValidator(Expression<Func<T, bool>> expression) => this.expression = expression;

        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the specified value is valid; otherwise, false.</returns>
        public override bool IsValid(T value) => expression.Compile().Invoke(value);
    }
}
