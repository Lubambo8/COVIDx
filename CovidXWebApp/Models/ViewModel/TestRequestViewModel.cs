using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Models.ViewModel
{
    public class TestRequestViewModel
    {
        [Required]
        public int[] SelectedDependentIds { get; set; }
        // public string SuburbName { get; set; }

        
        public bool testforMyself { get; set; }

        [Required]
        public bool TestAddressSameasMainMember { get; set; }
        [Required]
        public int PatientId { get; set; }
        public int? DependentId { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }


        [Required]
        public string TestAddress1 { get; set; }
        public string TestAddress2 { get; set; }

        [Required]
        public int SuburbId { get; set; }
    }
}
