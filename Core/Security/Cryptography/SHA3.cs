namespace Core.Security.Cryptography
{
    using System.Security.Cryptography;

    public abstract class SHA3 : HashAlgorithm
    {
        public static SHA3 CreateKeccak224() => new Keccak224Managed();
        public static SHA3 CreateKeccak256() => new Keccak256Managed();
        public static SHA3 CreateKeccak384() => new Keccak384Managed();
        public static SHA3 CreateKeccak512() => new Keccak512Managed();

        public static SHA3 CreateShake128(int outputLength) => new Shake128Managed(outputLength);
        public static SHA3 CreateShake256(int outputLength) => new Shake256Managed(outputLength);
    }
}
