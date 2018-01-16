namespace Core.Numerics
{
    using System.Numerics;

    public partial struct BigDecimal
    {
        /// <summary>
        /// Performs an equality comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(BigDecimal a, BigDecimal b) => a.Equals(b);

        /// <summary>
        /// Performs an inequality comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(BigDecimal a, BigDecimal b) => !a.Equals(b);

        /// <summary>
        /// Performs a greater than comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if first instance is greater than the second instance; otherwise, false.</returns>
        public static bool operator >(BigDecimal a, BigDecimal b) => a.CompareTo(b) > 0;

        /// <summary>
        /// Performs a greater than or equal to comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is greater than or equal to the second instance; otherwise, false.</returns>
        public static bool operator >=(BigDecimal a, BigDecimal b) => a.CompareTo(b) >= 0;

        /// <summary>
        /// Performs a less than comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if first instance is less than the second instance; otherwise, false.</returns>
        public static bool operator <(BigDecimal a, BigDecimal b) => a.CompareTo(b) < 0;

        /// <summary>
        /// Performs a less than or equal to comparison between two <see cref="BigDecimal"/> instances.
        /// </summary>
        /// <param name="a">The first <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The second <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is less than or equal to the second instance; otherwise, false.</returns>
        public static bool operator <=(BigDecimal a, BigDecimal b) => a.CompareTo(b) <= 0;

        /// <summary>
        /// Performs an equality comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(BigDecimal a, decimal b) => a.Equals(b);

        /// <summary>
        /// Performs an inequality comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(BigDecimal a, decimal b) => !a.Equals(b);

        /// <summary>
        /// Performs a greater than comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the first instance is greater than the second instance; otherwise, false.</returns>
        public static bool operator >(BigDecimal a, decimal b) => a.CompareTo(b) > 0;

        /// <summary>
        /// Performs a greater than or equal to comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the first instance is greater than or equal to the second instance; otherwise, false.</returns>
        public static bool operator >=(BigDecimal a, decimal b) => a.CompareTo(b) >= 0;

        /// <summary>
        /// Performs a less than comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the first instance is less than the second instance; otherwise, false.</returns>
        public static bool operator <(BigDecimal a, decimal b) => a.CompareTo(b) < 0;

        /// <summary>
        /// Performs a less than or equal to comparison between a <see cref="BigDecimal"/> instance and a <see cref="decimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="decimal"/> instance to compare.</param>
        /// <returns>true if the first instance is less than or equal to the second instance; otherwise, false.</returns>
        public static bool operator <=(BigDecimal a, decimal b) => a.CompareTo(b) <= 0;

        /// <summary>
        /// Performs an equality comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(decimal a, BigDecimal b) => a.Equals(b);

        /// <summary>
        /// Performs an inequality comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(decimal a, BigDecimal b) => !a.Equals(b);

        /// <summary>
        /// Performs an greater than comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is greater than the second instance; otherwise, false.</returns>
        public static bool operator >(decimal a, BigDecimal b) => a.CompareTo(b) > 0;

        /// <summary>
        /// Performs an greater than or equal to comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is greater than or equal to the second instance; otherwise, false.</returns>
        public static bool operator >=(decimal a, BigDecimal b) => a.CompareTo(b) >= 0;

        /// <summary>
        /// Performs an less than comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is less than the second instance; otherwise, false.</returns>
        public static bool operator <(decimal a, BigDecimal b) => a.CompareTo(b) < 0;

        /// <summary>
        /// Performs an less than or equal to comparison between a <see cref="decimal"/> instance and a <see cref="BigDecimal"/> instance.
        /// </summary>
        /// <param name="a">The <see cref="decimal"/> instance to compare.</param>
        /// <param name="b">The <see cref="BigDecimal"/> instance to compare.</param>
        /// <returns>true if the first instance is less than or equal to the second instance; otherwise, false.</returns>
        public static bool operator <=(decimal a, BigDecimal b) => a.CompareTo(b) <= 0;

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="BigInteger"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator BigInteger(BigDecimal value)
        {
            var divisor = BigInteger.Pow(new BigInteger(10), value.scale);
            var scaledValue = BigInteger.Divide(value.value, divisor);
            return scaledValue;
        }

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="byte"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator byte(BigDecimal value) => value.ToType<byte>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="sbyte"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator sbyte(BigDecimal value) => value.ToType<sbyte>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="short"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator short(BigDecimal value) => value.ToType<short>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="int"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator int(BigDecimal value) => value.ToType<int>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="long"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator long(BigDecimal value) => value.ToType<long>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator ushort(BigDecimal value) => value.ToType<ushort>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="uint"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator uint(BigDecimal value) => value.ToType<uint>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="ulong"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator ulong(BigDecimal value) => value.ToType<ulong>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="float"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator float(BigDecimal value) => value.ToType<float>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="double"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator double(BigDecimal value) => value.ToType<double>();

        /// <summary>
        /// Provides an explicit type conversion from <see cref="BigDecimal"/> to <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigDecimal"/> instance to convert.</param>
        public static explicit operator decimal(BigDecimal value) => value.ToType<decimal>();

        /// <summary>
        /// Provides an implicit type conversion from <see cref="byte"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="byte"/> value to convert.</param>
        public static implicit operator BigDecimal(byte value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="sbyte"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="sbyte"/> value to convert.</param>
        public static implicit operator BigDecimal(sbyte value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="short"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        public static implicit operator BigDecimal(short value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="int"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="int"/> value to convert.</param>
        public static implicit operator BigDecimal(int value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="long"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="long"/> value to convert.</param>
        public static implicit operator BigDecimal(long value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="ushort"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="ushort"/> value to convert.</param>
        public static implicit operator BigDecimal(ushort value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="uint"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        public static implicit operator BigDecimal(uint value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="ulong"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="ulong"/> value to convert.</param>
        public static implicit operator BigDecimal(ulong value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="float"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="float"/> value to convert.</param>
        public static implicit operator BigDecimal(float value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="double"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="double"/> value to convert.</param>
        public static implicit operator BigDecimal(double value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="decimal"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="decimal"/> value to convert.</param>
        public static implicit operator BigDecimal(decimal value) => new BigDecimal(value);

        /// <summary>
        /// Provides an implicit type conversion from <see cref="BigInteger"/> to <see cref="BigDecimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="BigInteger"/> value to convert.</param>
        public static implicit operator BigDecimal(BigInteger value) => new BigDecimal(value, 0);
    }
}
