namespace Nullable_Types_2___condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            int j = 100;

            if (i < j)
            {
                Console.WriteLine("i is smaller than j");
            }
            if (i > j)
            {
                Console.WriteLine("i is bigger than j");
            }
            if (i == j)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("I can't compare them");
            }

            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("'i' is smaller than j");
            }
            if (Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("'i' is bigger than j");
            }
            if (Nullable.Compare<int>(i, j) == 0)
            {
                Console.WriteLine("'i' is the same as j");
            }

        }
    }
}
