namespace Core.Measurement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Represents temperature scale. The default value is absolute zero, or 0°K.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), ComVisible(true)]
    public struct Temperature : IEquatable<Temperature>
    {
        /// <summary>
        /// Represents an absolute zero (0°K) <see cref="Temperature"/> value.
        /// </summary>
        public static readonly Temperature AbsoluteZero = default;

        /// <summary>
        /// The underlying temperature value.
        /// </summary>
        private double Value { get; set; }

        /// <summary>
        /// Gets the temperature in Celsius.
        /// </summary>
        public double Celsius => Value - 273.15;

        /// <summary>
        /// Gets the temperature in Delisle.
        /// </summary>
        public double Delisle => (373.15F - Value) * 1.50;

        /// <summary>
        /// Gets the temperature in Fahrenheit.
        /// </summary>
        public double Fahrenheit => (Value * 1.80) - 459.67;

        /// <summary>
        /// Gets the temperature in kelvin.
        /// </summary>
        public double Kelvin => Value;

        /// <summary>
        /// Gets the temperature in newton.
        /// </summary>
        public double Newton => (Value - 273.15) * 33.00 / 100.00;

        /// <summary>
        /// Gets the temperature in Reaumur.
        /// </summary>
        public double Reaumur => (Value - 273.15) * 0.80;

        /// <summary>
        /// Gets the temperature in Rankine.
        /// </summary>
        public double Rankine => Value * 1.8;

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature" /> struct.
        /// </summary>
        /// <param name="value">The value in Kelvin with which to initialize the instance.</param>
        private Temperature(double value) : this() => Value = value;

        /// <summary>
        /// Performs an equality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(Temperature a, Temperature b) => a.Equals(b);

        /// <summary>
        /// Performs an inequality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(Temperature a, Temperature b) => !Equals(a, b);

        /// <summary>
        /// Performs a greater than comparison check between two instances of <see cref="Temperature"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than b, otherwise False.</returns>
        public static bool operator >(Temperature a, Temperature b) => a.Value > b.Value;

        /// <summary>
        /// Performs a less than comparison check between two instances of <see cref="Temperature"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than b, otherwise False.</returns>
        public static bool operator <(Temperature a, Temperature b) => a.Value < b.Value;

        /// <summary>
        /// Performs a greater than or equal to comparison check between two instances of <see cref="Temperature"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is greater than or equal to b, otherwise False.</returns>
        public static bool operator >=(Temperature a, Temperature b) => a.Value >= b.Value;

        /// <summary>
        /// Performs a less than or equal to comparison check between two instances of <see cref="Temperature"/>.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if a is less than or equal to b, otherwise False.</returns>
        public static bool operator <=(Temperature a, Temperature b) => a.Value <= b.Value;

        /// <summary>
        /// Adds two instances of Temperature together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum addition of two instances of <see cref="Temperature"/>.</returns>
        public static Temperature operator +(Temperature a, Temperature b) => new Temperature(a.Value + b.Value);

        /// <summary>
        /// Subtracts one instance of Temperature from another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum subtraction of two instances of <see cref="Temperature"/>.</returns>
        public static Temperature operator -(Temperature a, Temperature b) => new Temperature(a.Value - b.Value);

        /// <summary>
        /// Multiplies two instances of Temperature together.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum multiplication of two instances of <see cref="Temperature"/>.</returns>
        public static Temperature operator *(Temperature a, Temperature b) => new Temperature(a.Value * b.Value);

        /// <summary>
        /// Divides one instance of Temperature from another.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>The sum division of two instances of <see cref="Temperature"/>.</returns>
        public static Temperature operator /(Temperature a, Temperature b) => new Temperature(a.Value / b.Value);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Celsius value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromCelsius(double value) => new Temperature(value + 273.15);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Delisle value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromDelisle(double value) => new Temperature(373.15F - (value * (2.00F / 3.00)));

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Fahrenheit value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromFahrenheit(double value) => new Temperature((value + 459.67) / 1.80);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Kelvin value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromKelvin(double value) => new Temperature(value);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Newton value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromNewton(double value) => new Temperature((value * (100.00 / 33.00)) + 273.15);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Reaumur value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromReaumur(double value) => new Temperature((value * 1.25) + 273.15);

        /// <summary>
        /// Creates a new <see cref="Temperature"/> instance from a Rankine value.
        /// </summary>
        /// <param name="value">The value from which to construct the new <see cref="Temperature"/> instance.</param>
        /// <returns>A newly created <see cref="Temperature"/> instance.</returns>
        public static Temperature FromRankine(double value) => new Temperature(value / 1.8);

        /// <summary>
        /// Adds another <see cref="Temperature"/> value to this and returns the value in a new <see cref="Temperature"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="Temperature"/> value to add to this instance.</param>
        /// <returns>A new <see cref="Temperature"/> containing the sum of the two values.</returns>
        public Temperature Add(Temperature value) => new Temperature(Value + value.Value);

        /// <summary>
        /// Subtracts another <see cref="Temperature"/> value from this and returns the value in a new <see cref="Temperature"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="Temperature"/> value to subtract from this instance.</param>
        /// <returns>A new <see cref="Temperature"/> containing the difference of the two values.</returns>
        public Temperature Subtract(Temperature value) => new Temperature(Value - value.Value);

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="other">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public bool Equals(Temperature other) => Value == other.Value;

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="obj">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !(obj is null)
                && obj is Temperature
                && Equals((Temperature)obj);
        }

        /// <summary>
        /// Serves as a hash code function for this instance.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.GetHashCode(Value);
    }
}
