namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool poruka = true;
                try
                {
                    Console.WriteLine("Unesi broj: ");
                    int a = int.Parse(Console.ReadLine());
                    
                    if (a == 0)
                    {
                        poruka = false;
                        break;
                    }
                    Console.WriteLine($"Kvadrat broja je: {a * a}");
                }
                catch
                {

                    Console.WriteLine("Pokusaj kvadrranja nije uspio!!");
                    Console.WriteLine("Game over");
                }
                finally
                {
                    if (poruka)
                    {
                        Console.WriteLine("Odlicno");
                        Console.WriteLine("Ponovi: ");
                    }
                    
                }
            }
        }
    }
}
