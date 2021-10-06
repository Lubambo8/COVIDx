using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class DependentRelationship
    {
        public DependentRelationship()
        {
            Dependents = new HashSet<Dependent>();
        }

        [Key]
        public int DependentRelationshipID { get; set; }

        [Required,
            MaxLength(128)]
        public string Description { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
