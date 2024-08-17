namespace Linq_2._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make a list of colors
            //show colors to user and ask him what color he wants
            //using a Linq, filter colors and choose the one user selected
            //ask user to choose the first letter of a color
            //using linq show all colors who starts with this letter

            List<string> colors = new List<string>() { "blue", "green", "red", "black", "white", "rose", "pink", "gray" };
            Console.WriteLine("Choose a color: ");
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }

            Console.WriteLine();
            string selectedColor = Console.ReadLine();
            while (string.IsNullOrEmpty(selectedColor))
            {
                Console.WriteLine("You didn't type anything, try again: ");
                selectedColor = Console.ReadLine();
            }

            var colorFilter = from color in colors
                              where color == selectedColor
                              select color;

            foreach (string color in colorFilter)
            {
                Console.WriteLine($"Selected color is: {color}");
            }
            Console.WriteLine();
            Console.WriteLine("Type the first letter of a color: ");

            char colorLetter = char.Parse(Console.ReadLine());

            var colorsStartsWithLetter = from color in colors
                                         where color.StartsWith(colorLetter)
                                         select color;
            
            Console.WriteLine($"Colors that starts with letter '{colorLetter}' are: ");

            foreach (string color in colorsStartsWithLetter)
            {
                Console.Write(color + " " );
            }
            Console.WriteLine();

        }
    }
}
