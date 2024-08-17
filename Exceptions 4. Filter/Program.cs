using System.Linq.Expressions;

namespace Exceptions_4._Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insert a random number to divide from 50, or 0 to exit");

                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num == 0)
                    {
                        break;
                    }
                    int result = 50 / num;
                    Console.WriteLine($"The result is: {result}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Wrong format. Please try again.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred");
                }
            }

        }
    }
}
