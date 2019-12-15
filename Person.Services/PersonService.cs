using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services
{
    using Domain = Person.Domain.Domains;
    public class PersonService : BaseService<Domain.Person, IPersonRepository>, IPersonService
    {
        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {

        }
    }
}
