using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventHandler
{
    public class ClassEvent
    {
        public event EventHandler ProcessEnds;
        
        public void ProcessBegin()
        {
            Console.WriteLine("Process started..");
            WhenProcessEnd(EventArgs.Empty);
        }
        protected virtual void WhenProcessEnd(EventArgs e)
        {
            ProcessEnds?.Invoke(this, e);
        }
    }
}
