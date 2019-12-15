using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository
{
    using Domain = Person.Domain.Domains;
    public class PhoneNumberRepository : BaseRepository<Domain.PhoneNumber>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(IAppDbContext context) : base(context)
        {
                
        }
    }
}
