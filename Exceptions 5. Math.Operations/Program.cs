using System.Threading.Channels;

namespace Exceptions_5._Math.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            float result;

            try
            {
                Console.WriteLine("Insert a number: ");
                num = Convert.ToSingle(Console.ReadLine());
                result = (float)Math.Sqrt(num);
                Console.WriteLine("Result is: {0}", result);
            }
            catch
            {
                Console.WriteLine("An error occurred, I can't calculate the square root ");
            }
        }
    }
}
