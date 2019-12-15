using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Repository
{
    using Domain = Person.Domain.Domains;
    public class RelationRepository : BaseRepository<Domain.Relation>, IRelationRepository
    {
        public RelationRepository(IAppDbContext context) : base(context)
        {
                
        }
    }
}
