using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.ModelInterfaces
{
    public interface ICalendarEvent
    {
        bool AllDay { get; set; }
        string Description { get; set; }
        DateTime End { get; set; }
        int ID { get; set; }
        DateTime Start { get; set; }
        string Title { get; set; }
    }
}
