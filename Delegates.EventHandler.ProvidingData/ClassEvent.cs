using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.EventHandler.ProvidingData
{
    public class ClassEvent
    {
        public event EventHandler<bool> ProcessEnds;

        public void ProcessBegins()
        {
            try
            {
                Console.WriteLine("Process has started..");
                WhenProcessEnds(true);
            }
            catch (Exception)
            {

                WhenProcessEnds(false);
            }
        }
        public void WhenProcessEnds(bool processStatus)
        {
            ProcessEnds?.Invoke(this, processStatus);
        }
    }
}
