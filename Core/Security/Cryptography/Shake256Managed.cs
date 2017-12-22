namespace Core.Security.Cryptography
{
    public sealed class Shake256Managed : SHA3
    {
        private readonly KeccakSpongeManaged state;

        public Shake256Managed(int outputLength)
        {
            state = new KeccakSpongeManaged(136, 64, KeccakSpongeManaged.ShakeDelimiter, outputLength);
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
