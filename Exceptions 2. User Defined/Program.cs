namespace Exceptions_2._User_Defined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.temp = 55;

            try
            {
                temperature.ShowTemperatuer();
            }
            catch (TemperatureIsNull tnull)
            {
                Console.WriteLine($"{tnull.Message}. Time of exception is {tnull.ExceptionTime}");
            }
        }
    }
}
