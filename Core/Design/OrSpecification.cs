namespace Core.Design
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents a binary OR combination of two specifications.
    /// </summary>
    /// <typeparam name="T">The underlying type of the specification.</typeparam>
    internal sealed class OrSpecification<T> : Specification<T>
    {
        /// <summary>
        /// The left hand side of the binary expression.
        /// </summary>
        private readonly Expression<Func<T, bool>> left;

        /// <summary>
        /// The right hand side of the binary expression.
        /// </summary>
        private readonly Expression<Func<T, bool>> right;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrSpecification{T}"/> class.
        /// </summary>
        /// <param name="left">The left hand specification.</param>
        /// <param name="right">The right hand specification.</param>
        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            this.left = left.ToExpression();
            this.right = right.ToExpression();
        }

        /// <summary>
        /// Provides an expression for the specification.
        /// </summary>
        /// <returns>An expression for the specification.</returns>
        public override Expression<Func<T, bool>> ToExpression()
        {
            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(left.Body, right.Body), left.Parameters.Single());
        }
    }
}
