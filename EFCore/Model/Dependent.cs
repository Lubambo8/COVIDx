using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Dependent
    {
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Idnumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int SuburbId { get; set; }
        public DateTime DateOfbirth { get; set; }
        public int MedicalAidPlanId { get; set; }
        public bool MedicalAidStatus { get; set; }
        public string MobileNumber { get; set; }
        public int RelationshipTypeId { get; set; }
        public string DependencyCode { get; set; }
        public int MainMemberId { get; set; }

        public virtual Patient MainMember { get; set; }
        public virtual MedicalAidPlan MedicalAidPlan { get; set; }
        public virtual Relationship RelationshipType { get; set; }
        public virtual Suburb Suburb { get; set; }
    }
}
