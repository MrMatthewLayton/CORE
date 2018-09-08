namespace Core
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    public static class TypeExtensions
    {
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
