using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCore.Model
{
    public partial class RequestHistory
    {
        [Key]
        public int RequestHistoryID { get; set; }

        [Required]
        public int TestRequestID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required,
            MaxLength(128)]
        public string OldRequestStatus { get; set; }

        [ForeignKey(nameof(TestRequestID))]
        public virtual TestRequest TestRequest { get; set; }
    }
}
