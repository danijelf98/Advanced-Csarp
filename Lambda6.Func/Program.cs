namespace Lambda6.Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. part: use implicit lambda expression
            //. assign it to func instance

            Func<int, int> Method = x => x + 1;
            Console.WriteLine("Method: {0}", Method.Invoke(100));

            //2. part: use lambda expression with body of expression
            Func<int, int> Method2 = x => 
            { 
                return x + 1; 
            };
            Console.WriteLine("Method 2: {0}", Method.Invoke(100));

            //3. part: using formal parameters
            Func<int, int> Method3 = (int x) => x + 1;
            Console.WriteLine("Method 3: {0}", Method3.Invoke(100));

            //4. part: using the formal parameter with the body of expression
            Func<int, int> Method4 = (int x) => { return x = 1; };
            Console.WriteLine("Method 4: {0}", Method3.Invoke(100));

            //5. part: using more parameters
            Func<int, int, int> Method5 = (x, y) => x * y;
            Console.WriteLine("Method 5: {0}", Method5(20, 3));
        }
    }
}
