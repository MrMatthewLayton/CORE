namespace Core.Security.Cryptography
{
    public sealed class Keccak256Managed : SHA3
    {
        private readonly KeccakSpongeManaged state = new KeccakSpongeManaged(136, 64, KeccakSpongeManaged.KeccakDelimiter, 32);

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
