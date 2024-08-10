namespace EventForChangingLastName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ChangeLastName += CahngingLastName;
            person.Name = "Adam";
            person.LastName = "Adamic";

            person.LastName = "Ravic";
            
        }
        static void CahngingLastName(string oldLastName, string newLastName)
        {
            Console.WriteLine($"LastName {oldLastName} je promijenjeno u {newLastName}");
        }

    }
}
