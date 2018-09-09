namespace Core.Validation.Validators
{
    using System.Linq;

    public sealed class LuhnValidator : ExpressionValidator<string>
    {
        public LuhnValidator() : base(value => IsValidLuhnChecksum(value))
        {
        }

        private static bool IsValidLuhnChecksum(string value)
        {
            return value.All(char.IsDigit) && value.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0 ? thisNum : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum))
                .Sum() % 10 == 0;
        }
    }
}
