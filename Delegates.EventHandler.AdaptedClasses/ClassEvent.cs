using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.EventHandlers.AdaptedClasses
{
    public class ClassEvent
    {
        public event EventHandler<AdditionalStatusClass> ProcessEnds;

        public void ProcesBegins()
        {
            var data = new AdditionalStatusClass();
            try
            {
                Console.WriteLine("Process has started");
                data.Status = true;
                data.EndTime = DateTime.Now;
                WhenProcessEnds(data);
            }
            catch (Exception ex)
            {
                data.Status = false;
                data.EndTime = DateTime.Now;
                data.Error = ex;
                WhenProcessEnds(data);
            }
        }
        public void WhenProcessEnds(AdditionalStatusClass e)
        {
            ProcessEnds?.Invoke(this, e);
        }
    }
}
