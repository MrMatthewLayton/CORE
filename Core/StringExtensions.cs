namespace Core
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Represents <see cref="string"/> extension methods defined by the CORE library.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class StringExtensions
    {
        /// <summary>
        /// Converts this instance to a byte array.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="encoding">The encoding to use for conversion.</param>
        /// <returns>A byte array representation of this string.</returns>
        public static byte[] ToByteArray(this string value, Encoding encoding) => encoding.GetBytes(value);

        /// <summary>
        /// Converts this instance to a byte array using the default encoding.
        /// </summary>
        /// <param name="value">The encoding to use for conversion.</param>
        /// <returns>A byte array representation of this string.</returns>
        public static byte[] ToByteArray(this string value) => value.ToByteArray(Encoding.Default);

        /// <summary>
        /// Formats this instance to a title case string.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="cultureInfo">The culture info to use for formatting.</param>
        /// <returns>A title case representation of the current instance.</returns>
        public static string ToTitleCase(this string value, CultureInfo cultureInfo = null)
        {
            if (cultureInfo == null)
            {
                cultureInfo = CultureInfo.CurrentCulture;
            }

            return cultureInfo.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}
