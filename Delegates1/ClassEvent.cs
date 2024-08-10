using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void Notification();
    public class ClassEvent
    {
        public Notification ProcessEnded;

        public void ProcessBegin()
        {
            Console.WriteLine("Process has Started");
            WhenProcessEnd();
        }

        protected virtual void WhenProcessEnd()
        {
            ProcessEnded?.Invoke();
        }
    }
}
