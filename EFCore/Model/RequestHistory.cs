using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class RequestHistory
    {
        public int TestRequestId { get; set; }
        public DateTime Date { get; set; }
        public string OldRequestStatus { get; set; }
    }
}
