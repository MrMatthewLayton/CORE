namespace Core.UnitTests.Candidates.Specifications
{
    using Core.Design;
    using Core.UnitTests.Candidates.Models;
    using System;
    using System.Linq.Expressions;

    public sealed class PersonByLastNameSpecification : Specification<Person>
    {
        private readonly string lastName;

        public PersonByLastNameSpecification(string lastName)
        {
            this.lastName = lastName;
        }

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.LastName == lastName;
        }
    }
}
