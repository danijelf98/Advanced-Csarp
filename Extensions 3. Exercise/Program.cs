using Extensions_3._Exercise.Extensions;

namespace Extensions_3._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make an string extension to print a number of characters in a console
            //make an string extension to print reversed string from inserted text
            //make a DateTime extension to print which day is in a week
            //make a DateTime extension to print how many years passed from today and inserted year. If inserted year is in minus, print a
            //message to tell that inserted year is not correct

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            text.ReverseText();
            text.CharacterNum();
            Console.WriteLine();

            Console.WriteLine("Enter a date in format: dd/mm/yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());
            date.DayInAWeek();
            date.YearDifference();
            Console.WriteLine();
        }
    }
}
