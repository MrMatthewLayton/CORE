namespace Core.Security.Cryptography
{
    public sealed class Shake128Managed : SHA3
    {
        private readonly KeccakSpongeManaged state;

        public Shake128Managed(int outputLength)
        {
            state = new KeccakSpongeManaged(168, 32, KeccakSpongeManaged.ShakeDelimiter, outputLength);
        }

        public override void Initialize()
        {
            state.Initialize();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            Initialize();
            state.Absorb(array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            return state.Squeeze();
        }
    }
}
