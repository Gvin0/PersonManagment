using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Domain.Interfaces
{
    public interface IAppDbContext
    {
        int SaveChanges();
    }
}
