using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class NurseSuburbsModel : ISuburbsPreferred
    {
        public int[] SelectedSuburbsIds { get; set; }

        public int NurseID { get; set; }

        public int SuburbID { get; set; }

        public AlertModel Alert { get; set; }
    }
}
