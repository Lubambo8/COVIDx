using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class Suburb
    {
        public int SuburbID { get; set; }
        public string SuburbName { get; set; }
        public string PostalCode { get; set; }
        public int CityID { get; set; }
    }
}
