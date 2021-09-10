using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Relationship
    {
        public Relationship()
        {
            Dependents = new HashSet<Dependent>();
        }

        public int RelationshipTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
