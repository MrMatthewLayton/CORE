namespace Core.UnitTests.Candidates.Models
{
    using System;

    public sealed class Person : IEquatable<Person>
    {
        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthday { get; }

        public bool Equals(Person other)
        {
            return !ReferenceEquals(other, null)
                && FirstName == other.FirstName
                && LastName == other.LastName
                && Birthday == other.Birthday;
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(obj, null)
                && obj is Person
                && Equals(obj as Person);
        }

        public override int GetHashCode() => HashCode.GetHashCode(FirstName, LastName, Birthday);

        public override string ToString() => $"{LastName}, {FirstName} [{Birthday.ToShortDateString()}]";
    }
}
