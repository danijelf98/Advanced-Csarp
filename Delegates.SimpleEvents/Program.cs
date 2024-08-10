namespace Delegates.SimpleEvents
{
    public delegate void DelegateEventHandler();
    internal class Program
    {
        public static event DelegateEventHandler Add;
        static void Main(string[] args)
        {
            Add += new DelegateEventHandler(Deutschland);
            Add += new DelegateEventHandler(USA);
            Add += new DelegateEventHandler(France);
            Add.Invoke();
        }
        static void Deutschland()
        {
            Console.WriteLine("Deutschland");
        }
        static void USA()
        {
            Console.WriteLine("USA");
        }
        static void France()
        {
            Console.WriteLine("France");
        }
    }
}
