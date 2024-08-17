namespace Linq_1._Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find a name in array of names, using a linq

            string[] names = { "Bill", "John", "Arnold", "Marshall" };

            var linqQuery = from name in names
                            where name.Contains("John")
                            select name;

            foreach (var linq in linqQuery)
            {
                Console.WriteLine(linq);
            }

            //Find names with letter 'o' in it

            var findO = from name in names
                        where name.Contains('o')
                        select name;

            Console.WriteLine();
            Console.WriteLine("Names with letter 'o' are: ");
            foreach (var linq in findO)
            {
                Console.Write($"{linq}, ");
            }
            Console.WriteLine();
            //Find only positive numbers

            int[] nums = { 1, -2, 3, 4, -5, -6, 7, 8, 9 };

            var positiveNums = from num in nums
                               where num > 0
                               select num;

            Console.WriteLine();
            Console.WriteLine("Positive nums are: ");

            foreach (var num in positiveNums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //Find all numbers in between -5 and 5

            var minus5plus5 = from num in nums
                              where num >= -5 && num <= 5
                              select num;

            Console.WriteLine();
            Console.WriteLine("Nums in between -5 and 5 are: ");

            foreach (var num in minus5plus5)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
