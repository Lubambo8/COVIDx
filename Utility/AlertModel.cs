using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class AlertModel
    {
        public string Message { get; set; }
        public AlertType AlertType { get; set; }
    }

    public enum AlertType
    {
        None,
        Error,
        Information,
        Success
    }
}
