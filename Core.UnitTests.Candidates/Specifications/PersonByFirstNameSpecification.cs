namespace Core.UnitTests.Candidates.Specifications
{
    using Core.Design;
    using Core.UnitTests.Candidates.Models;
    using System;
    using System.Linq.Expressions;

    public sealed class PersonByFirstNameSpecification : Specification<Person>
    {
        private readonly string firstName;

        public PersonByFirstNameSpecification(string firstName)
        {
            this.firstName = firstName;
        }

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.FirstName == firstName;
        }
    }
}
