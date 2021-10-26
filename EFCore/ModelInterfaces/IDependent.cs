using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.ModelInterfaces
{
    public interface IDependent
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        int DependentID { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        Genders Gender { get; set; }
        string LastName { get; set; }
        string MobileNumber { get; set; }
        int MainMemberID { get; set; }

        Relationships Relationship { get; set; }
        int? SuburbID { get; set; }
    }
}
