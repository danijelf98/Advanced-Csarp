namespace Exceptions_3._Simple_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool printMsg = true;
                try
                {
                    Console.WriteLine("Insert a number:");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 0)
                    {
                        printMsg = false;
                        break;
                    }
                    Console.WriteLine($"Square of inserted number is: {num * num}");
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Please insert a whole number!!");
                    Console.WriteLine();
                }
                finally
                {
                    if (printMsg)
                    {
                        Console.WriteLine("Try again!!");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
