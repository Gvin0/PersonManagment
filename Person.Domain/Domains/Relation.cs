using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Domain.Domains
{
    public class Relation
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
        public RelationType RelationType { get; set; }
        public virtual Person PersonFrom { get; set; }
        public virtual Person PersonTo { get; set; }       
    }

    public enum RelationType
    {
        Colleague,
        Familiar,
        Relative,
        Other
    }
}
