namespace Core.Validation.Validators
{
    using System.Net.Mail;

    public sealed class EmailAddressValidator : ExpressionValidator<string>
    {
        public EmailAddressValidator() : base(value => IsValidEmailAddress(value))
        {
        }

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
