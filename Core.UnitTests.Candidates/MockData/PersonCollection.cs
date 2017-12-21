namespace Core.UnitTests.Candidates.MockData
{
    using Core.UnitTests.Candidates.Models;
    using System;
    using System.Collections.Generic;

    public sealed class PersonCollection
    {
        private readonly List<Person> people = new List<Person>();

        public PersonCollection()
        {
            people.Add(new Person("John", "Smith", DateTime.Parse("01/02/1953")));
            people.Add(new Person("Jane", "Smith", DateTime.Parse("02/03/1965")));
            people.Add(new Person("Jack", "Smith", DateTime.Parse("16/04/1993")));
            people.Add(new Person("Jill", "Smith", DateTime.Parse("31/05/2005")));

            people.Add(new Person("John", "Doe", DateTime.Parse("01/02/1853")));
            people.Add(new Person("Jane", "Doe", DateTime.Parse("02/03/1965")));
            people.Add(new Person("Jack", "Doe", DateTime.Parse("16/04/1993")));
            people.Add(new Person("Jill", "Doe", DateTime.Parse("31/05/2005")));
        }

        public IEnumerable<Person> People => people;
    }
}
