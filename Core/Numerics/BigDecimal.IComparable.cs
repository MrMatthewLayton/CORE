namespace Core.Numerics
{
    using System;
    using System.Numerics;

    public partial struct BigDecimal : IComparable, IComparable<BigDecimal>
    {
        /// <summary>
        /// Defines a generalized comparison method that a value type or class implements 
        /// to create a type-specific comparison method for ordering or sorting its instances.
        /// </summary>
        /// <param name="obj">The object to compare to this instance.</param>
        /// <returns>
        /// Less than zero if the current instance precedes the object specified by the CompareTo method in the sort order. 
        /// Zero if the current instance occurs in the same position in the sort order as the object specified by the CompareTo method.
        /// Greater than zero if the current instance follows the object specified by the CompareTo method in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is BigDecimal))
            {
                throw new ArgumentException($"Argument '{nameof(obj)}' must be of type {nameof(BigDecimal)}", nameof(obj));
            }

            return CompareTo((BigDecimal)obj);
        }

        /// <summary>
        /// Defines a generalized comparison method that a value type or class implements 
        /// to create a type-specific comparison method for ordering or sorting its instances.
        /// </summary>
        /// <param name="other">The object to compare to this instance.</param>
        /// <returns>
        /// Less than zero if the current instance precedes the object specified by the CompareTo method in the sort order. 
        /// Zero if the current instance occurs in the same position in the sort order as the object specified by the CompareTo method.
        /// Greater than zero if the current instance follows the object specified by the CompareTo method in the sort order.
        /// </returns>
        public int CompareTo(BigDecimal other)
        {
            int valueComparison = value.CompareTo(other.value);
            int scaleComparison = scale.CompareTo(other.scale);

            if (valueComparison == scaleComparison || scaleComparison == 0)
            {
                return valueComparison;
            }

            BigInteger localScaledValue = BigInteger.Divide(value, BigInteger.Pow(new BigInteger(10), scale));
            BigInteger otherScaledValue = BigInteger.Divide(other.value, BigInteger.Pow(new BigInteger(10), other.scale));

            return localScaledValue.CompareTo(otherScaledValue);
        }
    }
}
