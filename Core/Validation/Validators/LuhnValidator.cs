namespace Core.Validation.Validators
{
    using System.Linq;

    /// <summary>
    /// Represents a validator to determine whether the specified value passes a Luhn (Mod10) check.
    /// </summary>
    public sealed class LuhnValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="LuhnValidator"/> class.
        /// </summary>
        public LuhnValidator() : base(value => IsValidLuhnChecksum(value))
        {
        }

        /// <summary>
        /// Determines whether the specified value passes a Luhn (Mod10) check.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value passes the Luhn (Mod10) check; otherwise, false.</returns>
        private static bool IsValidLuhnChecksum(string value)
        {
            return value.All(char.IsDigit) && value.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0 ? thisNum : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum))
                .Sum() % 10 == 0;
        }
    }
}
