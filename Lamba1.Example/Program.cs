namespace Lamba1.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of random numbers
            List<int> ints = new List<int>() { 35, 9, 8, 15, 23, 45, 11 };
            Console.WriteLine("Numbers: ");
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // lamda expression for squares
            var squareNum = ints.Select(num => num * num).ToList();

            foreach (int num in squareNum)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // lambda expression for finding numbers who are dividible by 3 - version 1
            var divide_by_three = ints.Where(num => num % 3 == 0);
            foreach (int num in divide_by_three)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // lambda expression for finding numbers who are dividible by 3 - version 2
            List<int> divide_three = ints.FindAll(num => (num % 3) == 0);
            foreach (int num in divide_three)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
