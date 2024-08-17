using System.Text;

namespace Extensions_3._Exercise.Extensions
{
    public static class StringExtensions
    {
        public static void CharacterNum(this string text)
        {
            Console.WriteLine($"Text has a {text.Length} characters");
        }

        public static void ReverseText(this string text)
        {
            string reversed = string.Empty;
            foreach (var character in text.Reverse())
            {
                reversed += character;
            }
            Console.WriteLine($"Text in reverse is: {reversed}");
        }
    }
}
