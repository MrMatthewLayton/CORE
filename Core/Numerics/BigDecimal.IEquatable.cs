namespace Core.Numerics
{
    using System;

    public partial struct BigDecimal : IEquatable<BigDecimal>
    {
        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>true if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
                && obj is BigDecimal
                && Equals((BigDecimal)obj);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="other">The object to compare with the current instance.</param>
        /// <returns>true if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public bool Equals(BigDecimal other)
        {
            return scale == other.scale
                && value == other.value;
        }
    }
}
