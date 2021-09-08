using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class RequestHistory
    {
        public int TestRequestID { get; set; }
        public DateTime Date { get; set; }
        public string OldRequestStatus { get; set; }
    }
}
