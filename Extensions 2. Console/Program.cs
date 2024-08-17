using Extensions_2._Console.Model;

namespace Extensions_2._Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicClass basicClass = new BasicClass();
            Console.WriteLine(basicClass.Print());
            Console.WriteLine(basicClass.Printing());
            basicClass.AdditionalExtensionMethod();
        }
    }
}
