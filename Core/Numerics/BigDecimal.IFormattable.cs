namespace Core.Numerics
{
    using System;

    public partial struct BigDecimal : IFormattable
    {
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => ToString("G", null);

        /// <summary>
        /// Formats the value of the current instance using the specified format.
        /// </summary>
        /// <param name="format">The format to use, or a null reference (Nothing in Visual Basic) to use 
        /// the default format defined for the type of the <see cref="IFormattable"/> implementation.</param>
        /// <param name="formatProvider">The provider to use to format the value, or a null reference (Nothing in Visual Basic) 
        /// to obtain the numeric format information from the current locale setting of the operating system.</param>
        /// <returns>he value of the current instance in the specified format.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            string number = value.ToString(format, formatProvider);
            return scale > 0
                ? number.Insert(number.Length - scale, ".")
                : number;
        }
    }
}
