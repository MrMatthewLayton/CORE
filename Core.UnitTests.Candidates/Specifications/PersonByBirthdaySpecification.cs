namespace Core.UnitTests.Candidates.Specifications
{
    using Core.Design;
    using Core.UnitTests.Candidates.Models;
    using System;
    using System.Linq.Expressions;

    public sealed class PersonByBirthdaySpecification : Specification<Person>
    {
        private readonly DateTime birthday;

        public PersonByBirthdaySpecification(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.Birthday == birthday;
        }
    }
}
