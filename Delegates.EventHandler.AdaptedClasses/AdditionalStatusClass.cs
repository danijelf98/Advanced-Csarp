using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.EventHandlers.AdaptedClasses
{
    public class AdditionalStatusClass : EventArgs
    {
        public bool Status { get; set; }
        public DateTime EndTime { get; set; }
        public Exception Error { get; set; }
    }
}
