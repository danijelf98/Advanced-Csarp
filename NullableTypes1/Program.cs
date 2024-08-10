namespace NullableTypes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i;
            int? j;

            // or

            Nullable<int> k = null;
            int? l = null;

            // or
            int m = l ?? 0;

            Console.WriteLine($"Value of variable 'k' is: {k.GetValueOrDefault()}");
            k = 100;
            Console.WriteLine($"Value of variable 'k' is: {k.GetValueOrDefault()}");
        }
        
    }
}
