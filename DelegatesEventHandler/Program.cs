namespace DelegatesEventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassEvent myEvent = new ClassEvent();
            myEvent.ProcessEnds += ProcessEnding;
            myEvent.ProcessBegin();

            
            static void ProcessEnding(object sender, EventArgs e)
            {
                Console.WriteLine("waiting....");
                Console.WriteLine("waiting....");
                Console.WriteLine("waiting....");
                Console.WriteLine("waiting....");
                Console.WriteLine("Process ended!");
            }

        }
    }
}
