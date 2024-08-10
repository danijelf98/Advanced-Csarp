namespace Delegates1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassEvent myEvent = new ClassEvent();
            myEvent.ProcessEnded += ProcessEnds;
            myEvent.ProcessEnded += ProcessEndsagain;
            myEvent.ProcessBegin();

            Console.ReadLine();

            static void ProcessEnds()
            {
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("Process has ended...");
            }
            static void ProcessEndsagain()
            {
                Console.WriteLine("");
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("waiting...");
                Console.WriteLine("Process has ended again...");
            }
        }
    }
}
