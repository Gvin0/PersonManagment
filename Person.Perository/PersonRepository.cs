using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository
{
    using Domain = Person.Domain.Domains;
    public class PersonRepository : BaseRepository<Domain.Person>, IPersonRepository
    {
        public PersonRepository(IAppDbContext context) : base(context)
        {

        }
    }
}
