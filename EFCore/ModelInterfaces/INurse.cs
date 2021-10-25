using System;
using System.Collections.Generic;

namespace EFCore.Model
{
    public interface INurse
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        Genders Gender { get; set; }
        string IDnumber { get; set; }
        string LastName { get; set; }
        string MobileNumber { get; set; }
        int NurseID { get; set; }
        string Qualification { get; set; }
        string Rank { get; set; }
        string UserID { get; set; }
        DateTime YearsQualified { get; set; }
    }
}