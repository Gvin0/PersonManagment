using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services
{
    using Domain = Person.Domain.Domains;
    public class RelationService : BaseService<Domain.Relation, IRelationRepository>, IRelationService
    {
        public RelationService(IRelationRepository relationRepository) : base(relationRepository)
        {
                
        }
    }
}
