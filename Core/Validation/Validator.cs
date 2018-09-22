namespace Core.Validation
{
    /// <summary>
    /// Represents the base class for validator implementations.
    /// </summary>
    /// <typeparam name="T">The underlying type to be validated.</typeparam>
    public abstract class Validator<T>
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the specified value is valid; otherwise, false.</returns>
        public abstract bool IsValid(T value);
    }
}
