namespace Delegates.EventHandler.ProvidingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassEvent myEvent = new ClassEvent();
            myEvent.ProcessEnds += ProcessEnding;
            myEvent.ProcessBegins();

            void ProcessEnding(object obj, bool processStatus)
            {
                Console.WriteLine(processStatus ? "Process has succedeed" : "Process has Failed!");
            }
        }
    }
}
