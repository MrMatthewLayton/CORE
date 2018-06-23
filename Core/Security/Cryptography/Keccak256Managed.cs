namespace Core.Security.Cryptography
{
    /// <summary>
    /// Computes the SHA3 Keccak 256 hash for the input data using the managed library.
    /// </summary>
    public sealed class Keccak256Managed : SHA3
    {
        /// <summary>
        /// The Keccak sponge instance.
        /// </summary>
        private readonly KeccakSpongeManaged sponge = new KeccakSpongeManaged(136, 64, KeccakSpongeManaged.KeccakDelimiter, 32);

        /// <summary>
        /// Initializes an implementation of the <see cref="Keccak256Managed"/> class.
        /// </summary>
        public override void Initialize() => sponge.Initialize();

        /// <summary>
        /// Routes data written to the object into the hash algorithm for computing the hash.
        /// </summary>
        /// <param name="array">The input to compute the hash code for.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            Initialize();
            sponge.Absorb(array, ibStart, cbSize);
        }

        /// <summary>
        /// Finalizes the hash computation after the last data is processed by the cryptographic stream object.
        /// </summary>
        /// <returns>The computed hash code.</returns>
        protected override byte[] HashFinal() => sponge.Squeeze();
    }
}
