namespace Core.Security.Cryptography
{
    internal sealed class SHA3Managed : SHA3
    {
        public SHA3Managed(int rateBytes, int capacityBytes, int delimiter, int outputLength) : base(rateBytes, capacityBytes, delimiter, outputLength)
        {
        }
    }
}
