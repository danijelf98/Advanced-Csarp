namespace Extensions_3._Exercise.Extensions
{
    public static class DateTimeExtensions
    {
        public static void DayInAWeek(this DateTime Day)
        {
            Console.WriteLine($"Day on entered date is: {Day.DayOfWeek}");
        }
        public static void YearDifference(this DateTime dateTime)
        {
            int year = DateTime.Now.Year - dateTime.Year;

            if (year > 0)
            {
                Console.WriteLine($"Year difference from today is: {year} years" );
            }
            else
            {
                Console.WriteLine("Inserted year is not correct");
            }
        }
    }
}
