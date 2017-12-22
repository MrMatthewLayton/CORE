namespace Core.Measurement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Represents distance scale.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), ComVisible(true)]
    public struct Distance : IEquatable<Distance>
    {
        /// <summary>
        /// Represents an empty <see cref="Distance"/> value.
        /// </summary>
        public static readonly Distance Empty = default;

        /// <summary>
        /// The underlying distance value.
        /// </summary>
        private double value;

        /// <summary>
        /// Gets the distance in millimeters.
        /// </summary>
        public double Millimeters => value;

        /// <summary>
        /// Gets the distance in centimeters.
        /// </summary>
        public double Centimeters => value / 10;

        /// <summary>
        /// Gets the distance in meters.
        /// </summary>
        public double Meters => value / 1000;

        /// <summary>
        /// Gets the distance in kilometers.
        /// </summary>
        public double Kilometers => value / 1000000;

        /// <summary>
        /// Gets the distance in inches.
        /// </summary>
        public double Inches => value / 25.4;

        /// <summary>
        /// Gets the distance in feet.
        /// </summary>
        public double Feet => value / 304.8;

        /// <summary>
        /// Gets the distance in yards.
        /// </summary>
        public double Yards => value / 914.4;

        /// <summary>
        /// Gets the distance in miles.
        /// </summary>
        public double Miles => value / 1609344;

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance" /> struct.
        /// </summary>
        /// <param name="value">The value in millimeters with which to initialize the instance.</param>
        private Distance(double value) : this()
        {
            this.value = value;
        }

        /// <summary>
        /// Performs an equality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(Distance a, Distance b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Performs an inequality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(Distance a, Distance b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Performs a greater than comparison check between two instances of <see cref="Distance"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than b, otherwise False.</returns>
        public static bool operator >(Distance a, Distance b)
        {
            return a.value > b.value;
        }

        /// <summary>
        /// Performs a less than comparison check between two instances of <see cref="Distance"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than b, otherwise False.</returns>
        public static bool operator <(Distance a, Distance b)
        {
            return a.value < b.value;
        }

        /// <summary>
        /// Performs a greater than or equal to comparison check between two instances of <see cref="Distance"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than or equal to b, otherwise False.</returns>
        public static bool operator >=(Distance a, Distance b)
        {
            return a.value >= b.value;
        }

        /// <summary>
        /// Performs a less than or equal to comparison check between two instances of <see cref="Distance"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than or equal to b, otherwise False.</returns>
        public static bool operator <=(Distance a, Distance b)
        {
            return a.value <= b.value;
        }

        /// <summary>
        /// Adds two instances of Distance together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum addition of two instances of <see cref="Distance"/>.</returns>
        public static Distance operator +(Distance a, Distance b)
        {
            return new Distance(a.value + b.value);
        }

        /// <summary>
        /// Subtracts one instance of Distance from another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum subtraction of two instances of <see cref="Distance"/>.</returns>
        public static Distance operator -(Distance a, Distance b)
        {
            return new Distance(a.value - b.value);
        }

        /// <summary>
        /// Multiplies two instances of Distance together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum multiplication of two instances of <see cref="Distance"/>.</returns>
        public static Distance operator *(Distance a, Distance b)
        {
            return new Distance(a.value * b.value);
        }

        /// <summary>
        /// Divides one instance of Distance from another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum division of two instances of <see cref="Distance"/>.</returns>
        public static Distance operator /(Distance a, Distance b)
        {
            return new Distance(a.value / b.value);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a millimeter value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromMillimeters(double value)
        {
            return new Distance(value);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a centimeter value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromCentimeters(double value)
        {
            return new Distance(value * 10);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a meter value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromMeters(double value)
        {
            return new Distance(value * 1000);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a kilometer value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromKilometers(double value)
        {
            return new Distance(value * 1000000);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from an inch value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromInches(double value)
        {
            return new Distance(value * 25.4);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a feet value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromFeet(double value)
        {
            return new Distance(value * 304.8);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a yard value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromYards(double value)
        {
            return new Distance(value * 914.4);
        }

        /// <summary>
        /// Creates a new <see cref="Distance"/> instance from a mile value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Distance"/> instance.</param>
        /// <returns>A newly created <see cref="Distance"/> instance.</returns>
        public static Distance FromMiles(double value)
        {
            return new Distance(value * 1609344);
        }

        /// <summary>
        /// Adds another <see cref="Distance"/> value to this and returns the value in a new <see cref="Distance"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="Distance"/> value to add to this instance.</param>
        /// <returns>A new <see cref="Distance"/> containing the sum of the two values.</returns>
        public Distance Add(Distance value)
        {
            return new Distance(this.value + value.value);
        }

        /// <summary>
        /// Subtracts another <see cref="Distance"/> value from this and returns the value in a new <see cref="Distance"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="Distance"/> value to subtract from this instance.</param>
        /// <returns>A new <see cref="Distance"/> containing the sum of the two values.</returns>
        public Distance Subtract(Distance value)
        {
            return new Distance(this.value - value.value);
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="other">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public bool Equals(Distance other)
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
                && obj is Distance
                && Equals((Distance)obj);
        }

        /// <summary>
        /// Serves as a hash code function for this instance.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.GetHashCode(value);
        }
    }
}
