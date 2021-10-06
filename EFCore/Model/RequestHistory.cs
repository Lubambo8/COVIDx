using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCore.Model
{
    public partial class RequestHistory
    {
        [Key]
        public int TestRequestID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required,
            MaxLength(128)]
        public string OldRequestStatus { get; set; }
    }
}
