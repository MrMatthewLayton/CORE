namespace Core.Numerics
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public partial struct BigDecimal : IConvertible
    {
        /// <summary>
        /// Returns the <see cref="TypeCode"/> for this instance.
        /// </summary>
        /// <returns>The <see cref="TypeCode"/> for this instance.</returns>
        TypeCode IConvertible.GetTypeCode() => TypeCode.Object;

        /// <summary>
        /// Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A Boolean value equivalent to the value of this instance.</returns>
        bool IConvertible.ToBoolean(IFormatProvider provider) => Convert.ToBoolean(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
        byte IConvertible.ToByte(IFormatProvider provider) => Convert.ToByte(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A Unicode character equivalent to the value of this instance.</returns>
        char IConvertible.ToChar(IFormatProvider provider) => throw new InvalidCastException($"Cannot cast '{nameof(BigDecimal)}' to '{nameof(Char)}'");

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="DateTime"/> using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A <see cref="DateTime"/> instance equivalent to the value of this instance.</returns>
        DateTime IConvertible.ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Cannot cast '{nameof(BigDecimal)}' to '{nameof(DateTime)}'");

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="decimal"/> number using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A <see cref="decimal"/> number equivalent to the value of this instance.</returns>
        decimal IConvertible.ToDecimal(IFormatProvider provider) => Convert.ToDecimal(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
        double IConvertible.ToDouble(IFormatProvider provider) => Convert.ToDouble(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 16-bit signed integer equivalent to the value of this instance.</returns>
        short IConvertible.ToInt16(IFormatProvider provider) => Convert.ToInt16(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 32-bit signed integer equivalent to the value of this instance.</returns>
        int IConvertible.ToInt32(IFormatProvider provider) => Convert.ToInt32(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
        long IConvertible.ToInt64(IFormatProvider provider) => Convert.ToInt64(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
        sbyte IConvertible.ToSByte(IFormatProvider provider) => Convert.ToSByte(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
        float IConvertible.ToSingle(IFormatProvider provider) => Convert.ToSingle(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent <see cref="string"/> using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A <see cref="string"/> instance equivalent to the value of this instance.</returns>
        string IConvertible.ToString(IFormatProvider provider) => Convert.ToString(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the value of this instance.</returns>
        ushort IConvertible.ToUInt16(IFormatProvider provider) => Convert.ToUInt16(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the value of this instance.</returns>
        uint IConvertible.ToUInt32(IFormatProvider provider) => Convert.ToUInt32(this);

        /// <summary>
        /// Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>A 64-bit unsigned integer equivalent to the value of this instance.</returns>
        ulong IConvertible.ToUInt64(IFormatProvider provider) => Convert.ToUInt64(this);

        /// <summary>
        /// Converts the value of this instance to an <see cref="object"/> of the specified <see cref="Type"/> that has an equivalent value, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="conversionType">The <see cref="Type"/> to which the value of this instance is converted.</param>
        /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
        /// <returns>An <see cref="object"/> instance of type conversionType whose value is equivalent to the value of this instance.</returns>
        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            BigInteger divisor = BigInteger.Pow(new BigInteger(10), scale);
            BigInteger remainder = BigInteger.Remainder(value, divisor);
            BigInteger scaledValue = BigInteger.Divide(value, divisor);

            if (scaledValue > new BigInteger(decimal.MaxValue))
            {
                throw new ArgumentOutOfRangeException($"The value is too large to fit into type '{conversionType.Name}'");
            }

            decimal left = (decimal)scaledValue;
            decimal right = ((decimal)remainder) / ((decimal)divisor);

            return Convert.ChangeType(left + right, conversionType);
        }
    }
}
