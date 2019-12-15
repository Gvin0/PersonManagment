using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Domain.Interfaces
{
    using Domain = Person.Domain.Domains;
    public interface IPhoneNumberRepository : IBaseRepository<Domain.PhoneNumber>
    {
    }
}
