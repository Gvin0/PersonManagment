using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services
{
    using Domain = Person.Domain.Domains;
    public class PhoneNumberService : BaseService<Domain.PhoneNumber, IPhoneNumberRepository>, IPhoneNumberService
    {
        public PhoneNumberService(IPhoneNumberRepository phoneNumberRepository) : base(phoneNumberRepository)
        {

        }
    }
}
