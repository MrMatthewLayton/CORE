namespace Core.Security.Cryptography
{
    public sealed class Keccak224Managed : SHA3
    {
        private readonly KeccakSpongeManaged state = new KeccakSpongeManaged(144, 56, KeccakSpongeManaged.KeccakDelimiter, 28);
        
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
