namespace Core
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Represents <see cref="Type"/> extension methods defined by the CORE library.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class TypeExtensions
    {
        /// <summary>
        /// Searches for a property based on its expression.
        /// </summary>
        /// <typeparam name="TType">The type containing the property.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="type">The type metadata upon which to find the specified property.</param>
        /// <param name="expression">The property expression used to identify the property.</param>
        /// <returns>An instance of <see cref="PropertyInfo"/> if a valid property is found.</returns>
        public static PropertyInfo GetProperty<TType, TProperty>(this Type type, Expression<Func<TType, TProperty>> expression)
        {
            if (!(expression.Body is MemberExpression member))
            {
                throw new ArgumentException($"Expression '{expression}' refers to a method, not a property.");
            }

            if (!(member.Member is PropertyInfo propertyInfo))
            {
                throw new ArgumentException($"Expression '{expression}' refers to a field, not a property.");
            }

            if (type != propertyInfo.ReflectedType && !type.IsSubclassOf(propertyInfo.ReflectedType))
            {
                throw new ArgumentException($"Expression '{expression}' refers to a property that is not from type '{type}'.");
            }

            return propertyInfo;
        }
    }
}
