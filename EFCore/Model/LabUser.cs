using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class LabUser
    {
        public LabUser()
        {
            Tests = new HashSet<Test>();
        }

        [Key]
        public int LabUserID { get; set; }

        [Required,
            MaxLength(13)]
        public string IDnumber { get; set; }

        [Required,
            MaxLength(128)]
        public string FirstName { get; set; }

        [Required,
            MaxLength(128)]
        public string LastName { get; set; }

        [Required,
            MaxLength(10)]
        public string MobileNumber { get; set; }

        [Required,
            MaxLength(128)]
        public string EmailAddress { get; set; }

        [Required,
            MaxLength(128)]
        public string Qualification { get; set; }

        [Required]
        public Genders Gender { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
