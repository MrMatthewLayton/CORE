﻿namespace Core.Design
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents a base class for implementing the specification pattern.
    /// </summary>
    /// <typeparam name="T">The underlying type of the specification implementation.</typeparam>
    public abstract class Specification<T>
    {
        /// <summary>
        /// Provides an empty specification that always returns true.
        /// </summary>
        public static readonly Specification<T> Empty = new EmptySpecification<T>();

        /// <summary>
        /// Determines whether the specification is satisfied by the provided parameter.
        /// </summary>
        /// <param name="item">The parameter to test against the specification.</param>
        /// <returns>True if the item satisfies the specification; otherwise, false.</returns>
        public bool IsSatisfiedBy(T item) => ToExpression().Compile().Invoke(item);

        /// <summary>
        /// Combines this specification with another using a binary AND.
        /// </summary>
        /// <param name="specification">The other specification to combine with this specification.</param>
        /// <returns>A binary AND of the two specifications.</returns>
        public Specification<T> And(Specification<T> specification) => new AndSpecification<T>(this, specification);

        /// <summary>
        /// Combines this specification with another using binary OR.
        /// </summary>
        /// <param name="specification">The other specification to combine with this specification.</param>
        /// <returns>A binary OR of the two specifications.</returns>
        public Specification<T> Or(Specification<T> specification) => new OrSpecification<T>(this, specification);

        /// <summary>
        /// Negates this specification using binary NOT.
        /// </summary>
        /// <returns>A binary NOT negated specification.</returns>
        public Specification<T> Not() => new NotSpecification<T>(this);

        /// <summary>
        /// Provides an expression for the specification.
        /// </summary>
        /// <returns>An expression for the specification.</returns>
        public abstract Expression<Func<T, bool>> ToExpression();
    }
}
