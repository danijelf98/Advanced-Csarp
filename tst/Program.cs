namespace tst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 5 , 15, 29, 8, 9, 71, 11};
            var kvadrat = list.Select(broj => broj * broj).ToList();

            foreach (var broj in kvadrat)
            {
                Console.Write($"{broj} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var divisibles_by_three = list.Where(broj => (broj % 3) == 0).ToList();

            foreach (var broj in divisibles_by_three)
            {
                Console.Write($"{broj} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var divisibles_threes = list.FindAll(broj => (broj % 3) == 0);

            foreach (var broj in divisibles_threes)
            {
                Console.Write($"{broj} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
