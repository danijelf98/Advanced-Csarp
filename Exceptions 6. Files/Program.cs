namespace Exceptions_6._Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Test\Example.txt";

            try
            {
                //delete file if exists
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Directory.Exists(fileName);
                Directory.CreateDirectory(@"C:\Test");

                using (StreamWriter str = File.CreateText(fileName))
                {
                    str.WriteLine("Hello and welcome");
                    str.WriteLine();
                    str.WriteLine("This is the First message");
                    str.WriteLine("This is the second message");
                }
                using (StreamReader str = File.OpenText(fileName))
                {
                    string s = string.Empty;
                    Console.WriteLine("There is a written data called: Example.txt");
                    while ((s = str.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();

                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
