namespace Lambda3.Statements
{
    internal class Program
    {
        public delegate int MyDelegate(int x, int y, int z);
        static void Main(string[] args)
        {
            //lambda expression for finding the greatest number
            MyDelegate del = (x, y, z) => (x > y) ? (x > z) ? x : z : (y > z) ? y : z;
            Console.WriteLine(del(50, 60, 70));

            Console.WriteLine(GreatestNumber(10, 30, 20));

        }
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
