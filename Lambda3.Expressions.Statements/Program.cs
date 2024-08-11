namespace Lambda3.Expressions.Statements
{
    internal class Program
    {
        delegate int MyDelegate(int num1, int num2, int num3);
        static void Main(string[] args)
        {
            //lambda expression for checking the greatest number 
            MyDelegate del = (x, y, z) => (x > y) ? (x > z) ? x : z : (y > z) ? y : z;

            Console.WriteLine(del(50, 60, 40));

            Console.WriteLine(GreatestNumber(30, 50, 20));
        }

        // using the if/else statement
        private static int GreatestNumber(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > z) 
            {
                return y;
            }
            else
            {
                return z;
            }
        }
    }
}
