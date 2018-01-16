namespace Core.Numerics
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Represents an arbitrarily large decimal number.
    /// </summary>
    public partial struct BigDecimal
    {
        /// <summary>
        /// Gets a value that represents the number negative one (-1).
        /// </summary>
        public static readonly BigDecimal MinusOne = new BigDecimal(BigInteger.MinusOne, 0);

        /// <summary>
        /// Gets a value that represents the number 0 (zero).
        /// </summary>
        public static readonly BigDecimal Zero = new BigDecimal(BigInteger.Zero, 0);

        /// <summary>
        /// Gets a value that represents the number one (1).
        /// </summary>
        public static readonly BigDecimal One = new BigDecimal(BigInteger.One, 0);

        /// <summary>
        /// The underlying unscaled value.
        /// </summary>
        private readonly BigInteger value;

        /// <summary>
        /// The underlying value scale.
        /// </summary>
        private readonly int scale;

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The unscaled value.</param>
        /// <param name="scale">The scale of the value.</param>
        public BigDecimal(BigInteger value, int scale)
        {
            this.value = value;
            this.scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="decimal"/> value with which to initialize a new instance.</param>
        public BigDecimal(decimal value)
        {
            var bytes = FromDecimal(value);

            var unscaledValueBytes = new byte[12];
            Array.Copy(bytes, unscaledValueBytes, unscaledValueBytes.Length);

            var unscaledValue = new BigInteger(unscaledValueBytes);
            var scale = bytes[14];

            if (bytes[15] == 128)
            {
                unscaledValue *= BigInteger.MinusOne;
            }

            this.value = unscaledValue;
            this.scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="byte"/> array value with which to initialize a new instance.</param>
        public BigDecimal(byte[] value)
        {
            byte[] number = new byte[value.Length - 4];
            byte[] flags = new byte[4];

            Array.Copy(value, 0, number, 0, number.Length);
            Array.Copy(value, value.Length - 4, flags, 0, 4);

            this.value = new BigInteger(number);
            scale = BitConverter.ToInt32(flags, 0);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="int"/> value with which to initialize a new instance.</param>
        public BigDecimal(int value, int scale) : this(new BigInteger(value), scale)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="long"/> value with which to initialize a new instance.</param>
        public BigDecimal(long value) : this(new BigInteger(value), 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value with which to initialize a new instance.</param>
        public BigDecimal(uint value) : this(new BigInteger(value), 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="ulong"/> value with which to initialize a new instance.</param>
        public BigDecimal(ulong value) : this(new BigInteger(value), 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="double"/> value with which to initialize a new instance.</param>
        public BigDecimal(double value) : this((decimal)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigDecimal"/> class.
        /// </summary>
        /// <param name="value">The <see cref="float"/> value with which to initialize a new instance.</param>
        public BigDecimal(float value) : this((decimal)value)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the underlying value is even.
        /// </summary>
        public bool IsEven => value.IsEven;

        /// <summary>
        /// Gets a value indicating whether the underlying value is one (1).
        /// </summary>
        public bool IsOne => value.IsOne;

        /// <summary>
        /// Gets a value indicating whether the underlying value is a power of two.
        /// </summary>
        public bool IsPowerOfTwo => value.IsPowerOfTwo;

        /// <summary>
        /// Gets a value indicating whether the underlying value is zero (0).
        /// </summary>
        public bool IsZero => value.IsZero;

        /// <summary>
        /// Gets the sign of the underlying value.
        /// </summary>
        public int Sign => value.Sign;

        /// <summary>
        /// Converts a <see cref="decimal"/> value to a <see cref="byte"/> array.
        /// </summary>
        /// <param name="d">The <see cref="decimal"/> value to convert.</param>
        /// <returns>A new <see cref="byte"/> array representation of the input value.</returns>
        private static byte[] FromDecimal(decimal d)
        {
            byte[] bytes = new byte[16];
            int[] bits = decimal.GetBits(d);
            int lo = bits[0];
            int mid = bits[1];
            int hi = bits[2];
            int flags = bits[3];

            bytes[00] = (byte)lo;
            bytes[01] = (byte)(lo >> 8);
            bytes[02] = (byte)(lo >> 0x10);
            bytes[03] = (byte)(lo >> 0x18);
            bytes[04] = (byte)mid;
            bytes[05] = (byte)(mid >> 8);
            bytes[06] = (byte)(mid >> 0x10);
            bytes[07] = (byte)(mid >> 0x18);
            bytes[08] = (byte)hi;
            bytes[09] = (byte)(hi >> 8);
            bytes[10] = (byte)(hi >> 0x10);
            bytes[11] = (byte)(hi >> 0x18);
            bytes[12] = (byte)flags;
            bytes[13] = (byte)(flags >> 8);
            bytes[14] = (byte)(flags >> 0x10);
            bytes[15] = (byte)(flags >> 0x18);

            return bytes;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.GetHashCode(value, scale);

        /// <summary>
        /// Returns a <see cref="byte"/> array representation of this instance.
        /// </summary>
        /// <returns>A <see cref="byte"/> array representation of this instance.</returns>
        public byte[] ToByteArray()
        {
            byte[] valueBytes = value.ToByteArray();
            byte[] scaleBytes = BitConverter.GetBytes(scale);

            byte[] result = new byte[valueBytes.Length + scaleBytes.Length];

            Array.Copy(valueBytes, 0, result, 0, valueBytes.Length);
            Array.Copy(scaleBytes, 0, result, valueBytes.Length, scaleBytes.Length);

            return result;
        }

        /// <summary>
        /// Converts this instance to an instance of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type to convert to.</typeparam>
        /// <returns>An instance of <typeparamref name="T"/>.</returns>
        private T ToType<T>() where T : struct
        {
            return (T)((IConvertible)this).ToType(typeof(T), null);
        }
    }
}
