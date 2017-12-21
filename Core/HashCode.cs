namespace Core
{
    using System.Linq;

    /// <summary>
    /// Provides a mechanism for creating object hash codes.
    /// </summary>
    public sealed class HashCode
    {
        /// <summary>
        /// The internal <see cref="HashCode"/> instance.
        /// </summary>
        private static HashCode instance;

        /// <summary>
        /// The hash prime.
        /// </summary>
        private readonly int prime = 16777619;

        /// <summary>
        /// The hash offset.
        /// </summary>
        private readonly int offset = unchecked((int)2166136261);

        /// <summary>
        /// Prevents instances of <see cref="HashCode"/> from being created.
        /// </summary>
        private HashCode()
        {
        }

        /// <summary>
        /// Returns a hash code, computed from the input arguments.
        /// </summary>
        /// <param name="args">The input arguments.</param>
        /// <returns>A hash code.</returns>
        public static int GetHashCode(params object[] args)
        {
            return (instance ?? (instance = new HashCode()))
                .ComputeHash(args.Select(arg => arg.GetHashCode()).ToArray());
        }

        /// <summary>
        /// Computes a hash code from the input arguments, using the FNV-1a algorithm.
        /// </summary>
        /// <param name="args">The input arguments.</param>
        /// <returns>A hash code.</returns>
        private int ComputeHash(int[] args)
        {
            int hash = offset;

            unchecked
            {
                foreach (int arg in args)
                {
                    hash ^= arg;
                    hash *= prime;
                }
            }

            return hash;
        }
    }
}
