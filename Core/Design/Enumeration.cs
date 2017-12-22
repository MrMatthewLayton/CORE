namespace Core.Design
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Represents a base class for implementing the strongly typed enumeration pattern.
    /// </summary>
    public abstract class Enumeration : IComparable, IComparable<Enumeration>, IEquatable<Enumeration>
    {
        /// <summary>
        /// The enumeration value.
        /// </summary>
        private readonly int value;

        /// <summary>
        /// The enumeration name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumeration"/> class.
        /// </summary>
        /// <param name="value">The enumeration value.</param>
        /// <param name="name">The  enumeration name.</param>
        protected Enumeration(int value, string name)
        {
            this.value = value;
            this.name = name;
        }

        /// <summary>
        /// Gets or sets the value of the enumeration.
        /// </summary>
        public int Value => value;

        /// <summary>
        /// Gets or sets the name of the enumeration.
        /// </summary>
        public string Name => name;

        /// <summary>
        /// Performs an equality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public static bool operator ==(Enumeration a, Enumeration b)
        {
            return Equals(a, b);
        }

        /// <summary>
        /// Performs an inequality check between two object instances.
        /// </summary>
        /// <param name="a">Instance a.</param>
        /// <param name="b">Instance b.</param>
        /// <returns>True if the instances are not equal; otherwise, false.</returns>
        public static bool operator !=(Enumeration a, Enumeration b)
        {
            return !Equals(a, b);
        }

        /// <summary>
        /// Gets all of the publicly visible enumeration members for a given enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <returns>A collection of enumeration members.</returns>
        public static IEnumerable<TEnum> GetMembers<TEnum>() where TEnum : Enumeration
        {
            return typeof(TEnum)
                .GetTypeInfo()
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(field => field.GetValue(null) as TEnum);
        }

        /// <summary>
        /// Gets all the publicly visible enumeration names for a given enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <returns>A collection of enumeration names.</returns>
        public static IEnumerable<string> GetNames<TEnum>() where TEnum : Enumeration
        {
            return GetMembers<TEnum>().Select(enumeration => enumeration.name);
        }

        /// <summary>
        /// Gets the name associated with the specified value for a given enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="value">The value for which to get the associated name.</param>
        /// <returns>The name of the given enumeration.</returns>
        public static string GetName<TEnum>(int value) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().SingleOrDefault(enumeration => enumeration.value == value)?.name;
        }

        /// <summary>
        /// Gets all the publicly visible enumeration values for a given enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <returns>A collection of enumeration values.</returns>
        public static IEnumerable<int> GetValues<TEnum>() where TEnum : Enumeration
        {
            return GetMembers<TEnum>().Select(enumeration => enumeration.value);
        }

        /// <summary>
        /// Gets the value associated with the specified name for a given enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="name">The name for which to get the associated value.</param>
        /// <returns>The value of the given enumeration.</returns>
        public static int GetValue<TEnum>(string name) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().SingleOrDefault(enumeration => enumeration.name == name)?.value ?? default;
        }

        /// <summary>
        /// Determines whether an enumeration value is defined.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is defined by the enumeration; otherwise, false.</returns>
        public static bool IsDefined<TEnum>(int value) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().Any(enumeration => enumeration.value == value);
        }

        /// <summary>
        /// Determines whether an enumeration name is defined.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="name">The name to check.</param>
        /// <returns>True if the name is defined by the enumeration; otherwise, false.</returns>
        public static bool IsDefined<TEnum>(string name) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().Any(enumeration => enumeration.name == name);
        }

        /// <summary>
        /// Parses a value to an enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="value">The value to parse.</param>
        /// <returns>An enumeration instance if one exists for the specified value; otherwise, false.</returns>
        public static TEnum Parse<TEnum>(int value) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().SingleOrDefault(enumeration => enumeration.value == value);
        }

        /// <summary>
        /// Parses a name to an enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="name">The name to parse.</param>
        /// <returns>An enumeration instance if one exists for the specified name; otherwise, false.</returns>
        public static TEnum Parse<TEnum>(string name) where TEnum : Enumeration
        {
            return GetMembers<TEnum>().SingleOrDefault(enumeration => enumeration.name == name);
        }

        /// <summary>
        /// Attempts to parse the specified value into an enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="value">The value to parse.</param>
        /// <param name="result">The resulting enumeration if the parse succeeds.</param>
        /// <returns>True if parsing the value into an enumeration type succeeds; otherwise, false.</returns>
        public static bool TryParse<TEnum>(int value, out TEnum result) where TEnum : Enumeration
        {
            result = Parse<TEnum>(value);
            return result != null;
        }

        /// <summary>
        /// Attempts to parse the specified name into an enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="name">The name to parse.</param>
        /// <param name="result">The resulting enumeration if the parse succeeds.</param>
        /// <returns>True if parsing the name into an enumeration type succeeds; otherwise, false.</returns>
        public static bool TryParse<TEnum>(string name, out TEnum result) where TEnum : Enumeration
        {
            result = Parse<TEnum>(name);
            return result != null;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns 
        /// an integer that indicates whether the current instance precedes, follows, or 
        /// occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. 
        /// The return value has these meanings: Value Meaning Less than zero This instance precedes obj in the sort order. 
        /// Zero This instance occurs in the same position in the sort order as obj. Greater than zero This instance follows obj in the sort order.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when the obj argument is not the same type as this instance.</exception>
        public int CompareTo(object obj)
        {
            Enumeration enumeration = obj as Enumeration;

            if (ReferenceEquals(obj, null))
            {
                return 1;
            }

            if (ReferenceEquals(enumeration, null))
            {
                throw new ArgumentException($"Object is not of type {nameof(Enumeration)}");
            }

            return value.CompareTo(enumeration.value);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns 
        /// an integer that indicates whether the current instance precedes, follows, or 
        /// occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. 
        /// The return value has these meanings: Value Meaning Less than zero This instance precedes obj in the sort order. 
        /// Zero This instance occurs in the same position in the sort order as obj. Greater than zero This instance follows obj in the sort order.
        /// </returns>
        public int CompareTo(Enumeration other)
        {
            return ReferenceEquals(other, null) ? 1 : value.CompareTo(other.value);
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="obj">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
               && obj is Enumeration
               && Equals(obj as Enumeration);
        }

        /// <summary>
        /// Checks for equality between this instance and another object.
        /// </summary>
        /// <param name="other">The object to check for equality.</param>
        /// <returns>true if the object is equal to this instance; otherwise, false.</returns>
        public bool Equals(Enumeration other)
        {
            return !ReferenceEquals(other, null)
                && value == other.value
                && name == other.name;
        }

        /// <summary>
        /// Serves as a hash code function for this instance.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
