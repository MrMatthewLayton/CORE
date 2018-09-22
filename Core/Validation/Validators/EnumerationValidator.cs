namespace Core.Validation.Validators
{
    using System;

    /// <summary>
    /// Represents a validator to determine whether the specified value is defined within an enum type.
    /// </summary>
    /// <typeparam name="T">The underlying enum type.</typeparam>
    public sealed class EnumerationValidator<T> : ExpressionValidator<string> where T : Enum
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EnumerationValidator{T}"/> class.
        /// </summary>
        public EnumerationValidator() : base(value => Enum.IsDefined(typeof(T), value))
        {
        }
    }
}
