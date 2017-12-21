namespace Core.Security.Cryptography
{
    using System;
    using System.Linq;

    /// <summary>
    /// Represents a hash.
    /// </summary>
    public sealed class Hash : IEquatable<Hash>
    {
        /// <summary>
        /// The hash data.
        /// </summary>
        private readonly byte[] data;

        /// <summary>
        /// Prevents an instance of <see cref="Hash"/> from being created.
        /// </summary>
        /// <param name="data">The hash data.</param>
        private Hash(byte[] data)
        {
            this.data = data;
        }

        /// <summary>
        /// Performs an equality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(Hash a, Hash b)
        {
            return Equals(a, b);
        }

        /// <summary>
        /// Performs an inequality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(Hash a, Hash b)
        {
            return !Equals(a, b);
        }

        /// <summary>
        /// Creates a <see cref="Hash"/> instance from a <see cref="byte"/> array.
        /// </summary>
        /// <param name="value">The <see cref="byte"/> array to represent as a hash.</param>
        /// <returns>A new <see cref="Hash"/> instance.</returns>
        public static Hash FromBytes(byte[] value)
        {
            return new Hash(value);
        }

        /// <summary>
        /// Converts the string representation of a hash to its <see cref="Hash"/> equivalent.
        /// </summary>
        /// <param name="value">A <see cref="string"/> that contains a hash to convert.</param>
        /// <returns>A new <see cref="Hash"/> instance.</returns>
        public static Hash Parse(string value)
        {
            return new Hash(Enumerable
                .Range(0, value.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(value.Substring(x, 2), 16))
                .ToArray());
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="other">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public bool Equals(Hash other)
        {
            return !ReferenceEquals(other, null)
                && data.SequenceEqual(other.data);
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="obj">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
                && obj is Hash
                && Equals(obj as Hash);
        }

        /// <summary>
        /// Serves as a hash code function for this instance.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.GetHashCode(data);
        }

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the current object.</returns>
        public override string ToString()
        {
            return BitConverter
                .ToString(data)
                .Replace("-", string.Empty)
                .ToLower();
        }

        /// <summary>
        /// Returns a byte array representing this instance.
        /// </summary>
        /// <returns>A byte array.</returns>
        public byte[] ToByteArray()
        {
            new Guid().ToByteArray();
            return data;
        }
    }
}
