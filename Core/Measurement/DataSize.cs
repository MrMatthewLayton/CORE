namespace Core.Measurement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Represents data size from bits to Geopbytes.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), ComVisible(true)]
    public struct DataSize : IEquatable<DataSize>
    {
        /// <summary>
        /// Represents an empty <see cref="DataSize"/> value.
        /// </summary>
        public static readonly DataSize Empty = default;

        /// <summary>
        /// The underlying data size value.
        /// </summary>
        private double value;

        /// <summary>
        /// Gets the data size in Bits.
        /// </summary>
        public double Bits => value;

        /// <summary>
        /// Gets the data size in Bytes.
        /// </summary>
        public double Bytes => value / 8;

        /// <summary>
        /// Gets the data size in KiloBits.
        /// </summary>
        public double KiloBits => GetValue(1, false);

        /// <summary>
        /// Gets the data size in KiloBytes.
        /// </summary>
        public double KiloBytes => GetValue(1, true);

        /// <summary>
        /// Gets the data size in MegaBits.
        /// </summary>
        public double MegaBits => GetValue(2, false);

        /// <summary>
        /// Gets the data size in MegaBytes.
        /// </summary>
        public double MegaBytes => GetValue(2, true);

        /// <summary>
        /// Gets the data size in GigaBits.
        /// </summary>
        public double GigaBits => GetValue(3, false);

        /// <summary>
        /// Gets the data size in GigaBytes.
        /// </summary>
        public double GigaBytes => GetValue(3, true);

        /// <summary>
        /// Gets the data size in TeraBits.
        /// </summary>
        public double TeraBits => GetValue(4, false);

        /// <summary>
        /// Gets the data size in TeraBytes.
        /// </summary>
        public double TeraBytes => GetValue(4, true);

        /// <summary>
        /// Gets the data size in PetaBits.
        /// </summary>
        public double PetaBits => GetValue(5, false);

        /// <summary>
        /// Gets the data size in PetaBytes.
        /// </summary>
        public double PetaBytes => GetValue(5, true);

        /// <summary>
        /// Gets the data size in ExaBits.
        /// </summary>
        public double ExaBits => GetValue(6, false);

        /// <summary>
        /// Gets the data size in ExaBytes.
        /// </summary>
        public double ExaBytes => GetValue(6, true);

        /// <summary>
        /// Gets the data size in ZettaBits.
        /// </summary>
        public double ZettaBits => GetValue(7, false);

        /// <summary>
        /// Gets the data size in ZettaBytes.
        /// </summary>
        public double ZettaBytes => GetValue(7, true);

        /// <summary>
        /// Gets the data size in YottaBits.
        /// </summary>
        public double YottaBits => GetValue(8, false);

        /// <summary>
        /// Gets the data size in YottaBytes.
        /// </summary>
        public double YottaBytes => GetValue(8, true);

        /// <summary>
        /// Gets the data size in BrontoBits.
        /// </summary>
        public double BrontoBits => GetValue(9, false);

        /// <summary>
        /// Gets the data size in BrontoBytes.
        /// </summary>
        public double BrontoBytes => GetValue(9, true);

        /// <summary>
        /// Gets the data size in GeopBits.
        /// </summary>
        public double GeopBits => GetValue(10, false);

        /// <summary>
        /// Gets the data size in GeopBytes.
        /// </summary>
        public double GeopBytes => GetValue(10, true);

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSize" /> struct.
        /// </summary>
        /// <param name="value">The value in value in bits with which to initialize the instance.</param>
        private DataSize(double value) : this()
        {
            this.value = value;
        }

        /// <summary>
        /// Performs an equality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(DataSize a, DataSize b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Performs an inequality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(DataSize a, DataSize b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Performs a greater than comparison check between two instances of <see cref="DataSize"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than b, otherwise False.</returns>
        public static bool operator >(DataSize a, DataSize b)
        {
            return a.value > b.value;
        }

        /// <summary>
        /// Performs a less than comparison check between two instances of <see cref="DataSize"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than b, otherwise False.</returns>
        public static bool operator <(DataSize a, DataSize b)
        {
            return a.value < b.value;
        }

        /// <summary>
        /// Performs a greater than or equal to comparison check between two instances of <see cref="DataSize"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than or equal to b, otherwise False.</returns>
        public static bool operator >=(DataSize a, DataSize b)
        {
            return a.value >= b.value;
        }

        /// <summary>
        /// Performs a less than or equal to comparison check between two instances of <see cref="DataSize"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than or equal to b, otherwise False.</returns>
        public static bool operator <=(DataSize a, DataSize b)
        {
            return a.value <= b.value;
        }

        /// <summary>
        /// Adds two instances of <see cref="DataSize"/> together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum addition of two instances of <see cref="DataSize"/>.</returns>
        public static DataSize operator +(DataSize a, DataSize b)
        {
            return new DataSize(a.value + b.value);
        }

        /// <summary>
        /// Subtracts one instance of <see cref="DataSize"/> from another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum subtraction of two instances of <see cref="DataSize"/>.</returns>
        public static DataSize operator -(DataSize a, DataSize b)
        {
            return new DataSize(a.value - b.value);
        }

        /// <summary>
        /// Multiplies two instances of <see cref="DataSize"/> together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum multiplication of two instances of <see cref="DataSize"/>.</returns>
        public static DataSize operator *(DataSize a, DataSize b)
        {
            return new DataSize(a.value * b.value);
        }

        /// <summary>
        /// Divides one instance of <see cref="DataSize"/> by another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum division of two instances of <see cref="DataSize"/>.</returns>
        public static DataSize operator /(DataSize a, DataSize b)
        {
            return new DataSize(a.value / b.value);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a Bits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromBits(double value)
        {
            return new DataSize(value);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a Bytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromBytes(double value)
        {
            return new DataSize(value * 8);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a KiloBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromKiloBits(double value)
        {
            return CreateFromValue(value, 1, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a KiloBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromKiloBytes(double value)
        {
            return CreateFromValue(value, 1, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a MegaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromMegaBits(double value)
        {
            return CreateFromValue(value, 2, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a MegaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromMegaBytes(double value)
        {
            return CreateFromValue(value, 2, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a GigaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromGigaBits(double value)
        {
            return CreateFromValue(value, 3, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a GigaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromGigaBytes(double value)
        {
            return CreateFromValue(value, 3, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a TeraBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromTeraBits(double value)
        {
            return CreateFromValue(value, 4, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a TeraBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromTeraBytes(double value)
        {
            return CreateFromValue(value, 4, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a PetaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromPetaBits(double value)
        {
            return CreateFromValue(value, 5, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a PetaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromPetaBytes(double value)
        {
            return CreateFromValue(value, 5, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a ExaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromExaBits(double value)
        {
            return CreateFromValue(value, 6, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a ExaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromExaBytes(double value)
        {
            return CreateFromValue(value, 6, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a ZettaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromZettaBits(double value)
        {
            return CreateFromValue(value, 7, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a ZettaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromZettaBytes(double value)
        {
            return CreateFromValue(value, 7, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a YottaBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromYottaBits(double value)
        {
            return CreateFromValue(value, 8, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a YottaBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromYottaBytes(double value)
        {
            return CreateFromValue(value, 8, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a BrontoBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromBrontoBits(double value)
        {
            return CreateFromValue(value, 9, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a BrontoBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromBrontoBytes(double value)
        {
            return CreateFromValue(value, 9, true);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a GeopBits value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromGeopBits(double value)
        {
            return CreateFromValue(value, 10, false);
        }

        /// <summary>
        /// Creates a new <see cref="DataSize"/> instance from a GeopBytes value.
        /// </summary>
        /// <param name="value">The value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        public static DataSize FromGeopBytes(double value)
        {
            return CreateFromValue(value, 10, true);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataSize"/> given an initial value.
        /// </summary>
        /// <param name="value">The value from which to construct a new instance.</param>
        /// <param name="power">The power from which to construct a new instance.</param>
        /// <param name="isByteValue">Determines whether the calculation is in bits or bytes.</param>
        /// <returns>A new <see cref="DataSize"/> instance.</returns>
        private static DataSize CreateFromValue(double value, int power, bool isByteValue)
        {
            double divisor = Math.Pow(1024, power);
            if (isByteValue)
            {
                divisor *= 8;
            }

            return new DataSize(value * divisor);
        }

        /// <summary>
        /// Adds another <see cref="DataSize"/> value to this and returns the value in a new <see cref="DataSize"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="DataSize"/> value to add to this instance.</param>
        /// <returns>A new <see cref="DataSize"/> containing the sum of the two values.</returns>
        public DataSize Add(DataSize value)
        {
            return new DataSize(this.value + value.value);
        }

        /// <summary>
        /// Subtracts another <see cref="DataSize"/> value from this and returns the value in a new <see cref="DataSize"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="DataSize"/> value to subtract from this instance.</param>
        /// <returns>A new <see cref="DataSize"/> containing the sum of the two values.</returns>
        public DataSize Subtract(DataSize value)
        {
            return new DataSize(this.value - value.value);
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="other">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public bool Equals(DataSize other)
        {
            return value == other.value;
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="obj">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
                && obj is DataSize
                && Equals((DataSize)obj);
        }

        /// <summary>
        /// Serves as a hash code function for this instance.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.GetHashCode(value);
        }

        /// <summary>
        /// Gets the value of this <see cref="DataSize"/> instance.
        /// </summary>
        /// <param name="power">The power of the calculation to perform</param>
        /// <param name="isByteValue">Determines whether the calculation is in bits or bytes.</param>
        /// <returns>A value containing the result of the calculation.</returns>
        private double GetValue(int power, bool isByteValue)
        {
            double divisor = Math.Pow(1024, power);
            if (isByteValue)
            {
                divisor *= 8;
            }

            return value / divisor;
        }
    }
}
