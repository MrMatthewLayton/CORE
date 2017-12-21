namespace Core.Design
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents a binary NOT negation of a specification.
    /// </summary>
    /// <typeparam name="T">The underlying type of the specification.</typeparam>
    internal sealed class NotSpecification<T> : Specification<T>
    {
        /// <summary>
        /// The specification expression.
        /// </summary>
        private readonly Expression<Func<T, bool>> expression;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification{T}"/> class.
        /// </summary>
        /// <param name="specification">The specification to negate.</param>
        public NotSpecification(Specification<T> specification)
        {
            expression = specification.ToExpression();
        }

        /// <summary>
        /// Provides an expression for the specification.
        /// </summary>
        /// <returns>An expression for the specification.</returns>
        public override Expression<Func<T, bool>> ToExpression()
        {
            return Expression.Lambda<Func<T, bool>>(Expression.Not(expression), expression.Parameters.Single());
        }
    }
}
