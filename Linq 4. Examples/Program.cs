namespace Linq_4._Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Kiwi", "Avocado"};

            IEnumerable<string> fruitsStartsWithK = from f in fruits
                                                    where f[0] == 'K'
                                                    select f;
            foreach (string f in fruitsStartsWithK)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();
            //Lambda example:
            IEnumerable<string> fruitsStartsK = fruits.Where(f => f[0] == 'K').ToList();
            foreach (string f in fruitsStartsK)
            {
                Console.WriteLine(f);
            }
        }
    }
}
