using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.ModelInterfaces
{
    public interface IPatient
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        DateTime DateOfBirth { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        Genders Gender { get; set; }
        string IDnumber { get; set; }
        string LastName { get; set; }
        int? MedicalAidPlanID { get; set; }
        string MobileNumber { get; set; }
        int PatientID { get; set; }
        int SuburbID { get; set; }
        string UserID { get; set; }
        string PersonResponsible { get; set; }
    }
}
