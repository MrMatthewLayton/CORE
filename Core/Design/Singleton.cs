namespace Core.Design
{
    using System;

    /// <summary>
    /// Represents a generic singleton of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The underlying type that will be represented as a singleton.</typeparam>
    public sealed class Singleton<T> : IEquatable<Singleton<T>>
    {
        /// <summary>
        /// Holds a static, lazily instantiated reference to the <see cref="Singleton{T}"/> instance.
        /// </summary>
        private static readonly Lazy<Singleton<T>> Instance = new Lazy<Singleton<T>>(() => new Singleton<T>());

        /// <summary>
        /// Gets or sets the value of the singleton instance.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton{T}" /> class from being created.
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// Performs implicit conversion between <typeparamref name="T"/> and <see cref="Singleton{T}"/>.
        /// </summary>
        /// <param name="value">The <see cref="Singleton{T}"/> instance to convert.</param>
        /// <returns>A <typeparamref name="T"/> instance.</returns>
        public static implicit operator T(Singleton<T> value)
        {
            return value.Value;
        }

        /// <summary>
        /// Performs implicit conversion between <see cref="Singleton{T}"/> and <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">The <typeparamref name="T"/> instance to convert.</param>
        /// <returns>A <see cref="Singleton{T}"/> instance.</returns>
        public static implicit operator Singleton<T>(T value)
        {
            return GetInstance(value);
        }

        /// <summary>
        /// Gets the singleton instance of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>A singleton instance of type <typeparamref name="T"/>.</returns>
        public static Singleton<T> GetInstance()
        {
            return Instance.Value;
        }

        /// <summary>
        /// Gets the singleton instance of type <typeparamref name="T"/> with the specified value.
        /// </summary>
        /// <param name="value">The value to assign to the singleton instance.</param>
        /// <returns>A singleton instance of type <typeparamref name="T"/> with the specified value.</returns>
        public static Singleton<T> GetInstance(T value)
        {
            Singleton<T> result = GetInstance();
            result.Value = value;
            return result;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(Singleton<T> other)
        {
            return !ReferenceEquals(other, null)
                && ReferenceEquals(other.Value, Value);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
                && Equals(obj as Singleton<T>);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.GetHashCode(Value);
        }
    }
}
