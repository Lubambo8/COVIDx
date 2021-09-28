using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Config
{
    public class ConnectionStrings : IConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
