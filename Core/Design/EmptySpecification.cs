namespace Core.Design
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents an empty specification that always returns true.
    /// </summary>
    /// <typeparam name="T">The underlying type of the specification.</typeparam>
    internal sealed class EmptySpecification<T> : Specification<T>
    {
        /// <summary>
        /// Provides an expression for the specification.
        /// </summary>
        /// <returns>An expression for the specification.</returns>
        public override Expression<Func<T, bool>> ToExpression()
        {
            return item => true;
        }
    }
}
