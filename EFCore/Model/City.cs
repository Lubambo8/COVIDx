using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class City
    {
        public City()
        {
            Suburbs = new HashSet<Suburb>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Suburb> Suburbs { get; set; }
    }
}
