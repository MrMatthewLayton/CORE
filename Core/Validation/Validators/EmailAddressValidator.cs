namespace Core.Validation.Validators
{
    using System.Net.Mail;

    /// <summary>
    /// Represents a validator to determine whether the specified value is a valid email address.
    /// </summary>
    public sealed class EmailAddressValidator : ExpressionValidator<string>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EmailAddressValidator"/> class.
        /// </summary>
        public EmailAddressValidator() : base(value => IsValidEmailAddress(value))
        {
        }

        /// <summary>
        /// Determines whether the specified value is a valid email address.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is a valid email address; otherwise, false.</returns>
        private static bool IsValidEmailAddress(string value)
        {
            try
            {
                MailAddress address = new MailAddress(value);
                return address.Address == value;
            }
            catch
            {
                return false;
            }
        }
    }
}
