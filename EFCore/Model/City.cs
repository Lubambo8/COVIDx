using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class City
    {
        public City()
        {
            Suburbs = new HashSet<Suburb>();
        }

        [Key]
        public int CityId { get; set; }

        [Required,
            MaxLength(128)]
        public string CityName { get; set; }

        public virtual ICollection<Suburb> Suburbs { get; set; }
    }
}
