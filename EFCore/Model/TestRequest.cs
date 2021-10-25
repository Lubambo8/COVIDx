using EFCore.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class TestRequest
    {
        public TestRequest()
        {
            CalendarEvents = new HashSet<CalendarEvent>();
        }
        [Key]
        public int TestRequestID { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }

        [Required,
            MaxLength(128)]
        public TestRequestStatus RequestStatus { get; set; }

        [Required,
            MaxLength(1024)]
        public string TestAddress1 { get; set; }

        [MaxLength(128)]
        public string TestAddress2 { get; set; }

        [Required]
        public int SuburbID { get; set; }
        public int? NurseID { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public int? DependentID { get; set; }

        [ForeignKey(nameof(DependentID))]
        public virtual Dependent Dependent { get; set; }

        [ForeignKey(nameof(NurseID))]
        public virtual Nurse Nurse { get; set; }

        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; set; }

        [ForeignKey(nameof(SuburbID))]
        public virtual Suburb Suburb { get; set; }

        public virtual Test Test { get; set; }

        public int? CalendarEventID { get; set; }

        [ForeignKey(nameof(CalendarEventID))]
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; }
        public virtual ICollection<NurseSchedule> NurseSchedules { get; set; }
    }
}
