namespace Core.Security.Cryptography
{
    using System.Security.Cryptography;

    /// <summary>
    /// Computes the SHA3 hash for the input data.
    /// </summary>
    public abstract class SHA3 : HashAlgorithm
    {
        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Keccak 224.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Keccak 224.</returns>
        public static SHA3 CreateKeccak224() => new Keccak224Managed();

        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Keccak 256.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Keccak 256.</returns>
        public static SHA3 CreateKeccak256() => new Keccak256Managed();

        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Keccak 384.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Keccak 384.</returns>
        public static SHA3 CreateKeccak384() => new Keccak384Managed();

        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Keccak 512.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Keccak 512.</returns>
        public static SHA3 CreateKeccak512() => new Keccak512Managed();

        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Shake 128.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Shake 128.</returns>
        public static SHA3 CreateShake128(int outputLength) => new Shake128Managed(outputLength);

        /// <summary>
        /// Creates an instance of the default implementation of SHA3 Shake 256.
        /// </summary>
        /// <returns>A new instance of the default implementation of SHA3 Shake 256.</returns>
        public static SHA3 CreateShake256(int outputLength) => new Shake256Managed(outputLength);
    }
}
