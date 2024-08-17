namespace Linq_6._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //show text to user, and ask him to choose one word
            //use linq to show how many times this word is repeated in a text

            string text = "The sun was shining brightly. " +
                "The bright sun made the day feel warm. " +
                "Birds chirped as they flew under the bright, shining sun. " +
                "Everyone enjoyed the warmth of the sun on this bright day.";

            Console.WriteLine("Choose a word from this text, to calculate repetition of this word: ");
            Console.WriteLine();
            Console.WriteLine(text);
            string insertedWord = Console.ReadLine();

            var wordRepetition = (from word in text.Split()
                                 where word.Equals(insertedWord)
                                 select word).Count();

            Console.WriteLine();
            Console.WriteLine($"Word '{insertedWord}' is repeated {wordRepetition} times");

            //using a Linq Method syntax style

            var wordRepetitions = text.Split()
                .Count(word => word.Equals(insertedWord));

            Console.WriteLine();
            Console.WriteLine($"Word '{insertedWord}' is repeated {wordRepetitions} times");

           
        }
    }
}
