namespace Core.UnitTests.Design
{
    using Core.UnitTests.Candidates.MockData;
    using Core.UnitTests.Candidates.Models;
    using Core.UnitTests.Candidates.Specifications;
    using System;
    using System.Linq;
    using Xunit;

    public sealed class SpecificationTests
    {
        [Fact(DisplayName = "PersonByBirthdaySpecification matches all people by birthday")]
        public void PersonByBirthdaySpecificationMatchesAllPeopleByBirthday()
        {
            // Arrange
            PersonCollection collection = new PersonCollection();
            PersonByBirthdaySpecification specification;
            Person person;

            // Act
            specification = new PersonByBirthdaySpecification(DateTime.Parse("01/02/1953"));
            person = collection.People.SingleOrDefault(p => specification.IsSatisfiedBy(p));

            // Assert
            Assert.Equal("John", person.FirstName);
            Assert.Equal("Smith", person.LastName);
        }
    }
}
