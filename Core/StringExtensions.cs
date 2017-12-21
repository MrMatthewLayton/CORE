namespace Core
{
    using System.ComponentModel;
    using System.Text;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class StringExtensions
    {
        public static byte[] ToByteArray(this string value, Encoding encoding) => encoding.GetBytes(value);
        public static byte[] ToByteArray(this string value) => value.ToByteArray(Encoding.Default);
    }
}
