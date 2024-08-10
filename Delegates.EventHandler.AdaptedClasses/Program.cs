using Delegates.EventHandlers.AdaptedClasses;

namespace Delegates.EventHandler.AdaptedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassEvent myEvent = new ClassEvent();
            myEvent.ProcessEnds += ProcessEnded;
            myEvent.ProcesBegins();

            void ProcessEnded(object sender, AdditionalStatusClass a)
            {
                Console.WriteLine("Process" + (a.Status ? " has succeded" : " has failed"));
                Console.WriteLine("Ending time is: " + a.EndTime.ToLongTimeString());
            }
        }
    }
}
