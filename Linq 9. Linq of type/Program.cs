using Linq_9._Linq_of_type.Model;
using System.Collections;

namespace Linq_9._Linq_of_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mixedList = new ArrayList();
            mixedList.Add(1);
            mixedList.Add(2);
            mixedList.Add("Keyboard");
            mixedList.Add("Mouse");
            mixedList.Add(new Person() { Id = 1, FullName = "Marko Markov" });

            #region Linq Of type

            //Finds string types
            var stringTypes = from strings in mixedList.OfType<string>()
                              select strings;

            Console.WriteLine("Linq strings of types, in a list are: ");
            foreach (var result in stringTypes)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            //Finds int types
            var intTypes = from ints in mixedList.OfType<int>()
                           select ints;

            Console.WriteLine("Linq ints of types, in a list are:");

            foreach (var result in intTypes)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            //Finds Person types
            var personTypes = from ints in mixedList.OfType<Person>()
                              select ints;

            Console.WriteLine("Linq person of types, in a list are:");

            foreach (var result in personTypes)
            {
                Console.WriteLine(result.FullName);
            }
            Console.WriteLine();

            #endregion

            #region Lambda of types

            var stringTypesLambda = mixedList.OfType<string>();
            var intTypesLambda = mixedList.OfType<int>();
            var personTypesLambda = mixedList.OfType<Person>();

            Console.WriteLine("Lamda string of types are: ");
            foreach (var result in stringTypesLambda)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            Console.WriteLine("Lamda ints of types are: ");
            foreach (var result in intTypesLambda)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            Console.WriteLine("Lamda person of types are: ");
            foreach (var result in personTypesLambda)
            {
                Console.WriteLine(result.FullName);
            } 
            Console.WriteLine();

            #endregion

            #region Exercise 1

            ArrayList mixedNumbers = new ArrayList();
            mixedNumbers.Add(1);
            mixedNumbers.Add(2);
            mixedNumbers.Add("3");
            mixedNumbers.Add("10");
            mixedNumbers.Add(4f);
            mixedNumbers.Add(5f);
            mixedNumbers.Add(6f);
            mixedNumbers.Add(8m);
            mixedNumbers.Add("9");
            mixedNumbers.Add(11m);

            //make a list of all numbers from smaller to bigger
            //make a list of even numbers
            //make a lsit of all numbers bigger than 2 and smaller than 8
            //use Linq ofType

            var converted_and_sorted_nums = mixedNumbers.OfType<IComparable>()
                .Select(i => Convert.ToDecimal(i))
                .OrderBy(i => i)
                .ToList();

            Console.WriteLine("Sorted numbers are: ");
            foreach (var item in converted_and_sorted_nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var evenNums = converted_and_sorted_nums.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Even numbers are: ");
            foreach (var item in evenNums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var smaller_bigger_than2_smaller_than8 = converted_and_sorted_nums.Where(n => n > 2 && n < 8).ToList();

            Console.WriteLine("Numbers bigger than 2, and smaller than 8 are: ");
            foreach (var item in smaller_bigger_than2_smaller_than8)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            #endregion
        }
    }
}
