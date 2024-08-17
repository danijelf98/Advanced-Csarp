namespace Exceptions_1._Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dividing(20, 10);
            Dividing(20, 0);
        }
        static int Dividing(int num1, int num2)
        {
            int result = default;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception is {0}", e);
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine($"Result is: {result}");
            }
            Console.WriteLine();
            return result;
        }
    }
}
